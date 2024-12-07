using Land.DAL.Models;

namespace Land.PL.Areas.Dashboard.ViewModels
{
    public class ViolationsFormVM
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public IFormFile Video { get; set; }
        public string? Video_Url { get; set; }

        public DateTime Reported_Date { get; set; }

        public string Car_Number { get; set; }

        public string Location { get; set; }
        public string Status { get; set; }
        public int CitizenId { get; set; }
        public Citizen Citizen { get; set; }
    }
}
