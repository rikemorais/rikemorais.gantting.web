using System;

namespace gantting.api.Models
{
    public class Assignment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        // TODO: public string datecreation { get; set; } on click create task
        // TODO: public string datedone { get; set; } on click done task
        public string description { get; set; }
        public string datestart { get; set; }
        public string dateend { get; set; }
        public string image { get; set; }

        // !We still have the modeling of tags, assignees, comments, subtasks and priorities;
        // !Study a way to include fields or not in a task. Give several options for creating fields like in Jira and Pipefy.   
    }
}