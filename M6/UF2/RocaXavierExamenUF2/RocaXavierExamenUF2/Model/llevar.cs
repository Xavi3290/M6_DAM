//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RocaXavierExamenUF2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class llevar
    {
        public short dorsal { get; set; }
        public short netapa { get; set; }
        public string codigo { get; set; }
    
        public virtual ciclista ciclista { get; set; }
        public virtual etapa etapa { get; set; }
        public virtual maillot maillot { get; set; }
    }
}
