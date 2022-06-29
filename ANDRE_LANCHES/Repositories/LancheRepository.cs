using ANDRE_LANCHES.Context;
using ANDRE_LANCHES.Models;
using ANDRE_LANCHES.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ANDRE_LANCHES.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(lanche => lanche.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
                                                            .Where(lanche => lanche.IsLanchePreferido)
                                                            .Include(lanche => lanche.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(lanche => lanche.Id == lancheId);
        }
    }
}
