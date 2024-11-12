using DigitalWalletManagement.BusinessLayer.Interfaces;
using DigitalWalletManagement.BusinessLayer.Services.Repository;
using DigitalWalletManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletManagement.BusinessLayer.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;

        public WalletService(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
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
