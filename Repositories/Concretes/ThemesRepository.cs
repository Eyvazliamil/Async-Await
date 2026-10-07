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
    public class ThemesRepository : IGenericRepository<Theme>, IThemesRepository
    {
        public Task AddAsync(Theme student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Theme>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Theme> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Theme student)
        {
            throw new NotImplementedException();
        }
    }
}
