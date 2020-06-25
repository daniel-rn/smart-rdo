using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace SmartRdo.API.Controllers
{
    public class AuthController : MainController
    {


        public AuthController(/*INotificador notificador, */
                              SignInManager<IdentityUser> signInManager,
                              UserManager<IdentityUser> userManager,
                              IOptions<AppSettings> appSettings,
                              IUser user,
                              ILogger<AuthController> logger) //: base(notificador, user)
        {

        }
    }
}