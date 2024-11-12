using DigitalWalletManagement.DataLayer;
using DigitalWalletManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletManagement.BusinessLayer.Services.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DigitalWalletDbContext _dbContext;
        public TransactionRepository(DigitalWalletDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<Transaction> GetTransactionDetailAsync(int transactionId)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<List<Transaction>> GetTransactionHistoryAsync(int walletId, DateTime startDate, DateTime endDate, string transactionType = null)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}
