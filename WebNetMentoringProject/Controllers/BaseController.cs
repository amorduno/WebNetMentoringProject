using Microsoft.AspNetCore.Mvc;
using WebNetMentoringProject.Attributes;

namespace WebNetMentoringProject.Controllers
{
    [BreadcrumbActionFilter]
    public class BaseController : Controller
    {
    }
}
