using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gantting.domain
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTime Creation { get; set; } = DateTime.Now;
        public int AssignmentId { get; set; }
    }
}