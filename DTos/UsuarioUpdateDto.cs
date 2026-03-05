using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UsersAPI.Models;

namespace UsersAPI.DTos
{
    public class UsuarioUpdateDto
    {
        [StringLength(100, MinimumLength = 2)]
        public string? Nome { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [DataType(DataType.Date)]
        public DateOnly? DataNascimento { get; set; }
        public StatusUsuario? Status { get; set; }
    }
}