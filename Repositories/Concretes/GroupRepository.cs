using Sys_Lesson8.Generics;
using Sys_Lesson8.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sys_Lesson8.Repositories.Concretes
{
    public class GroupRepository : IGenericRepository<Group>, IGroupRepository
    {
        public Task AddAsync(Group student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Group>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Group> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Group student)
        {
            throw new NotImplementedException();
        }
    }
}
