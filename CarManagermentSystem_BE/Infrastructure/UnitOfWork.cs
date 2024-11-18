using Application;
using Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private readonly IAccountRepository _accountRepository;
        public UnitOfWork(AppDbContext dbContext
                        , IAccountRepository accountRepository)
        {
            _dbContext = dbContext;
            _accountRepository = accountRepository;
        }

        public IAccountRepository accountRepository => _accountRepository;

        public async Task<int> SaveChangeAsync() => await _dbContext.SaveChangesAsync();
    }
}
