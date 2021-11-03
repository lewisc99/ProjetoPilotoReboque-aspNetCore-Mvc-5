using ProjetoPilotoReboque.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Models
{
    public class FormularioAcionamento
    {
        public int Id { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public DateTime DataDoAcionamento { get; set; }

        public Veiculo Veiculo { get; set; }

        public string Descricao {get;set;}

        public CausaDaOcorrencia CausaDaOcorrencia { get; set; }

        public string Endereço { get; set; }




    }

  
}
