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
    
    public partial class Soat
    {
        public int id { get; set; }
        public string numero { get; set; }
        public string placa_taxi { get; set; }
        public System.DateTime expedicion { get; set; }
        public System.DateTime expiracion { get; set; }
        public string valor { get; set; }

        public Soat(string numero, string placa_taxi, DateTime expedicion, DateTime expiracion, string valor)
        {
            this.numero = numero;
            this.placa_taxi = placa_taxi;
            this.expedicion = expedicion;
            this.expiracion = expiracion;
            this.valor = valor;
        }

        public virtual Taxis Taxis { get; set; }
    }
}
