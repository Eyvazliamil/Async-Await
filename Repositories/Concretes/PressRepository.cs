using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Dtos;
using Sys_Lesson8.Dtos.Author;
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
    public class PressRepository : GenericRepository<Press>, IPressRepository
    { 
        public PressRepository(DbContext context) : base(context)
        {
        }
         
        public async Task<List<PressWithBooks>> GetPressWithBooksAsync()
        { 
            var presses = await _dbSet.ToListAsync();

            var result = presses.Select(x => new PressWithBooks()
            {
                PressName = x.Name,
                BookName = string.Join(" | ", x.Books.Select(a => a.Name))
            }).ToList();

            return result;
        }
         
    }
}
