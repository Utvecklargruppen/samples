using AutoMapper;
using Samples.DomainLayer.Persons;
using Samples.InfrastructureLayer.Persons;
using System;
using System.Net.Mail;

namespace Samples.InfrastructureLayer.Mapping
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
                .ForMember(personDto => personDto.FirstName, dest => dest.MapFrom(person => person.Name.FirstName))
                .ForMember(personDto => personDto.LastName, dest => dest.MapFrom(person => person.Name.LastName))
                .ForMember(personDto => personDto.MailAddress, dest => dest.MapFrom(person => person.MailAddress.Address))
                .ForMember(personDto => personDto.Id, dest => dest.MapFrom(person => person.Id.ToString()))
                .ForMember(personDto => personDto.DateOfBirth, dest => dest.MapFrom(person => person.DateOfBirth.Date));

            CreateMap<PersonDto, Person>()
                .ForMember(person => person.Name, dest => dest.MapFrom(personDto => new PersonsName(personDto.FirstName, personDto.LastName)))
                .ForMember(person => person.MailAddress, dest => dest.MapFrom(personDto => new MailAddress(personDto.MailAddress)))
                .ForMember(person => person.Id, dest => dest.MapFrom(personDto => new Guid(personDto.Id)))
                .ForMember(person => person.DateOfBirth, dest => dest.MapFrom(personDto => new BirthDate(personDto.DateOfBirth)));

            CreateMap<CreatePersonDto, Person>()
                .ForMember(person => person.Name, dest => dest.MapFrom(createPersonDto => new PersonsName(createPersonDto.FirstName, createPersonDto.LastName)))
                .ForMember(person => person.MailAddress, dest => dest.MapFrom(createPersonDto => new MailAddress(createPersonDto.MailAddress)))
                .ForMember(person => person.DateOfBirth, dest => dest.MapFrom(createPersonDto => new BirthDate(createPersonDto.DateOfBirth)));
        }
    }
}