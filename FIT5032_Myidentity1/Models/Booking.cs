//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FIT5032_Myidentity1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int Bookingid { get; set; }
        public string Description { get; set; }
        public System.DateTime BookingDate { get; set; }
        public string AspNetUsersId { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}