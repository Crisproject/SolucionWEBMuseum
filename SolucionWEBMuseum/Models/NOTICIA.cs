//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolucionWEBMuseum.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NOTICIA
    {
        public int id_noticia { get; set; }
        public byte[] imagen_noticia { get; set; }
        public string titulo_noticia { get; set; }
        public string descripcion_noticia { get; set; }
        public System.DateTime fechacreacion_noticia { get; set; }
        public string estado_noticia { get; set; }
        public Nullable<int> visitas { get; set; }
    }
}
