//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Broker
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gasto_Inventario
    {
        /// <summary>
        /// Metodo Constructor
        /// </summary>
        /// <param name="idInventario"></param>
        /// <param name="placaTaxi"></param>
        /// <param name="cantidadUsada"></param>
        /// <param name="fecha"></param>
        public Gasto_Inventario(int idInventario, string placaTaxi, int cantidadUsada, System.DateTime fecha)
        {

            this.cant_usada = cantidadUsada;
            this.placaTaxi = placaTaxi;
            this.fecha = fecha;
            this.id_inventario = idInventario;


        }
        public int id { get; set; }
        public int id_inventario { get; set; }
        public string placaTaxi { get; set; }
        public int cant_usada { get; set; }
        public System.DateTime fecha { get; set; }
    
        public virtual Inventario Inventario { get; set; }
        public virtual Taxis Taxis { get; set; }
    }
}