using Microsoft.EntityFrameworkCore;
using Sys_Lesson8.Dtos.Department;
using Sys_Lesson8.Dtos.Student;
using Sys_Lesson8.Generics;
using Sys_Lesson8.Models;
using Sys_Lesson8.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys_Lesson8.Repositories.Concretes;

public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
{
    public TeacherRepository(DbContext context) : base(context)
    {
    }

    public async Task<List<TeacherWithDepartment>> GetTeacherWithDepartmentAsync()
    {
        var teachers = await _dbSet.ToListAsync();

        var result = teachers.Select(x => new TeacherWithDepartment()
        {
            Teacher_Name = x.FirstName + " " +  x.LastName,
            Department_Name = x.IdDepNavigation.Name 
        }).ToList();

        return result;
    }

}
