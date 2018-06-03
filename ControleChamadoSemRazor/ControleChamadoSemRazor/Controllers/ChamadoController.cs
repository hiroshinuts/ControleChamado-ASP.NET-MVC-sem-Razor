using ControleChamadoSemRazor.DAO;
using ControleChamadoSemRazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleChamadoSemRazor.Controllers
{
    public class ChamadoController : Controller
    {
        // GET: Chamado
        public ActionResult Index()
        {
            ChamadoDAO dao = new ChamadoDAO();
            Usuario usuario = new Usuario();
            
            IList<Chamado> chamados = dao.Lista();
                       
            
            ViewBag.Chamados = chamados;            

            return View();
        }

        public ActionResult Form()
        {
            UsuarioDAO dao = new UsuarioDAO();
            IList<Usuario> usuarios = dao.Lista();
            ViewBag.Usuarios = usuarios;
            return View();
        }

        public ActionResult Adiciona(Chamado chamado)
        {
            ChamadoDAO dao = new ChamadoDAO();
            dao.Adiciona(chamado);

            return RedirectToAction("Index");
        }
    }
}