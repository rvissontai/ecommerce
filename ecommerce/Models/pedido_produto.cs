//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecommerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pedido_produto
    {
        public int id { get; set; }
        public int id_pedido { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }
        public decimal preco { get; set; }
    
        public virtual pedido pedido { get; set; }
        public virtual produto produto { get; set; }
    }
}