using Microsoft.EntityFrameworkCore;
using Restaurante.Models;


namespace Restaurante.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string correo, string clave);

        Task<Usuario> SaveUsuario(Usuario modelo);

    }
}
