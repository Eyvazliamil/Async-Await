using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Dtos.Author;
using Sys_Lesson8.Dtos.Student;
using Sys_Lesson8.Generics;
using Sys_Lesson8.Models;
using Sys_Lesson8.Repositories.Abstracts;

namespace Sys_Lesson8.Repositories.Concretes;

public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
{
    public AuthorRepository(DbContext context) : base(context)
    {
    }

    public async Task<List<AuthorWithBooks>> GetAuthorWithTheirBooksAsync()
    {
        var authors = await _dbSet.Include(x => x.Books).ToListAsync();

        var result = authors.Select(x => new AuthorWithBooks()
        {
            Author_Name = x.FirstName + " " + x.LastName, 
            Book_Name = string.Join(", ", x.Books.Select(b => b.Name))
        }).ToList();

        return result;
    }
}
