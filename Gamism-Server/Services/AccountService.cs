using GameDB;

namespace Gamism_Server.Services
{
    public class AccountService
    {
        AccountDbContext _dbContext;
        
        public AccountService(AccountDbContext context)
        {
            _dbContext = context;
        }

        public async Task<LoginAccountPacketRes> LoginGoogleAccount(string token)
        {
            LoginAccountPacketRes res = new LoginAccountPacketRes();

            return res;
        }

        public async Task<LoginAccountPacketRes> LoginGuestAccount(string userId)
        {
            LoginAccountPacketRes res = new LoginAccountPacketRes();

            return res;
        }
    }
}
