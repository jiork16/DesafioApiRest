using DesafioJordanRodriguesApiRest.Application.Interfaces;
using DesafioJordanRodriguesApiRest.Domain.Entities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJordanRodriguesApiRest.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IRepositoryAsync<User> _repository;
        public IQueryable<User> User => _repository.Entities;
        public UserRepository(IRepositoryAsync<User> repository)
        {
            _repository = repository;
        }
        public async Task<User> GetByIdAsync(int id)
        {
            return await _repository.Entities.Where(p => p.id == id).FirstOrDefaultAsync();
        }
        public async Task<List<User>> GetListAsync()
        {
            IQueryable<User> list = _repository.Entities.Include(c => c.Currency);
            return await list.ToListAsync();
        }        
    }
}
