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
    
    public partial class SeguridadSocial
    {
        public int id { get; set; }
        public long id_conductor { get; set; }
        public System.DateTime pago_anterior { get; set; }
        public System.DateTime pago_siguiente { get; set; }
        public double valor { get; set; }

        public SeguridadSocial(long id_conductor, DateTime pago_anterior, DateTime pago_siguiente, double valor)
        {
            this.id_conductor = id_conductor;
            this.pago_anterior = pago_anterior;
            this.pago_siguiente = pago_siguiente;
            this.valor = valor;
        }

        public virtual Conductor Conductor { get; set; }
    }
}
