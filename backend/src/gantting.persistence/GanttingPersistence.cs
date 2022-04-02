using System.Threading.Tasks;
using gantting.domain;

namespace gantting.persistence
{
    public class GanttingPersistence : IGanttingPersistence
    {
        private readonly GanttingContext _context;
        public GanttingPersistence(GanttingContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public Task<Assignment[]> GetAllAssignmentsByTitleAsync(string title, bool includeAssignee = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Assignment> GetAssignmentByIdAsync(int id, bool includeAssignee = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Assignment> GetAssignmentByTitleAsync(string title, bool includeAssignee = false)
        {
            throw new System.NotImplementedException();
        }
    }
}