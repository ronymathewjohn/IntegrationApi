using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationApi.Service.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

    }
}
