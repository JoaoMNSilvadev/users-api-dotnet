using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersAPI.Data;
using UsersAPI.DTos;
using UsersAPI.Models;

namespace UsersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly AppDbContext _context; 

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        private static UsuarioSaidaDto MapearParaDto(Usuario u)
{
    return new UsuarioSaidaDto
    {
        Id = u.Id,
        Nome = u.Nome,
        Email = u.Email,
        DataNascimento = u.DataNascimento,
        Status = u.Status,
        DataCriacao = u.DataCriacao.ToString("dd/MM/yyyy HH:mm:ss")
    };
}

        [HttpPost]
        public IActionResult CriarUsuario(UsuarioCreateDto dto)
        {
            var usuario = new Usuario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Senha = dto.Senha,
                DataNascimento = dto.DataNascimento,
                Status = dto.Status,
                DataCriacao = DateTime.Now
            };
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizarUsuario(int id, UsuarioUpdateDto dto)
        {
            var usuario = _context.Usuarios.Find(id);

    if (usuario == null)
        return NotFound();

    if (dto.Nome != null)
        usuario.Nome = dto.Nome;

    if (dto.Email != null)
        usuario.Email = dto.Email;

    if (dto.DataNascimento.HasValue)
        usuario.DataNascimento = dto.DataNascimento.Value;

    if (dto.Status.HasValue)
        usuario.Status = dto.Status.Value;

    _context.SaveChanges();

    return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            var usuarioExistente = _context.Usuarios.Find(id);
            if (usuarioExistente == null)
            {
                return NotFound();
            }
            _context.Usuarios.Remove(usuarioExistente);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult ListarUsuarios()
        {
            var usuarios = _context.Usuarios
            .Select(u => MapearParaDto(u))
            .ToList();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult ObterUsuarioPorId(int id)
        {
            var usuario = _context.Usuarios.Find(id);
        
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }
        
    }
}