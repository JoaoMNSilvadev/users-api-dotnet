using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsersAPI.Data;
using UsersAPI.DTos;
using UsersAPI.Models;
using UsersAPI.Services;

namespace UsersAPI.Controllers
{
   [ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _service;

    public UsuarioController(IUsuarioService service)
    {
        _service = service;
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
    var usuario = _service.CriarUsuario(dto);

    return CreatedAtAction(
        nameof(ObterUsuarioPorId),
        new { id = usuario.Id },
        usuario
    );
}
       [HttpPatch("{id}")]
public IActionResult AtualizarUsuario(int id, UsuarioUpdateDto dto)
{
    var atualizado = _service.AtualizarUsuario(id, dto);

    if (!atualizado)
        return NotFound();

    return NoContent();
}

        [HttpDelete("{id}")]
        public IActionResult DeletarUsuario(int id)
        {
            var deletado = _service.DeletarUsuario(id);

            if (!deletado)
                return NotFound();

            return NoContent();
        }

        

     [HttpGet]
public IActionResult ListarUsuarios()
{
    var usuarios = _service.ListarUsuarios();
    return Ok(usuarios.Select(MapearParaDto).ToList());
}

        [HttpGet("{id}")]
        public IActionResult ObterUsuarioPorId(int id)
        {
            var usuario = _service.ObterUsuarioPorId(id);
        
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(MapearParaDto(usuario));
        }
        
    }
}