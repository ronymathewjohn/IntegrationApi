using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationApi.Service.Model
{
    public class PatientCsv
    {
        public int patient_id { get; set; }
        public string patient_name { get; set; }
        public string dob { get; set; }
    }
}
