using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersAPI.Models;

namespace UsersAPI.DTos
{
    public class UsuarioSaidaDto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public DateOnly DataNascimento { get; set; }
        public StatusUsuario Status { get; set; }
        public string DataCriacao { get; set; } = string.Empty;
    }
}