using Sys_Lesson8.Generics;
using Sys_Lesson8.Models;
using Sys_Lesson8.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys_Lesson8.Repositories.Concretes
{
    public class FacultyRepository : IGenericRepository<Faculty>, IFacultyRepository
    {
        public Task AddAsync(Faculty student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Faculty>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Faculty> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Faculty student)
        {
            throw new NotImplementedException();
        }
    }
}
