using Sys_Lesson8.DbContexts;
using Sys_Lesson8.Models;
using Sys_Lesson8.Repositories.Abstracts;
using Sys_Lesson8.Repositories.Concretes;
using Sys_Lesson8.Service_Classes;

class Program
{
    static async Task Main(string[] args)
    {
        var dbContext = new LibraryContext();

        #region StudentsWithGroups
        //StudentRepository studentRepo = new StudentRepository(dbContext);

        //CategoryRepository categoryRepository = new CategoryRepository(dbContext);

        //var allStudent = await studentRepo.GetAllStudentWithGroupNameAsync();

        ////  var allStudent = await studentRepo.GetAllAsync();
        //// 
        //foreach (var student in allStudent)
        //{
        //    Console.WriteLine($"{student.Name} {student.Surname} => {student.GroupName}");
        //}
        #endregion


        #region AuthorsWithBooks
        //AuthorRepository authorRepo = new AuthorRepository(dbContext);

        //BookRepository bookRepo = new BookRepository(dbContext);

        //var allauthors= await authorRepo.GetAuthorWithTheirBooksAsync();

        //foreach (var author in allauthors)
        //{
        //    Console.WriteLine($"{author.Author_Name} => {author.Book_Name}");
        //} 
        #endregion


        #region AuthorsWithBooks
        //PressRepository pressRepo = new PressRepository(dbContext);

        //BookRepository bookRepo = new BookRepository(dbContext);

        //var allpresses = await pressRepo.GetPressWithBooksAsync();

        //foreach (var press in allpresses)
        //{
        //    Console.WriteLine($"{press.PressName} => {press.BookName}");
        //} 
        #endregion


        #region TeacherWithDepartment
        //TeacherRepository teacherRepo = new TeacherRepository(dbContext);

        //DepartmentRepository departmentRepo = new DepartmentRepository(dbContext);

        //var allteachers = await teacherRepo.GetTeacherWithDepartmentAsync();

        //foreach (var teacher in allteachers)
        //{
        //    Console.WriteLine($"{teacher.Teacher_Name} => {teacher.Department_Name}");
        //}
        #endregion 

        var context = new LibraryContext();
        var uow = new UnitOfWork(context);
        var service = new ServiceForStudent(uow);

        var newStudent = new Student
        {
            FirstName = "Batman",
            LastName = "Gotham",
            IdGroup = 10,   
            Term = 1
        };

        var existingStudent = await uow.Students.GetByIdAsync(5);  
        if (existingStudent == null)
        {
            Console.WriteLine("Student not found!");
            return;
        }
        existingStudent.Term = 2;

        await service.TransferAndAddAsync(newStudent, existingStudent);
        Console.WriteLine("Successfully completed!");
    }
}