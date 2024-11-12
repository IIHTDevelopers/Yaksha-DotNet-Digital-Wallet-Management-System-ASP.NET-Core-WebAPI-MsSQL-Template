using DigitalWalletManagement.BusinessLayer.Interfaces;
using DigitalWalletManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DigitalWalletManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        [Route("/api/payment/schedule")]
        [AllowAnonymous]
        public async Task<IActionResult> ScheduledPayment([FromQuery] int walletId, [FromQuery] decimal amount, [FromQuery] int recipientId, [FromQuery] string frequency, [FromQuery] DateTime startDate)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/api/payment/instant")]
        [AllowAnonymous]
        public async Task<IActionResult> InstantPayment([FromQuery] int walletId, [FromQuery] decimal amount, [FromQuery] int recipientId)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}