using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Samples.ApplicationLayer;
using Samples.WebApi.Dtos;
using System;
using System.Collections.Generic;
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
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(HttpError), (int)HttpStatusCode.InternalServerError)]
        [HttpGet]
        public IActionResult GetAllPersons()
        {
            var persons = _personInteractor.GetPersons();
            return Ok(_mapper.Map<IEnumerable<PersonDto>>(persons));
        }
    }
}