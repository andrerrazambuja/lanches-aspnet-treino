using ANDRE_LANCHES.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ANDRE_LANCHES.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(cat => cat.Nome);
            return View(categorias);
        }
    }
}
