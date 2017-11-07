using AutoMapper;
using Samples.DomainLayer;
using Samples.WebApi.Dtos;

namespace Samples.WebApi.Mapping
{
    /// <summary>
    /// The mapping profile class.
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// The mapping profile.
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Person, PersonDto>()
                .ForMember(x => x.Name, dest => dest.MapFrom(src => src.Name.Name))
                .ForMember(x => x.Mail, dest => dest.MapFrom(src => src.MailAddress.Address))
                .ForMember(x => x.DateOfBirth, dest => dest.MapFrom(src => src.DateOfBirth.Date));
        }
    }
}