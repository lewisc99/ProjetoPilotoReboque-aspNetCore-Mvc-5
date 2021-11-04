using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Models.ViewModels
{
    public class FormularioDeAcionamentoViewModel
    {

        public ICollection<Fornecedor> Fornecedores { get; set; }

        public ICollection<Veiculo>  Veiculos { get; set; }


        public FormularioAcionamento FormularioAcionamentos { get; set; }
    }
}
