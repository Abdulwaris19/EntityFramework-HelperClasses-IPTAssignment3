using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using UBIT.data.Helpers;


namespace UBIT.server
{
    /// <summary>
    /// Summary description for WebService2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    [ScriptService]
    public class WebService2 : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]

        public string ReturnSubjects()
        {
            string subjectsStr = HttpContext.Current.Request["request"];
            SubjectsData[] subjects = JsonConvert.DeserializeObject<SubjectsData[]>(subjectsStr);
            SubjectsData MinimumMarks = subjects.First(x => x.subjectMarks == subjects.Min(z => z.subjectMarks));
            SubjectsData MaximumMarks = subjects.First(x => x.subjectMarks == subjects.Max(z => z.subjectMarks));
            decimal noOfSubject = subjects.Count();
            decimal totalMarks = 100 * noOfSubject;
            decimal ObtainedMarks = subjects.Sum(x => x.subjectMarks);
            decimal percentage = (ObtainedMarks / totalMarks) * 100;
            ReturnData data = new ReturnData()
            {
                MinimumMarks = MinimumMarks,
                MaximumMarks = MaximumMarks,
                percentage = percentage

            };
            return JsonConvert.SerializeObject(data);
        }



        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        public class SubjectsData
        {
            public string subjectName { get; set; }
            public int subjectMarks { get; set; }

        }
        public class ReturnData
        {
            public SubjectsData MinimumMarks { get; set; }
            public SubjectsData MaximumMarks { get; set; }
            public decimal percentage { get; set; }
        }
        public static PatientHelper patient_helper = new PatientHelper();

        [WebMethod]

        [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
        public void AddPatients()
        {
            
            string patientStr = HttpContext.Current.Request["request"];
            var patients = JObject.Parse(patientStr);
            string name = Convert.ToString(patients["0"]);
            string phoneNo = Convert.ToString(patients["1"]);
            string email = Convert.ToString(patients["3"]);
            string address = Convert.ToString(patients["4"]);
            patient_helper.Insert(name, phoneNo, email,address, true);
        }
    }
}
