using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMS.CoreBusiness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Employers
{
    public class ViewEmployersUseCase : IViewEmployersUseCase
    {
        private readonly IEmployerRepository _employerRepository;

        public ViewEmployersUseCase(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public async Task<List<Employer>> ExecuteAsync()
        {
            return await _employerRepository.GetEmployersAsync();
        }
    }
}
