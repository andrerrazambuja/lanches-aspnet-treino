using ANDRE_LANCHES.Context;
using ANDRE_LANCHES.Models;
using ANDRE_LANCHES.Repositories.Interfaces;

namespace ANDRE_LANCHES.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
