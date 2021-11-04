using ProjetoPilotoReboque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Repositories
{
   public interface IFormularioRepositorio
    {
        IEnumerable<FormularioAcionamento> ObterTodos();

        FormularioAcionamento ObterPorId(int id);

        void Adicionar(FormularioAcionamento formulario);
        void Editar(int id,FormularioAcionamento formulario);

        void Excluir(int id);


    }
}
