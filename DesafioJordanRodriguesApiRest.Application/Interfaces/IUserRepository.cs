using DesafioJordanRodriguesApiRest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJordanRodriguesApiRest.Application.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<User> User { get; }

        Task<List<User>> GetListAsync();

        Task<User> GetByIdAsync(int UserId);
    }
}
