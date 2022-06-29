using Microsoft.AspNetCore.Mvc;

namespace ANDRE_LANCHES.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return "index admin";
        }
        public string Demo()
        {
            return "demo admin";
        }
    }
}
