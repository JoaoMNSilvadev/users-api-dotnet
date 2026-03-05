using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UsersAPI.Models;

namespace UsersAPI.DTos
{
    public class UsuarioCreateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public required string Nome { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 8)]
        public required string Senha { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public required DateOnly DataNascimento { get; set; }
        [Required]
        public StatusUsuario Status { get; set; }
    } 
}