using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBIT.data.Helpers
{
    public class AppointmentHelper
    {
        public void Insert(int appointment_number, string appointment_type,
           int appointment_doctor_id, int appointment_patient_id, string appointment_description,DateTime appointment_date)
        {

            Appointment appointment = new Appointment();
            appointment.appointment_number = appointment_number;
            appointment.appointment_type = appointment_type;
            appointment.appointment_doctor_id = appointment_doctor_id;
            appointment.appointment_patient_id = appointment_patient_id;
            appointment.appointment_description = appointment_description;
            appointment.appointment_date = appointment_date;

            var db = new IPTwEntitiesNew();
            db.Appointments.Add(appointment);
            db.SaveChanges();
            db.Dispose();

        }
    }
}
