using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }

        public DateOnly DataNascimento { get; set; }

        public StatusUsuario Status { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}