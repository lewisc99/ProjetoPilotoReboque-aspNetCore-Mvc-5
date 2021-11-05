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

        public IActionResult LoginColaborador()
        {
            return View();
        }

        [HttpPost]

        public IActionResult LoginColaborador(int? id, ColaboradorLogin colaboradorLogin)
        {

            bool email = _context.ColaboradorLogin.Any(obj => obj.Email == colaboradorLogin.Email);

            bool password = _context.ColaboradorLogin.Any(x => x.Senha == colaboradorLogin.Senha);

            if (email == true && password == true)
            {
                HttpContext.Session.SetString("Login", "true");
                return RedirectToAction("Index", "Persons");
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

            public IActionResult LoginFornecedor()
            {
                return View();
            }


            [HttpPost]

            public IActionResult LoginFornecedor(int? id, FornecedorLogin fornecedorLogin)
            {

                bool email = _context.FornecedorLogin.Any(obj => obj.Email == fornecedorLogin.Email);

                bool password = _context.FornecedorLogin.Any(x => x.Senha == fornecedorLogin.Senha);

                if (email == true && password == true)
                {
                    HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Persons");
                }
                else
                {
                    if (password == false && email == false)
                    {

                        ViewBag.Mensagem = "O email e a senha e invalida.";
                    }
                    else if (email == false)
                    {
                        ViewBag.Mensagem = "O email e invalido.";
                    }
                    else
                    {
                        ViewBag.Mensagem = "A senha e Invalida.";

                    }

                    return View("Login", fornecedorLogin);
                }


            }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }


    }
}
