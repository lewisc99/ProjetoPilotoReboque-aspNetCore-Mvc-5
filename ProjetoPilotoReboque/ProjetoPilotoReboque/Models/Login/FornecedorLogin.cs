﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Models.Login
{
    public class FornecedorLogin:ILogin
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }



        public FornecedorLogin()
        {

        }
        public FornecedorLogin(int id, string nomeCompleto, string email, string senha)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Email = email;
            Senha = senha;
        }

    }
}
