using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gantting.api.Data;
using gantting.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gantting.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentsController : ControllerBase
    {
        private readonly DataContext _context;

        public AssignmentsController(DataContext context)
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
                assignment => assignment.id == id);
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