//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Asp_Final
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        public decimal ID_de_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Fecha_de_nacimiento { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public Nullable<decimal> ID_De_Cargo { get; set; }
    
        public virtual Cargos Cargos { get; set; }
    }
}