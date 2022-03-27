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
        public DbSet<AssignmentComment> AssignmentsComments { get; set; }
        public DbSet<AssignmentSubtask> AssignmentsSubtasks { get; set; }
        public DbSet<AssignmentTag> AssignmentsTags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssignmentComment>()
                .HasKey(AC => new { AC.AssignmentId, AC.CommentId });
            modelBuilder.Entity<AssignmentSubtask>()
                .HasKey(AS => new { AS.AssignmentId, AS.SubtaskId });
            modelBuilder.Entity<AssignmentTag>() 
                .HasKey(AT => new { AT.AssignmentId, AT.TagId });
        }
    }
}