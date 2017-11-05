﻿using AutoMapper;
using Samples.DomainLayer;
using Samples.InfrastructureLayer.Daos;
using System;
using System.Net.Mail;

namespace Samples.InfrastructureLayer.Mapping
{
    /// <summary>
    /// The mapping profile class.
    /// </summary>
    public class DataMappingProfile : Profile
    {
        /// <summary>
        /// The mapping profile.
        /// </summary>
        public DataMappingProfile()
        {
            CreateMap<PersonDao, Person>()
               .ForMember(person => person.MailAddress, dest => dest.MapFrom(personDao => CreateMailAddress(personDao.MailAddress)))
               .ForMember(person => person.DateOfBirth, dest => dest.MapFrom(personDao => CreateDateOfBirth(personDao.DateOfBirth)))
               .ForMember(person => person.Name, dest => dest.MapFrom(personDao => CreateName(personDao.FirstName, personDao.LastName)));
        }

        private static BirthDate CreateDateOfBirth(DateTime dateOfBirth)
            => new BirthDate(dateOfBirth);

        private static MailAddress CreateMailAddress(string mailAddress)
            => new MailAddress(mailAddress);

        private static PersonsName CreateName(string firstName, string lastName)
            => new PersonsName(firstName, lastName);
    }
}