using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendasDeLanches.Repositories;
using VendasDeLanches.ViewModel;

namespace VendasDeLanches.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILancheRepository _lancheRepository;
        private readonly ICategoriaRepository _categoriaRepository;

     public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }



        public IActionResult List()
       
        {


            ViewBag.Lanche = "Lanches";
            ViewData["Categoria"] = "Categorias";
            // var lanches = _lancheRepository.Lanches;
            //return View(lanches);

            var lanchelistViewModel = new LancheListViewModel();
            lanchelistViewModel.Lanches = _lancheRepository.Lanches;
            lanchelistViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchelistViewModel);
        }

    }
}
