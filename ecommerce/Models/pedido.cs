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
    
    public partial class pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pedido()
        {
            this.pedido_produto = new HashSet<pedido_produto>();
        }
    
        public int id { get; set; }
        public int id_cliente { get; set; }
        public System.DateTime data_cadastro { get; set; }
    
        public virtual cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedido_produto> pedido_produto { get; set; }
    }
}