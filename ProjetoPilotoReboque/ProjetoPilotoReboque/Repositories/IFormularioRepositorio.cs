using ProjetoPilotoReboque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Repositories
{
   public interface IFormularioRepositorio
    {
        Task<IEnumerable<FormularioAcionamento>> ObterTodos();

        Task<FormularioAcionamento> ObterPorId(int id);

        Task Adicionar(FormularioAcionamento formulario);
        Task Editar(FormularioAcionamento formulario);

        Task Excluir(int id);


    }
}
