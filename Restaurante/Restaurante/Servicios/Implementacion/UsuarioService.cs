using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Restaurante.Models;
using Restaurante.Servicios.Contrato;

namespace Restaurante.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DbpruebaContext _dbContext;
        public UsuarioService(DbpruebaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> GetUsuario(string correo, string clave)
        {
            Usuario usuario_encontrado = await _dbContext.Usuario.Where(u => u.Correo == correo && u.Clave == clave)
            .FirstOrDefaultAsync();

            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbContext.Usuario.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}
