using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gantting.domain;

namespace gantting.persistence
{
    public interface IGanttingPersistence
    {
        //* Geral
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T[] entity) where T : class;
        Task<bool> SaveChangesAsync();

        //* Assignments
        Task<Assignment> GetAssignmentByIdAsync(int id, bool includeAssignee = false);
        Task<Assignment[]> GetAllAssignmentsByTitleAsync(string title, bool includeAssignee = false);
        Task<Assignment> GetAssignmentByTitleAsync(string title, bool includeAssignee = false);        
    }
}