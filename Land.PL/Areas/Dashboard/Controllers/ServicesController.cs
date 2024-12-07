using AutoMapper;
using Land.DAL.Data;
using Land.DAL.Models;
using Land.PL.Areas.Dashboard.ViewModels;
using Land.PL.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace Land.PL.Areas.Dashboard.Controllers
{
   // addTOROleAsync("User)
    //[Authorize(Roles = "Admin,SuperAdmin,User")]
    [Area("Dashboard")]
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ServicesController(ApplicationDbContext context  ,IMapper mapper) {
            this.context = context;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var services = context.Services.ToList();
            var servicesVM = mapper.Map<IEnumerable<ServicesVM>>(services);
            return View(servicesVM);
        }

        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ServiceFormVM vm)
        {
            if (!ModelState.IsValid) { 
               return View(vm);
            }
            vm.ImageName = FilesSetting.UploadFile(vm.Image,"images");
            var service = mapper.Map<Service>(vm);
            context.Add(service);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var service = context.Services.Find(id);
            if(service is null)
            {
                return NotFound();
            }

            var servicesmodel = mapper.Map<ServiceDetailsVM>(service);

            return View(servicesmodel);
        }

        public IActionResult Edit(int id)
        {
            var service = context.Services.Find(id);
            if (service is null)
            {
                return NotFound();
            }
            var servicesvm = mapper.Map<ServiceFormVM>(service);
            return View(servicesvm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServiceFormVM vm)
        {
            var service = context.Services.Find(vm.Id);
            if (!ModelState.IsValid) {
                return View(vm);
            }
           if(vm.Image is null)
            {
                ModelState.Remove("Image");
            }
            else
            {
                vm.ImageName = FilesSetting.UploadFile(vm.Image, "images");
            }
            if (service is null)
            {
                FilesSetting.DeleteFile(service.ImageName,"images");
                return NotFound();
            }
           
            mapper.Map(vm, service);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var service = context.Services.Find(id);
        //    if (service is null)
        //    {
        //        return NotFound();
        //    }

        //    var serviceVM=mapper.Map<ServicesVM>(service);
        //    return View(serviceVM);
        //}

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var service = context.Services.Find(id);
            if (service is null)
            {
                return NotFound();
            }
            FilesSetting.DeleteFile(service.ImageName,"images");
            context.Services.Remove(service);
            context.SaveChanges();

            return Ok(new {Message="service deleted"});
        }

    }
}
