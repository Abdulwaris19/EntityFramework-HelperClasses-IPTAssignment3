using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBIT.data.Helpers
{
    public class MedicalRecordHelper
    {
        public void Insert(int mrecord_patient_id,string mrecord_patient_problem,
                           DateTime mrecord_dateofExamination)
        {

            MedicalRecord medcialrecord = new MedicalRecord();
            medcialrecord.mrecord_patient_id = mrecord_patient_id;
            medcialrecord.mrecord_patient_problem = mrecord_patient_problem;
            medcialrecord.mrecord_dateofExamintion = mrecord_dateofExamination;

            var db = new IPTwEntitiesNew();
            db.MedicalRecords.Add(medcialrecord);
            db.SaveChanges();
            db.Dispose();

        }

    }
  }
