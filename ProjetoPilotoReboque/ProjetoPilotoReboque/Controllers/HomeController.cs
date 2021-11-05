using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoPilotoReboque.Data;
using ProjetoPilotoReboque.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Controllers
{
    public class HomeController : Controller
    {
        private readonly PilotoReboqueContext _context;

        public HomeController(PilotoReboqueContext context )
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async  Task<IActionResult> Login(int? id, ColaboradorLogin colaboradorLogin)
        {

            bool email =  _context.ColaboradorLogin.Any(obj => obj.Email == colaboradorLogin.Email);

            bool password =  _context.ColaboradorLogin.Any(x => x.Senha == colaboradorLogin.Senha);

            if (email == true && password == true)
            {
                HttpContext.Session.SetString("Login", "true");
                return RedirectToAction("Index", "Acionamentos");
            }
            else
            {
                if (password == false && email == false)
                {

                    ViewBag.Mensagem = "The email and  Password is invalid.";
                }
                else if (email == false)
                {
                    ViewBag.Mensagem = "The E-mail is invalid.";
                }
                else
                {
                    ViewBag.Mensagem = "The Password is invalid.";

                }

                return View("Login", colaboradorLogin);
            }
        }

       
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }


    }
}
