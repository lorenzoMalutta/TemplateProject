using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BestPractices101.Controllers
{
    public class BaseController : ControllerBase
    {
        protected string UserName => User.Identity.Name;
        protected string UserEmail => User.FindFirstValue(ClaimTypes.Email);
        protected Guid UserId => Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

        public BaseController() { }

    }
}
