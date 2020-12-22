using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBIT.data.Helpers
{
 public class DoctorHelper
    {
        public void Insert(string doctor_name, string doctor_specialist,
          string doctor_mobile, string doctor_email,
           string doctor_address, bool Gender)
        {

            Doctor doctor = new Doctor();
            doctor.doctor_name = doctor_name;
            doctor.doctor_specialist = doctor_specialist;
            doctor.doctor_mobile = doctor_mobile;
            doctor.doctor_email = doctor_email;
            doctor.doctor_address = doctor_address;
            doctor.Gender = Gender;

            var db = new IPTwEntitiesNew();
            db.Doctors.Add(doctor);
            db.SaveChanges();
            db.Dispose();

        }
    }
}
