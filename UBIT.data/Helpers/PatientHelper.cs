using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBIT.data.Helpers
{
   public class PatientHelper
    {
        public void Insert(string patient_name,
            string patient_mobile, string patient_email,
            string patient_address, bool Gender)
        {

            Patient patient = new Patient();
            patient.patient_name = patient_name;
            patient.patient_mobile = patient_mobile;
            patient.patient_email = patient_email;
            patient.pateint_address = patient_address;
            patient.Gender = Gender;

            var db = new IPTwEntitiesNew();
            db.Patients.Add(patient);
            db.SaveChanges();
            db.Dispose();

        }
    }
}
