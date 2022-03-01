using Microsoft.EntityFrameworkCore;
using Test.Models;
using Test.Core.IRepositories;

namespace Test.Core.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        
    }
}