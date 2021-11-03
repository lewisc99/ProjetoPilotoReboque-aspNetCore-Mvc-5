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

        public string ClienteNomeCompleto { get; set; }

        public string ContratoNumero { get; set; }

        public Fornecedor Fornecedor { get; set; }
       public int FornecedorId { get; set; }



        public DateTime DataDoAcionamento { get; set; }

        public Veiculo Veiculo { get; set; }

        public int VeiculoId { get; set; }

        public string Descricao {get;set;}

        public CausaDaOcorrencia CausaDaOcorrencia { get; set; }

        public string Endereço { get; set; }


        public FormularioAcionamento()
        {

        }

        public FormularioAcionamento(int id, string clienteNomeCompleto,string contratoNumero,
            Fornecedor fornecedor,DateTime dataDoAcionamento,Veiculo veiculo,string descricao,
            CausaDaOcorrencia causaDoAcidente,string endereco)
        {
            Id = id;
            ClienteNomeCompleto = clienteNomeCompleto;
            ContratoNumero = contratoNumero;
            Fornecedor = fornecedor;
            DataDoAcionamento = dataDoAcionamento;
            Veiculo = veiculo;
            Descricao = descricao;
            CausaDaOcorrencia = causaDoAcidente;
            Endereço = endereco;


        }




    }


}
