//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonalFile
    {
        public int codeStudent { get; set; }
        public string medicalBackground { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual Student Student1 { get; set; }
    }
}
