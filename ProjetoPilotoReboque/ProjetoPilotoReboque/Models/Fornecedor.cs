using ProjetoPilotoReboque.Models.Enums;
using System.Collections;
using System.Collections.Generic;

namespace ProjetoPilotoReboque.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }

        public string Name { get; set; }


        public ICollection<FormularioAcionamento> FormularioAcionamento { get; set; } = new List<FormularioAcionamento>();


        public Fornecedor()
        {

        }
        public Fornecedor( string name)
        {
           
            Name = name;
        }
    }
}