using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IEmployerRepository
    {
        Task AddEmployerAsync(Employer employer);
        Task UpdateEmployerAsync(Employer employer);
        Task<Employer> GetEmployerByIdAsync(int employerId);
        Task<List<Employer>> GetEmployersAsync();
        Task DeleteEmployerAsync(int employerId);
    }
}
