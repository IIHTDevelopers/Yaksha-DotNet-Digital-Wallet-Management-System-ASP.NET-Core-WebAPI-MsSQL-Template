using DigitalWalletManagement.DataLayer;
using DigitalWalletManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletManagement.BusinessLayer.Services.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DigitalWalletDbContext _dbContext;
        public PaymentRepository(DigitalWalletDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Payment> MakeInstantPaymentAsync(int walletId, decimal amount, int recipientId)
        {
            //Write your code here
            throw new NotImplementedException();

        }

        public async Task<Payment> SchedulePaymentAsync(int walletId, decimal amount, int recipientId, string frequency, DateTime startDate)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}
