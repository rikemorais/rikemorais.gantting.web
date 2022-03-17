using System;

namespace gantting.api.models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string AssignmentTitle { get; set; }
        // public string AssignmentDateCreation { get; set; } on click create task
        // public string AssignmentDateDone { get; set; } on click done task
        public string AssignmentDescription { get; set; }
        public string AssignmentDateStart { get; set; }
        public string AssignmentDateEnd { get; set; }
        public string AssignmentImage { get; set; }

        // We still have the modeling of tags, assignees, comments, subtasks and priorities;
        // Study a way to include fields or not in a task. Give several options for creating 
        // fields like in Jira and Pipefy.   
    }
}