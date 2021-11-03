using ProjetoPilotoReboque.Models;
using ProjetoPilotoReboque.Models.Enums;
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
            if(_context.ColaboradorLogin.Any() || _context.Fornecedor.Any() || _context.Veiculo.Any() || _context.FornecedorLogin.Any())
            {
                return;
            }
            else
            {
                Fornecedor fornecedorEurop = new Fornecedor( "Europ");
                Fornecedor fornecedorFacil = new Fornecedor( "Facil");
                Fornecedor fornecedorIke = new Fornecedor( "Ike");


                ColaboradorLogin colaborador1 = new ColaboradorLogin( "Maria Jose Fernandes", "mariajose@localiza.com", "Localiza@123");
                ColaboradorLogin colaborador2 = new ColaboradorLogin( "Eugenio Matar", "eugeniomatar@localiza.com", "Localiza@245");
                ColaboradorLogin colaborador3 = new ColaboradorLogin( "Salin Matar costa", "salinmatar@localiza.com", "Localiza@578");




                FornecedorLogin fornecedor1 = new FornecedorLogin( "Salin Matar", "salinmatar@europ.com", "Europ@157");
                FornecedorLogin fornecedor2= new FornecedorLogin( "Bruno Lazasqui", "brunolazasqui@facil.com", "facil@157");
                FornecedorLogin fornecedor3 = new FornecedorLogin( "Tamires Araujo Souza", "tamires@ike.com", "ike@157");

                Veiculo veiculo1 = new Veiculo( "Renegate","qud5474" ,GrupoDeVeiculo.Gx);
                Veiculo veiculo2 = new Veiculo( "Novo Uno 1.0", "qad2943", GrupoDeVeiculo.C);
                Veiculo veiculo3 = new Veiculo( "Mobi 1.0", "Rfe9f23", GrupoDeVeiculo.B);
                Veiculo veiculo4 = new Veiculo( "Fiorino", "qus3493", GrupoDeVeiculo.P) ;



             

                _context.Fornecedor.AddRange(fornecedorEurop, fornecedorFacil, fornecedorIke);

                _context.ColaboradorLogin.AddRange(colaborador1, colaborador2, colaborador3);

                _context.FornecedorLogin.AddRange(fornecedor1, fornecedor2, fornecedor3);
                _context.Veiculo.AddRange(veiculo1, veiculo2, veiculo3, veiculo4);

                _context.SaveChanges();

            }


        }
    }
}
