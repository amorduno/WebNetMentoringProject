using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecurityApp.Controllers
{
    public class AccessController : Controller
    {
        [AllowAnonymous]
        public IActionResult AllAccess()
        {
            return View();
        }

        [Authorize]
        public IActionResult AuthorizedAccess()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult AdministratorAccessByRole()
        {
            return View();
        }

        [Authorize(Roles = "Operator,Administrator")]
        public IActionResult OperatorORAdminAccess()
        {
            return View();
        }

        [Authorize(Policy = "Administrator")]
        public IActionResult AdministratorAccessByPolicy()
        {
            return View();
        }

        [Authorize(Policy = "Admin_CreateAccess")]
        public IActionResult Admin_CreateAccess()
        {
            return View();
        }

        [Authorize(Policy = "Admin_Create_Edit_DeleteAccess")]
        public IActionResult Admin_Create_Edit_DeleteAccess()
        {
            return View();
        }

        [Authorize(Policy = "OnlyAdminChecker")]
        public IActionResult OnlyAdminChecker()
        {
            return View();
        }
    }
}
