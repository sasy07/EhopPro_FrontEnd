using System.Threading.Tasks;
using AngularEshop.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AngularEshop.WebApi.Controllers
{
    public class UsersController : SiteBaseController
    {
        #region Constractor

        private IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        #endregion

        #region Users List

        [HttpGet("Users")]
        public async Task<IActionResult> Users()
        {
            return new ObjectResult(await userService.GetAllUsers());
        }

        #endregion
    }
}