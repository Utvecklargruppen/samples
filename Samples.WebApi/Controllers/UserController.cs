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
    /// The user controller handles all users.
    /// </summary>
    //[Authorize]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserInteractor _userInteractor;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController" /> class.
        /// </summary>
        public UserController(IMapper mapper, IUserInteractor userInteractor)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _userInteractor = userInteractor ?? throw new ArgumentNullException(nameof(userInteractor));
        }

        /// <summary>
        /// Get all users.
        /// </summary>
        [ProducesResponseType(typeof(List<UserDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(HttpError), (int)HttpStatusCode.InternalServerError)]
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userInteractor.GetUsers();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(users));
        }
    }
}