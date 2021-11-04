using Microsoft.AspNetCore.Mvc;
using ProjetoPilotoReboque.Data;
using ProjetoPilotoReboque.Models;
using ProjetoPilotoReboque.Models.ViewModels;
using ProjetoPilotoReboque.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Controllers
{
    public class AcionamentosController : Controller
    {
        private readonly IFormularioRepositorio _formularioRepositorio;
        private readonly PilotoReboqueContext _pilotoReboqueContext;

        public AcionamentosController(IFormularioRepositorio formularioRepositorio, PilotoReboqueContext pilotoReboqueContext)
        {
            _formularioRepositorio = formularioRepositorio;
            _pilotoReboqueContext = pilotoReboqueContext;
        }


        public IActionResult Index()
        {
            var list = _formularioRepositorio.ObterTodos();

            return View(list);
        }

        public IActionResult Create()
        {

            var fornecedores = _pilotoReboqueContext.Fornecedor.ToList();
            var veiculos = _pilotoReboqueContext.Veiculo.ToList();


            var viewModel = new FormularioDeAcionamentoViewModel { Fornecedores = fornecedores, Veiculos = veiculos };

            return View(viewModel);

        }

        public IActionResult Update(int id, FormularioAcionamento formulario )
        {
            _formularioRepositorio.Editar(id,formulario);

            return RedirectToAction(nameof(Index));


        }
        public IActionResult Details()
        {
            return View();

        }

        public IActionResult Delete(int id)
        {
            _formularioRepositorio.Excluir(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
