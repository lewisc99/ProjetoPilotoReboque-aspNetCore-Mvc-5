using ProjetoPilotoReboque.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Models.ViewModels
{
    public class LoginColaboradorEFornecedorViewModel
    {

        public Task<ColaboradorLogin> ColaboradorLogin { get; set; }
        public Task<FornecedorLogin> FornecedorLogin { get; set; }
    }
}
