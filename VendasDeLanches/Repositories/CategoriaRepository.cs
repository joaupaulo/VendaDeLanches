using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasDeLanches.Context;
using VendasDeLanches.Models;

namespace VendasDeLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {


        private readonly LanchesContext _context;
        public CategoriaRepository(LanchesContext contexto)
        {
            _context = contexto;

        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
