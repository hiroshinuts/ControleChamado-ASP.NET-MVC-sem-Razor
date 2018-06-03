using ControleChamadoSemRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleChamadoSemRazor.DAO
{
    public class UsuarioDAO
    {
        public void Adiciona(Usuario usuario)
        {
            using (var context = new ChamadoContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public IList<Usuario> Lista()
        {
            using (var context = new ChamadoContext())
            {
                return context.Usuarios.ToList();
            }
        }

        public Usuario Busca(string login, string senha)
        {
            using (var context = new ChamadoContext())
            {
                return context.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }
    }
}