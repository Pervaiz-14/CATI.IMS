using System.Collections.Generic;
using System.Threading.Tasks;
using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases
{
    public class EmployerService
    {
        private readonly IEmployerRepository _employerRepository;

        public EmployerService(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public async Task<List<Employer>> GetEmployersAsync()
        {
            return await _employerRepository.GetEmployersAsync();
        }

        public async Task<Employer> GetEmployerByIdAsync(int employerId)
        {
            return await _employerRepository.GetEmployerByIdAsync(employerId);
        }

        public async Task AddEmployerAsync(Employer employer)
        {
            await _employerRepository.AddEmployerAsync(employer);
        }

        public async Task EditEmployerAsync(Employer employer)
        {
            await _employerRepository.UpdateEmployerAsync(employer);
        }

        public async Task DeleteEmployerAsync(int employerId)
        {
            await _employerRepository.DeleteEmployerAsync(employerId);
        }
    }
}
