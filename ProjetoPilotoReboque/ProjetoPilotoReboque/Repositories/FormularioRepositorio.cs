using ProjetoPilotoReboque.Data;
using ProjetoPilotoReboque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Repositories
{
    public class FormularioRepositorio : IFormularioRepositorio
    {

        private readonly PilotoReboqueContext _context;


        public FormularioRepositorio(PilotoReboqueContext context)
        {
            _context = context;
        }
        public void Adicionar(FormularioAcionamento formulario)
        {
            _context.FormularioAcionamento.Add(formulario);
            _context.SaveChanges();

        }

        public void Editar(int id, FormularioAcionamento formulario)
        {
            var findId = ObterPorId(id);

            if (findId.Id == id)
            {
                _context.Update(findId);
                _context.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            var findId = ObterPorId(id);

            _context.FormularioAcionamento.Remove(findId);
            _context.SaveChanges();
        }

        public FormularioAcionamento ObterPorId(int id)
        {
            var findId = _context.FormularioAcionamento.Find(id);
            return findId;

        }

        public IEnumerable<FormularioAcionamento> ObterTodos()
        {

            var obterTodos = _context.FormularioAcionamento.ToList();

            return obterTodos;
        }
    }
}
