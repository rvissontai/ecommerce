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
    
    public partial class banner_arquivos
    {
        public int id { get; set; }
        public int id_banner { get; set; }
        public string imagem { get; set; }
        public string url { get; set; }
        public bool ativo { get; set; }
    
        public virtual banner banner { get; set; }
    }
}