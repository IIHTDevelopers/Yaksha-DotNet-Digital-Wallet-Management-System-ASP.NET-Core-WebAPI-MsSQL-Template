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
    public class WalletController : ControllerBase
    {
        private readonly IWalletService _walletService;
        public WalletController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        [HttpPost]
        [Route("/api/wallet/create")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateWallet([FromBody] Wallet model)
        {
            //Write your code here
            throw new NotImplementedException();

        }

        [HttpGet]
        [Route("/api/wallet/{walletId}")]
        [AllowAnonymous]
        public async Task<IActionResult> RetrieveWallet(int walletId)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/api/wallet/get-all")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllWalletDetails()
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("/api/wallet/update/{walletId}")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateWallet(int walletId,Wallet model)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("/api/wallet/delete/{walletId}")]
        public async Task<IActionResult> DeleteWallet(int walletId)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}
