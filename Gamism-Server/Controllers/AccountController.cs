using Gamism_Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gamism_Server.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        AccountService _account;

        public AccountController(AccountService account)
        {
            _account = account;
        }
        
        [HttpPost]
        [Route("login/google")]
        public async Task<LoginAccountPacketRes> LoginAccount([FromBody] LoginAccountPacketReq req)
        {
            LoginAccountPacketRes res = await _account.LoginGoogleAccount(req.token);
            return res;
        }
        
        [HttpPost]
        [Route("login/guest")]
        public async Task<LoginAccountPacketRes> LoginGuest([FromBody] LoginAccountPacketReq req)
        {
            LoginAccountPacketRes res = await _account.LoginGuestAccount(req.userId);
            return res;
        }
    }
}
