using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersAPI.Data;
using UsersAPI.DTos;
using UsersAPI.Models;

namespace UsersAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Usuario> ListarUsuarios()
        {
            return _context.Usuarios.ToList();
        }
        public Usuario? ObterUsuarioPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }
        public Usuario CriarUsuario(UsuarioCreateDto dto)
        {
            var usuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Senha = dto.Senha,
                DataNascimento = dto.DataNascimento,
                Status = dto.Status,
                DataCriacao = DateTime.UtcNow
            };

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public bool AtualizarUsuario(int id, UsuarioUpdateDto dto)
    {
        var usuario = _context.Usuarios.Find(id);

        if (usuario == null)
            return false;

        if (dto.Nome != null)
            usuario.Nome = dto.Nome;

        if (dto.Email != null)
            usuario.Email = dto.Email;

        if (dto.DataNascimento.HasValue)
            usuario.DataNascimento = dto.DataNascimento.Value;

        if (dto.Status.HasValue)
            usuario.Status = dto.Status.Value;

        _context.SaveChanges();
        return true;
    }
    
        public bool DeletarUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
                return false;

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return true;
        }
    }
}