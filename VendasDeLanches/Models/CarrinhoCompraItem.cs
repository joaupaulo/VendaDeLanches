using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VendasDeLanches.Models
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Lanche lanche { get; set; }

        public int Quantidade { get; set; }
        [StringLength(200)]
        public int CarrinhoCompraId { get; set; }
    }
    
}
