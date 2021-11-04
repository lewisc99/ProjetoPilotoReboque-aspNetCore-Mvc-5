using Microsoft.AspNetCore.Mvc;
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

        public AcionamentosController(IFormularioRepositorio formularioRepositorio)
        {
            _formularioRepositorio = formularioRepositorio;
        }


        public IActionResult Index()
        {
            var list = _formularioRepositorio.ObterTodos();

            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
