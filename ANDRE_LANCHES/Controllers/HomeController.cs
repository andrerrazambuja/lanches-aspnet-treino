using ANDRE_LANCHES.Models;
using ANDRE_LANCHES.Repositories.Interfaces;
using ANDRE_LANCHES.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ANDRE_LANCHES.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {

            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}