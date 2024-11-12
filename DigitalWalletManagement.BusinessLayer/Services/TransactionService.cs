using DigitalWalletManagement.BusinessLayer.Interfaces;
using DigitalWalletManagement.BusinessLayer.Services.Repository;
using DigitalWalletManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletManagement.BusinessLayer.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
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
