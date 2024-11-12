using DigitalWalletManagement.BusinessLayer.Interfaces;
using DigitalWalletManagement.BusinessLayer.Services.Repository;
using DigitalWalletManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletManagement.BusinessLayer.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
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
