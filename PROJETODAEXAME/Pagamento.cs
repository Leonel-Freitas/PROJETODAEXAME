//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJETODAEXAME
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagamento
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public Nullable<int> CodigoId { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual MetodoPagamento MetodoPagamento { get; set; }
        public virtual Codigo Codigo { get; set; }
    }
}
