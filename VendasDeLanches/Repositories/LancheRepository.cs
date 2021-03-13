using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasDeLanches.Context;
using VendasDeLanches.Models;

namespace VendasDeLanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {

        private readonly LanchesContext _context;

        public LancheRepository(LanchesContext contexto)

        {

            _context = contexto;

        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include( c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include( c => c.Categoria);

        public Lanche GetLancheById(int lancheid)
        {
            return _context.Lanches.FirstOrDefault(l => l.Id == lancheid);
        }
    }
}
