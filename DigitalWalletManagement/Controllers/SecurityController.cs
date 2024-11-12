using DigitalWalletManagement.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using DigitalWalletManagement.Entities;
using Microsoft.AspNetCore.Http;

namespace DigitalWalletManagement.Controllers
{
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityService _securityService;
        public SecurityController(ISecurityService securityService)
        {
            _securityService = securityService;
        }

        [HttpPost]
        [Route("api/security/two-factor/setup")]
        [AllowAnonymous]
        public async Task<IActionResult> SetupTwoFactorAuthenticationAsync(int userId, string phoneNumber)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/security/audit")]
        public async Task<IActionResult> GetSecurityAuditLogAsync(int userId)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}
