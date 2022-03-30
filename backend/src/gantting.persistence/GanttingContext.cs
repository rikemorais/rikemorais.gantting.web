using gantting.domain;
using Microsoft.EntityFrameworkCore;

namespace gantting.persistence
{
    public class GanttingContext : DbContext
    {
        public GanttingContext(DbContextOptions<GanttingContext> options)
            : base(options) { }
        public DbSet<Assignee> Assignees { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}