using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Models.Login
{
    public class ColaboradorLogin:ILogin
    {

        public int Id { get; set; }

        public string NomeCompleto { get; set; }
        public string Email { get; set; }

        public string Senha { get; set; }


        public ColaboradorLogin()
        {

        }

        public ColaboradorLogin( string nomeCompleto, string email, string senha)
        {
           
            NomeCompleto = nomeCompleto;
            Email = email;
            Senha = senha;
        }


    }
}
