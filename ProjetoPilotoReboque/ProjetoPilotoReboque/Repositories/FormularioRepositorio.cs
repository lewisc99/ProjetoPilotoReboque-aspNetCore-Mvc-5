using Microsoft.EntityFrameworkCore;
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
        public async  Task Adicionar(FormularioAcionamento formulario)
        {
            await _context.FormularioAcionamento.AddAsync(formulario);
          await  _context.SaveChangesAsync();

        }

        public async Task Editar(FormularioAcionamento formulario)
        {


            bool hasAny =  _context.FormularioAcionamento.Any(x => x.Id == formulario.Id);

            if (!hasAny)
            {
                return;
            }
            // var find = _context.Person.FirstOrDefault(x => x.Id == person.Id);

           _context.Update(formulario);
          await  _context.SaveChangesAsync();
        }

        public async Task Excluir(int id)
        {
            var findId = await ObterPorId(id);

            _context.FormularioAcionamento.Remove(findId);
            await _context.SaveChangesAsync();
        }

        public async Task<FormularioAcionamento> ObterPorId(int id)
        {
            var findId = await _context.FormularioAcionamento.FindAsync(id);
            return findId;

        }

        public async Task<IEnumerable<FormularioAcionamento>> ObterTodos()
        {

            var obterTodos = await _context.FormularioAcionamento.ToListAsync();

            return  obterTodos;
        }
    }
}
