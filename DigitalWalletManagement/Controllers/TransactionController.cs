using DigitalWalletManagement.BusinessLayer.Interfaces;
using DigitalWalletManagement.BusinessLayer.Services;
using DigitalWalletManagement.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DigitalWalletManagement.Controllers
{
   
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService walletService)
        {
            _transactionService = walletService;
        }

        [HttpGet]
        [Route("/api/transaction/history")]
        [AllowAnonymous]
        public async Task<IActionResult> RetrieveTransactionHistory([FromQuery] int walletId, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate, [FromQuery] string transactionType)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/api/transaction/{transactionId}")]
        [AllowAnonymous]
        public async Task<IActionResult> RetrieveTransactionDetails(int transactionId)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("/api/transaction/create-transaction")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateTransaction([FromBody] Transaction model)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}
