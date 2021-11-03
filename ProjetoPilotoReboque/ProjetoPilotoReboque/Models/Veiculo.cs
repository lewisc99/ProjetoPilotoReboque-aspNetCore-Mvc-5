using ProjetoPilotoReboque.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Models
{
    public class Veiculo
    {

        public int VeiculoId { get; set; }

        public string Modelo { get; set; }

        public string Placa { get; set; }

        public GrupoDeVeiculo Grupo { get; set; }

        public ICollection<FormularioAcionamento> FormularioAcionamento { get; set; } = new List<FormularioAcionamento>();

       

        public Veiculo( string modelo,  string placa, GrupoDeVeiculo grupo)
        {
           
            Modelo = modelo;
            Placa = placa;
            Grupo = grupo;
        }
    }
}
