using ControleChamadoSemRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleChamadoSemRazor.DAO
{
    public class ChamadoDAO
    {
        public void Adiciona(Chamado chamado)
        {
            using(var context = new ChamadoContext())
            {
                context.Chamados.Add(chamado);
                context.SaveChanges();
            }
        }

        public IList<Chamado> Lista()
        {
            using(var context = new ChamadoContext())
            {                
                return context.Chamados.Include("Usuario").ToList();
            }
        }

        public Chamado BuscaPorId(int id)
        {
            using(var context = new ChamadoContext())
            {
                return context.Chamados.Find(id);
            }
        }


        public void Atualiza(Chamado chamado)
        {
            using (var context = new ChamadoContext())
            {
                context.Entry(chamado).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
        
            using (var context = new ChamadoContext())
            {
                Chamado chamado = context.Chamados.Find(id);
                context.Chamados.Remove(chamado);
                context.SaveChanges();
            }
        }
    }
}