using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gantting.domain
{
    public class AssignmentSubtask
    {
        public int SubtaskId { get; set; }
        public Tag Tag { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public IEnumerable<AssignmentSubtask> AssignmentsSubtasks { get; set; }
    }
}