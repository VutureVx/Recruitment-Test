using AutoMapper;
using Vuture.Models.Dtos;

namespace Vuture.Mapping
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            CreateMap<Contact, ReadContactDto>();
            CreateMap<CreateContactDto, Contact>();
            CreateMap<ReadContactDto, Contact>();
        }
    }
}