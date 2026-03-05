using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersAPI.DTos;
using UsersAPI.Models;

namespace UsersAPI.Services
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> ListarUsuarios();
        Usuario? ObterUsuarioPorId(int id);
        Usuario CriarUsuario(UsuarioCreateDto dto);
        bool AtualizarUsuario(int id, UsuarioUpdateDto dto);
        bool DeletarUsuario(int id);

    }
}