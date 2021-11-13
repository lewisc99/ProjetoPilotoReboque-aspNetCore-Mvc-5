using ProjetoPilotoReboque.Models;

using ProjetoPilotoReboque.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Data
{
    public class EnviarDados
    {


        private   PilotoReboqueContext _context;

       public EnviarDados(PilotoReboqueContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            if(_context.ColaboradorLogin.Any() || _context.FornecedorLogin.Any() || _context.FormularioAcionamento.Any())
            {
                return;
            }
            else
            {
                


                ColaboradorLogin colaborador1 = new ColaboradorLogin( "Maria Jose Fernandes", "mariajose@gmail.com", "Acionamento@123");
                ColaboradorLogin colaborador2 = new ColaboradorLogin( "Eugenio Matar", "eugeniomatar@gmail.com", "Acionamento@245");
                ColaboradorLogin colaborador3 = new ColaboradorLogin( "Salin Matar costa", "salinmatar@gmail.com", "Acionamento@578");




                FornecedorLogin fornecedor1 = new FornecedorLogin( "Salin Matar", "salinmatar@europ.com", "Europe@157");
                FornecedorLogin fornecedor2= new FornecedorLogin( "Bruno Lazasqui", "brunolazasqui@facil.com", "facile@157");
                FornecedorLogin fornecedor3 = new FornecedorLogin( "Tamires Araujo Souza", "tamires@ike.com", "ikee@157");



                FormularioAcionamento formulario = new FormularioAcionamento("Maria De Jesus", "agvig5458", "europp", new DateTime(2021, 09, 12), "que9182","pane", "Veiculo colidiu com uma carreta","Rua tamires 23 bairro Novo horizonte, Centro MG");

             


                _context.ColaboradorLogin.AddRange(colaborador1, colaborador2, colaborador3);

              
                _context.FornecedorLogin.AddRange(fornecedor1, fornecedor2, fornecedor3);
           
                _context.FormularioAcionamento.Add(formulario);

                _context.SaveChanges();

            }


        }
    }
}
