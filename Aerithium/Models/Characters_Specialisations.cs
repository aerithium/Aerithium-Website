//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aerithium.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Characters_Specialisations
    {
        public int id { get; set; }
        public int character_id { get; set; }
        public int class_spec_id { get; set; }
        public Nullable<int> item_level { get; set; }
    
        public virtual Characters Characters { get; set; }
        public virtual Classes_Specialisations Classes_Specialisations { get; set; }
    }
}
