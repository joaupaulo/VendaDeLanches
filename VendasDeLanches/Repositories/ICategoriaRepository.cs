using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasDeLanches.Models;

namespace VendasDeLanches.Repositories
{
    public interface ICategoriaRepository
    {

        IEnumerable<Categoria> Categorias { get; }
    }
}
