//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LULU_Model_DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff_User : User
    {
        public string StaffNumber { get; set; }
        public bool IsSysAdmin { get; set; }
    
        public virtual Staff_Login Staff_Login { get; set; }
    }
}