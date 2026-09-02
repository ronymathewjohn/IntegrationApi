using IntegrationApi.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationApi.Service.Interfaces
{
    public interface ITransfrom
    {
        Task TransformToCsv(Patient patient);
    }
}
