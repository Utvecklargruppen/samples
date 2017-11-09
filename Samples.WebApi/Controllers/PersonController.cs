using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Samples.ApplicationLayer;
using Samples.DomainLayer;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonController" /> class.
        /// </summary>
        public PersonController(IMapper mapper, IPersonInteractor personInteractor)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _personInteractor = personInteractor ?? throw new ArgumentNullException(nameof(personInteractor));
        }

        /// <summary>
        /// Get all persons.
        /// </summary>
        [ProducesResponseType(typeof(List<PersonDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(HttpError), (int)HttpStatusCode.InternalServerError)]
        [HttpGet]
        public IActionResult GetAllPersons()
        {
            var persons = _personInteractor.GetPersons();

            if (persons == null || !persons.Any())
            {
                return NotFound("No persons found.");
            }

            return Ok(_mapper.Map<IEnumerable<PersonDto>>(persons));
        }

        /// <summary>
        /// Get person from id.
        /// </summary>
        [ProducesResponseType(typeof(List<PersonDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(HttpError), (int)HttpStatusCode.InternalServerError)]
        [HttpGet("{id}", Name = "GetPerson")]
        public IActionResult GetPerson(string id)
        {
            var guid = new Guid(id);

            var person = _personInteractor.GetPerson(guid);

            if (person == null)
            {
                return NotFound($"No person found with id {id}.");
            }

            return Ok(_mapper.Map<PersonDto>(person));
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