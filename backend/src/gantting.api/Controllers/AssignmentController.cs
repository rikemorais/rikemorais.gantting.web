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
    public class AssignmentController : ControllerBase
    {
        public IEnumerable<Assignment> _assignment = new Assignment[] {
            new Assignment() {
                AssignmentId = 1,
                AssignmentTitle = "Verificar Painéis",
                AssignmentDescription = "Todos os dias, verificar os painéis.",
                AssignmentDateStart = "17/03/2022",
                AssignmentDateEnd = "17/03/2022",
                AssignmentImage = "print.png"
                },
                new Assignment() {
                AssignmentId = 2,
                AssignmentTitle = "Reunião Antônio Alves",
                AssignmentDescription = "Reunião de Backlog",
                AssignmentDateStart = "21/03/2022",
                AssignmentDateEnd = "21/03/2022",
                AssignmentImage = "erro.png"
            }
        };
        private readonly DataContext _context;

        public AssignmentController(DataContext context)
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
                assignment => assignment.AssignmentId == id);
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