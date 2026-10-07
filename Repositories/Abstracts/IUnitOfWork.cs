using Microsoft.EntityFrameworkCore.Storage;
using Sys_Lesson8.DbContexts;
using Sys_Lesson8.Models;
using Sys_Lesson8.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys_Lesson8.Repositories.Abstracts;

public interface IUnitOfWork : IDisposable
{
    IStudentRepository Students { get; }
    Task<int> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitAsync();
    Task RollbackAsync(); 
}

public class UnitOfWork : IUnitOfWork
{
    private readonly LibraryContext _context;
    private IDbContextTransaction? _transaction;
    public async Task BeginTransactionAsync() 
    {
        _transaction = await _context.Database.BeginTransactionAsync();
    }
    public IStudentRepository Students { get; }

    public UnitOfWork(LibraryContext context)
    {
        _context = context;
        Students = new StudentRepository(_context);  
    }
    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
        await _transaction!.CommitAsync();
    }

    public void Dispose()
    {
        _transaction?.Dispose(); 
        _context.Dispose();
    }

    public async Task RollbackAsync()
    {
        await _transaction!.RollbackAsync();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}