//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CEA_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AddressStudent
    {
        public int AddressId { get; set; }
        public string AptStreet { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public Nullable<int> StudentId { get; set; }
    
        public virtual Student_Profile Student_Profile { get; set; }
    }
}
