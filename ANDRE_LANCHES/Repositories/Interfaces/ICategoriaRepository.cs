using ANDRE_LANCHES.Models;

namespace ANDRE_LANCHES.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
