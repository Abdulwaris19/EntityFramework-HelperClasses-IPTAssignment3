//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UBIT.server
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int appointment_id { get; set; }
        public int appointment_number { get; set; }
        public int appointment_doctor_id { get; set; }
        public int appointment_patient_id { get; set; }
        public string appointment_type { get; set; }
        public System.DateTime appointment_date { get; set; }
        public string appointment_description { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
