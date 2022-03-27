using System;
using System.Collections.Generic;
using System.Linq;
using gantting.persistence;
using gantting.domain;
using Microsoft.AspNetCore.Mvc;

namespace gantting.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentsController : ControllerBase
    {
        private readonly GanttingContext _context;

        public AssignmentsController(GanttingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Assignment> Get()
        {
            return _context.Assignments;
        }

        [HttpGet("{id}")]
        public Assignment GetById(int id)
        {
            return _context.Assignments.FirstOrDefault(
                assignment => assignment.Id == id);
        }

        [HttpPost]
        public String Post()
        {
            return "Post";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
            return $"Put {id}";
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {
            return $"Delete {id}";
        }
    }
}