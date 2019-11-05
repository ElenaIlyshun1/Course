using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceDLL.Models;

namespace ServiceDLL.Interfaces
{
    public interface IClinicService
    {
        List<ClinicModels> GetClinics();
        Task<List<ClinicModels>> GetClinicsAsync();
        int CreateClinic(ClinicModels clinic);
    }
}
