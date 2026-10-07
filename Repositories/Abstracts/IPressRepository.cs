using Sys_Lesson8.Dtos;
using Sys_Lesson8.Generics;
using Sys_Lesson8.Models;

namespace Sys_Lesson8.Repositories.Abstracts;

public interface IPressRepository : IGenericRepository<Press>
{
    Task<List<PressWithBooks>> GetPressWithBooksAsync();
}
