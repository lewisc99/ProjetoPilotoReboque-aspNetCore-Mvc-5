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

        [HttpGet]
        public IActionResult Create()
        {


            return View(new FormularioAcionamento());

        }



        [HttpPost]
        public IActionResult Create( FormularioAcionamento formulario)
        {

             _formularioRepositorio.Adicionar(formulario);


            return RedirectToAction(nameof(Index));

        }


        [HttpGet]
        public IActionResult Editar(int? id)
        {

            var acharId = _formularioRepositorio.ObterPorId(id.Value);


            return View(nameof(Editar), acharId);


          

        }
       
        [HttpPost]
        public IActionResult Editar( FormularioAcionamento formulario)
        {

            _formularioRepositorio.Editar(formulario);


            return RedirectToAction(nameof(Index));




        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {

            var acharId = _formularioRepositorio.ObterPorId(id.Value);


            return View(acharId);




        }

        [HttpPost]
        public IActionResult Delete(int id)
        {

            _formularioRepositorio.Excluir(id);


            return RedirectToAction(nameof(Index));




        }
    }
}
