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
    public class LibsRepository : IGenericRepository<Lib>, ILibsRepository
    {
        public Task AddAsync(Lib student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Lib>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Lib> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Lib student)
        {
            throw new NotImplementedException();
        }
    }
}
