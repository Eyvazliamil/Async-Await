using Sys_Lesson8.Dtos.Author;
using Sys_Lesson8.Generics;
using Sys_Lesson8.Models;

namespace Sys_Lesson8.Repositories.Abstracts;

public interface IAuthorRepository : IGenericRepository<Author>
{
    Task<List<AuthorWithBooks>> GetAuthorWithTheirBooksAsync();
}
