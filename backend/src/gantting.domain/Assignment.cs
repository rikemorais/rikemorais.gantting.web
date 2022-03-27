using System;
using System.Collections.Generic;

namespace gantting.domain
{
    public class Assignment
    {
        public int Id { get; set; }
        public int AssigneeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Creation { get; set; }
        public DateTime? Done { get; set; }
        public DateTime? Start { get; set; }
        public DateTime End { get; set; }
        public string Image { get; set; }
        public string Priority { get; set; }
        public IEnumerable<AssignmentComment> AssignmentsComments { get; set; }
        public IEnumerable<AssignmentSubtask> AssignmentsSubtasks { get; set; }
        public IEnumerable<AssignmentTag> AssignmentsTags { get; set; }
    }
}