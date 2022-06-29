using ANDRE_LANCHES.Models;
using ANDRE_LANCHES.Repositories.Interfaces;
using ANDRE_LANCHES.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ANDRE_LANCHES.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {

            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(lanche => lanche.Id);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                lanches = _lancheRepository.Lanches
                            .Where(lanche => lanche.Categoria.Nome.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                            .OrderBy(categoria => categoria.Nome);

                categoriaAtual = categoria;
            }

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lancheListViewModel);
        }
    }
}
