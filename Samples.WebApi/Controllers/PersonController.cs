using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Samples.ApplicationLayer.Persons;
using Samples.DomainLayer.Persons;
using Samples.InfrastructureLayer.Persons;
using Samples.WebApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Samples.WebApi.Controllers
{
    /// <summary>
    /// The person controller handles all persons.
    /// </summary>
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPersonInteractor _personInteractor;
        private readonly IPersonQueries _personQueries;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonController" /> class.
        /// </summary>
        public PersonController(IMapper mapper, IPersonInteractor personInteractor, IPersonQueries personQueries)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _personInteractor = personInteractor ?? throw new ArgumentNullException(nameof(personInteractor));
            _personQueries = personQueries ?? throw new ArgumentNullException(nameof(personQueries));
        }

        /// <summary>
        /// Get all persons.
        /// </summary>
        [ProducesResponseType(typeof(IEnumerable<IPersonDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(HttpError), (int)HttpStatusCode.InternalServerError)]
        [HttpGet]
        public IActionResult GetAllPersons()
        {
            var persons = _personQueries.GetAllPersons();

            if (persons == null || !persons.Any())
            {
                return NotFound("No persons found.");
            }

            return Ok(persons);
            //return Ok(_mapper.Map<IEnumerable<PersonDto>>(persons));
        }

        /// <summary>
        /// Get person from id.
        /// </summary>
        [ProducesResponseType(typeof(IPersonDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(HttpError), (int)HttpStatusCode.InternalServerError)]
        [HttpGet("{id}", Name = "GetPerson")]
        public IActionResult GetPerson(string id)
        {
            var guid = new Guid(id);

            var person = _personQueries.GetPerson(guid);

            if (person == null)
            {
                return NotFound($"No person found with id {id}.");
            }

            return Ok(person);
            //return Ok(_mapper.Map<PersonDto>(person));
        }

        /// <summary>
        /// Post a new person.
        /// </summary>
        [ProducesResponseType(typeof(PersonDto), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(HttpError), (int)HttpStatusCode.InternalServerError)]
        [HttpPost]
        public IActionResult PostPerson([FromBody]CreatePersonDto personDto)
        {
            var person = _mapper.Map<Person>(personDto);

            var createdPerson = _personInteractor.CreatePerson(person);

            var createdPersonDto = _mapper.Map<PersonDto>(createdPerson);

            return CreatedAtRoute("GetPerson", new { id = createdPersonDto.Id }, createdPersonDto);
        }
    }
}