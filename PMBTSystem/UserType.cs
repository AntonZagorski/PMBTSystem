//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMBTSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserType
    {
        public UserType()
        {
            this.Logins = new HashSet<Login>();
        }
    
        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }
    
        public virtual ICollection<Login> Logins { get; set; }
    }
}