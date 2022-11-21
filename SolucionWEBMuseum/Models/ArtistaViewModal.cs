using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolucionWEBMuseum.Models;

namespace SolucionWEBMuseum.Models
{
    public class ArtistaViewModal
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string genero { get; set; }
        public Nullable<System.DateTime> fechanacimiento { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fechacreacia { get; set; }
        public string estado { get; set; }

        PruebaMuseoEntities bd = new PruebaMuseoEntities();

        public List<ARTISTA> LeerTodo()
        {
            return this.bd.ARTISTA.ToList();
        }
    }


}