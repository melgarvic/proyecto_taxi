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
    
    public partial class Responsabilidades
    {
        public Responsabilidades(string placa, int poliza, string aseguradora, DateTime vencimiento, double valor)
        {
            this.placa = placa;
            this.poliza = poliza;
            this.aseguradora = aseguradora;
            this.vencimiento = vencimiento;
            this.valor = valor;
        }

        public Responsabilidades()
        {
        }

        public int id { get; set; }
        public string placa { get; set; }
        public int poliza { get; set; }
        public string aseguradora { get; set; }
        public System.DateTime vencimiento { get; set; }
        public double valor { get; set; }
    
        public virtual Taxis Taxis { get; set; }
    }
}
