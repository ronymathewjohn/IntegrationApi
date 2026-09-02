using IntegrationApi.Service.Interfaces;
using IntegrationApi.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace IntegrationApi.Service.Services
{
    public class TransformService(IQueueService queueService) : ITransfrom
    {
        public async Task TransformToCsv(Patient patient)
        {
            var header = string.Join(",", new List<string> { "patient_id", "patient_name", "dob" });
            var csvData1 = string.Join(",", new List<string> { patient.PatientId.ToString(), patient.FirstName + " " + patient.LastName, patient.DateOfBirth.ToString() });

            var finalCsv =  string.Join(Environment.NewLine, new List<string> { header, csvData1 });

            await queueService.EnqueueAsync(finalCsv);

        }
    }
}
