using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBIT.data.Helpers;

namespace UBIT.Data.Test
{
    public class Program
    {
        public static void Main()
        {
            PatientHelper patient_helper = new PatientHelper();
            DoctorHelper doctor_helper = new DoctorHelper();
            AppointmentHelper appointment_helper = new AppointmentHelper();
            MedicalRecordHelper medical_Record_helper = new MedicalRecordHelper();
            patient_helper.Insert("Waris1", "03122570600", "Waris@9gmail.com", "house no 12 North Nazimabad", true);
            doctor_helper.Insert("Haris2","BDS","03122570600","Haris@9gmail.com","house no 12 North Nazimabad",true);
            appointment_helper.Insert(5,"Urgent",1,1,"Gum Pain",Convert.ToDateTime("2020-12-22"));
            medical_Record_helper.Insert(2, "Teeth Pain", Convert.ToDateTime("22/Dec/2020"));
        }
        
    }
}
