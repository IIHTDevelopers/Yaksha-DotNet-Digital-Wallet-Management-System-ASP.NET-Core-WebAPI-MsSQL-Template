using DigitalWalletManagement.DataLayer;
using DigitalWalletManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletManagement.BusinessLayer.Services.Repository
{
    public class WalletRepository : IWalletRepository
    {
        private readonly DigitalWalletDbContext _dbContext;
        public WalletRepository(DigitalWalletDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Wallet> AddAsync(Wallet wallet)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int walletId)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<List<Wallet>> GetAll()
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<Wallet> GetByIdAsync(int walletId)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<Wallet> UpdateAsync(Wallet wallet)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}
