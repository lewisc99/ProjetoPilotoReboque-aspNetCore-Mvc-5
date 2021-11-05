
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Models
{
    public class FormularioAcionamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome Precisa Ser Prenchido")]

        [Display(Name = "Cliente Nome Completo")]
        public string ClienteNomeCompleto { get; set; }

        [Required(ErrorMessage = "The Numero do contrato deve ser preenchido")]
        [Display(Name = "Contrato Numero")]
        public string ContratoNumero { get; set; }
        [Required(ErrorMessage = "O nome do Fornecedor deve ser preenchido")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "A data do acionamento deve ser preenchida")]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data Do Acionamento")]
        [DataType(DataType.Date)]

        public DateTime DataDoAcionamento { get; set; }
        [Required(ErrorMessage = "A Placa deve ser preenchida")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O tipo de ocorrência deve ser preenchida")]
        [Display(Name = "Tipo De Ocorrencia")]
        public string TipoDeOcorrencia { get; set; }
        [Required(ErrorMessage = "A Descrição de ocorrência deve ser preenchida")]
        [StringLength(300, MinimumLength = 20, ErrorMessage = "O tamanho da descrição deve ter entre 20 a 300")]

        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Endereço de ocorrência deve ser preenchida")]


        public string Endereço { get; set; }


        public FormularioAcionamento()
        {

        }

        public FormularioAcionamento(string clienteNomeCompleto, string contratoNumero,
            string fornecedor, DateTime dataDoAcionamento,string placa, string tipoDeOcorrencia, string descricao,
             string endereco)
        {

            ClienteNomeCompleto = clienteNomeCompleto;
            ContratoNumero = contratoNumero;
            Fornecedor = fornecedor;
            DataDoAcionamento = dataDoAcionamento;
           Descricao = descricao;
            Endereço = endereco;
            Placa = placa;
            TipoDeOcorrencia = tipoDeOcorrencia;

        }




    }


}
