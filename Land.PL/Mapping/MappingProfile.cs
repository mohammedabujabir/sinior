using AutoMapper;
using Land.DAL.Models;
using Land.PL.Areas.Dashboard.ViewModels;

namespace Land.PL.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile() {

            CreateMap<ServiceFormVM, Service>().ReverseMap();
            CreateMap<ViolationsFormVM, TrafficViolation>().ReverseMap();
            CreateMap<Service, ServicesVM>();
            CreateMap<Citizen, CitizenVM>();
            CreateMap<Service, ServiceDetailsVM>();
            
        }
    }
}
