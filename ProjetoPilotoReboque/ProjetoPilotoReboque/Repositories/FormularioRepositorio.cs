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

        public void Editar(FormularioAcionamento formulario)
        {


            bool hasAny =  _context.FormularioAcionamento.Any(x => x.Id == formulario.Id);

            if (!hasAny)
            {
                return;
            }
            // var find = _context.Person.FirstOrDefault(x => x.Id == person.Id);

            _context.Update(formulario);
            _context.SaveChangesAsync();
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
