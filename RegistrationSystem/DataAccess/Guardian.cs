//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationSystem.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Guardian
    {
        public int GurdianID { get; set; }
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
