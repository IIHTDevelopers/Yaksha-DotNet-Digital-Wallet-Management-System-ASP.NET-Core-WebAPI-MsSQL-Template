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
    public class SecurityRepository : ISecurityRepository
    {
        private readonly DigitalWalletDbContext _dbContext;
        public SecurityRepository(DigitalWalletDbContext dbContext)
        {
            _dbContext = dbContext;
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
