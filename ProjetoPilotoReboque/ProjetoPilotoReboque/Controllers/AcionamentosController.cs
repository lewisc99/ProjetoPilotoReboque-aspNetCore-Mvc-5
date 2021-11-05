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


        public async Task<IActionResult> Index()
        {
            var list =await  _formularioRepositorio.ObterTodos();

            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {


            return View(new FormularioAcionamento());

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( FormularioAcionamento formulario)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Create));
            }


           await _formularioRepositorio.Adicionar(formulario);


            return RedirectToAction(nameof(Index));

        }


        [HttpGet]
        public async Task<IActionResult> Editar(int? id)
        {

            var acharId = await _formularioRepositorio.ObterPorId(id.Value);


            return View(nameof(Editar), acharId);


          

        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar( FormularioAcionamento formulario)
        {

            if (!ModelState.IsValid)
            {
                return View(nameof(Editar));
            }

            await _formularioRepositorio.Editar(formulario);


            return RedirectToAction(nameof(Index));




        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });

            }

            var acharId = await  _formularioRepositorio.ObterPorId(id.Value);


            return View(acharId);




        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {

          await  _formularioRepositorio.Excluir(id);


            return RedirectToAction(nameof(Index));




        }
    }
}
