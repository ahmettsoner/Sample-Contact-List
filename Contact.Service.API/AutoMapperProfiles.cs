using AutoMapper;

namespace  Contact.Service.API
{
    public class AutoMapperProfiles : Profile{
        public AutoMapperProfiles()
        {
            CreateMap<Data.Models.Person, DomainModels.Person>()
                .ForMember(o=>o.Code, p=>p.MapFrom(x=>x.ID))
                .ReverseMap();

            CreateMap<Data.Models.Contact, DomainModels.Contact>()
                .ForMember(o=>o.Code, p=>p.MapFrom(x=>x.ID))
                .ForMember(o=>o.Type, p=>p.MapFrom(x=>x.ID))
                .ReverseMap();
        }
    }
}