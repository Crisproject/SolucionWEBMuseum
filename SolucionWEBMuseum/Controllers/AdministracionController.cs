using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolucionWEBMuseum.Models;

namespace SolucionWEBMuseum.Controllers
{
    public class AdministracionController : Controller
    {
        // GET: Administracion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListarArtistas()
        {
            ArtistaViewModal artistas = new ArtistaViewModal();
            return View(artistas.LeerTodo());
        }
        public ActionResult NuevoArtista()
        {
            ArtistaViewModal artistas = new ArtistaViewModal();
            return View(artistas.LeerTodo());
        }
    }
}