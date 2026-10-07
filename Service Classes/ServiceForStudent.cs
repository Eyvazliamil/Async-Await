using Sys_Lesson8.Models;
using Sys_Lesson8.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using Sys_Lesson8.Repositories.Concretes;

namespace Sys_Lesson8.Service_Classes
{
    public class ServiceForStudent
    {
        private readonly IUnitOfWork _uow;

        public ServiceForStudent(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task TransferAndAddAsync(Student newStudent, Student existingStudent)
        {
            await _uow.BeginTransactionAsync();

            await _uow.Students.AddAsync(newStudent);
            await _uow.Students.UpdateAsync(existingStudent);

            await _uow.CommitAsync(); 
        }
    }
}
