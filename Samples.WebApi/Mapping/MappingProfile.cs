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
            CreateMap<User, UserDto>();

            //CreateMap<User, UserDto>()
            //    .ForMember(x => x.Alerts, dest => dest.MapFrom(src => src.ServerUsers.Select(us => us.ServerId)))
            //    .ForMember(x => x.CustomerIds, dest => dest.MapFrom(src => src.CustomerUsers.Select(cu => cu.CustomerId)));

            //CreateMap<Customer, CustomerDto>()
            //    .ForMember(x => x.ServerDtos, dest => dest.MapFrom(src => src.Servers));
        }
    }
}