﻿using API_Projeto_Livros.Context;
using API_Projeto_Livros.Interface;
using API_Projeto_Livros.Models;

namespace API_Projeto_Livros.Repositories
{
    public class AssinaturaRepository : IAssinaturaRepository
    {
        private LivrosContext _context;

        public AssinaturaRepository(LivrosContext context)
        {
            _context = context;
        }

        public Assinatura? Atualizar(int id, Assinatura assinatura)
        {
            var assinaturaEncontrada = _context.Assinaturas.FirstOrDefault(c => c.AssinaturaId == id);

            if (assinaturaEncontrada == null) return null;

            assinaturaEncontrada.DataInicio = assinatura.DataInicio;
            assinaturaEncontrada.DataFim = assinatura.DataFim;
            assinaturaEncontrada.status = assinatura.status;
            assinaturaEncontrada.UsuarioId = assinatura.UsuarioId;

            _context.SaveChanges();

            return assinaturaEncontrada;
        }

        public void Cadastrar(Assinatura assinatura)
        {
            _context.Assinaturas.Add(assinatura);

            _context.SaveChanges();
        }

        public Assinatura? Deletar(int id)
        {
            var assinatura = _context.Assinaturas.Find(id);

            if (assinatura == null) return null;

            _context.Assinaturas.Remove(assinatura);
            _context.SaveChanges();

            return assinatura;
        }

        public List<Assinatura> ListarTodos()
        {
            return _context.Assinaturas.ToList();
        }

        public Assinatura? ListarPorId(int id)
        {
            return _context.Assinaturas
                             .FirstOrDefault(c => c.AssinaturaId == id);
        }
    }
}
