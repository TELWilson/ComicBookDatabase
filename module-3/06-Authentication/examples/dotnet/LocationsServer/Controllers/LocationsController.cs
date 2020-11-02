﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Locations.DAO;
using Locations.Models;

namespace Locations.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationDao _dao;

        public LocationsController(ILocationDao locationsDao = null)
        {
            if (locationsDao == null)
                _dao = new LocationDao();
            else
                _dao = locationsDao;
        }

        [HttpGet]
        public List<Location> List() //no authorization required
        {
            return _dao.List();
        }

        [HttpGet("{id}")]
        [Authorize] //any role can access
        public ActionResult<Location> Get(int id)
        {
            Location location = _dao.Get(id);
            if (location != null)
            {
                return Ok(location);
            }
            else
            {
                return NotFound("Location does not exist");
            }
        }

        [HttpPost]
        [Authorize(Roles = "creator, admin")] //creator and admin can add
        public ActionResult<Location> Add(Location location)
        {
            Location returnLocation = _dao.Create(location);
            return Created($"/locations/{returnLocation.Id}", returnLocation);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "creator, admin")] //creator and admin can update
        public ActionResult<Location> Update(int id, Location location)
        {
            Location existingLocation = _dao.Get(id);
            if (existingLocation == null)
            {
                return NotFound("Location does not exist");
            }

            Location result = _dao.Update(id, location);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")] //only admin can delete
        public ActionResult Delete(int id)
        {
            Location location = _dao.Get(id);
            if (location == null)
            {
                return NotFound("Location does not exist");
            }

            _dao.Delete(id);
            return NoContent();
        }
    }
}
