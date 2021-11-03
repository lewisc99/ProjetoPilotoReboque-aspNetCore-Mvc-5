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

        private  readonly PilotoReboqueContext _context;

       public EnviarDados(PilotoReboqueContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            if(_context.ColaboradorLogin.Any() || _context.Fornecedor.Any() || _context.Veiculo.Any())
            {
                return;
            }
            else
            {
                Fornecedor fornecedorEurop = new Fornecedor(1, "Europ");
                Fornecedor fornecedorFacil = new Fornecedor(2, "Facil");
                Fornecedor fornecedorIke = new Fornecedor(3, "Ike");


                ColaboradorLogin colaborador1 = new ColaboradorLogin(1, "Maria Jose Fernandes", "mariajose@localiza.com", "Localiza@123");
                ColaboradorLogin colaborador2 = new ColaboradorLogin(2, "Eugenio Matar", "eugeniomatar@localiza.com", "Localiza@245");
                ColaboradorLogin colaborador3 = new ColaboradorLogin(3, "Salin Matar costa", "salinmatar@localiza.com", "Localiza@578");




                FornecedorLogin fornecedor1 = new FornecedorLogin(1, "Salin Matar", "salinmatar@europ.com", "Europ@157");
                FornecedorLogin fornecedor2= new FornecedorLogin(1, "Bruno Lazasqui", "brunolazasqui@facil.com", "facil@157");
                FornecedorLogin fornecedor3 = new FornecedorLogin(1, "Tamires Araujo Souza", "tamires@ike.com", "ike@157");

                Veiculo veiculo1 = new Veiculo(1, "Renegate","qud5474" ,GrupoDeVeiculo.Gx);
                Veiculo veiculo2 = new Veiculo(2, "Novo Uno 1.0", "qad2943", GrupoDeVeiculo.C);
                Veiculo veiculo3 = new Veiculo(3, "Mobi 1.0", "Rfe9f23", GrupoDeVeiculo.B);
                Veiculo veiculo4 = new Veiculo(4, "Fiorino", "qus3493", GrupoDeVeiculo.P) ;



                _context.Veiculo.AddRange(veiculo1, veiculo2, veiculo3, veiculo4);

                _context.Fornecedor.AddRange(fornecedorEurop, fornecedorFacil, fornecedorIke);

                _context.ColaboradorLogin.AddRange(colaborador1, colaborador2, colaborador3);

                _context.FornecedorLogin.AddRange(fornecedor1, fornecedor2, fornecedor3);


                _context.SaveChanges();

            }


        }
    }
}
