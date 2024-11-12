using DigitalWalletManagement.BusinessLayer.Interfaces;
using DigitalWalletManagement.BusinessLayer.Services.Repository;
using DigitalWalletManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWalletManagement.BusinessLayer.Services
{
    public class SecurityService : ISecurityService
    {
        private readonly ISecurityRepository _securityRepository;

        public SecurityService(ISecurityRepository securityRepository)
        {
            _securityRepository = securityRepository;
        }

        public async Task<TwoFactorAuthenticationRequest> GetSecurityAuditLogAsync(int userId)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<TwoFactorAuthenticationRequest> SetupTwoFactorAuthenticationAsync(int userId, string phoneNumber)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}
