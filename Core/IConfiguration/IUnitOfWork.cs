using Microsoft.EntityFrameworkCore;
using Test.Models;
using Test.Core.IRepositories;

namespace Test.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        
        Task CompleteAsync();
    }
}