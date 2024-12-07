using AutoMapper;
using Land.DAL.Data;
using Land.DAL.Models;
using Land.PL.Areas.Dashboard.ViewModels;
using Land.PL.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Land.PL.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CitizensController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public CitizensController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var citizens = context.Citizens.ToList();
            var citizenVM = mapper.Map<IEnumerable<CitizenVM>>(citizens);
            return View(citizenVM);
        }
        public IActionResult Create()
        {
            

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ViolationsFormVM vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            vm.Video_Url = FilesSetting.UploadFile(vm.Video,"video");
            var violation = mapper.Map<TrafficViolation>(vm);
            context.Add(violation);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
