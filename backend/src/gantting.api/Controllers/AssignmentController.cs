using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gantting.api.models;
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
                AssignmentTitle = "Verificar Paineis",
                AssignmentDescription = "Todos os dias, verificar os paineis.",
                AssignmentDateStart = "17/03/2022",
                AssignmentDateEnd = "17/03/2022",
                AssignmentImage = "foto2.png"
                },
                new Assignment() {
                AssignmentId = 2,
                AssignmentTitle = "Reunião Antônio Alves",
                AssignmentDescription = "Reunião de Backlog",
                AssignmentDateStart = "21/03/2022",
                AssignmentDateEnd = "21/03/2022",
                AssignmentImage = "foto2.png"
            }
        };

        [HttpGet]
        public IEnumerable<Assignment> Get()
        {
            return _assignment;
        }

        [HttpGet("{id}")]
        public IEnumerable<Assignment> GetById(int id)
        {
            return _assignment.Where(assignment => assignment.AssignmentId == id);
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