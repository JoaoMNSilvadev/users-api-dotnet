using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersAPI.Models;

namespace UsersAPI.DTos
{
    public class UsuarioUpdateDto
    {
        public string? Nome { get; set; }
    public string? Email { get; set; }
    public DateOnly? DataNascimento { get; set; }
    public StatusUsuario? Status { get; set; }
    }
}