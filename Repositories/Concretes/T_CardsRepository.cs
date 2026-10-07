using Sys_Lesson8.Generics;
using Sys_Lesson8.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys_Lesson8.Repositories.Concretes
{
    internal class T_CardsRepository : IGenericRepository<IT_CardsRepository>, IT_CardsRepository
    {
        public Task AddAsync(IT_CardsRepository student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<IT_CardsRepository>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IT_CardsRepository> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IT_CardsRepository student)
        {
            throw new NotImplementedException();
        }
    }
}
