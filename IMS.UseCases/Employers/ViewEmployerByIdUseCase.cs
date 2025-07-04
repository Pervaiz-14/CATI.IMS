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
    public class ViewEmployerByIdUseCase : IViewEmployerByIdUseCase
    {
        private readonly IEmployerRepository _employerRepository;

        public ViewEmployerByIdUseCase(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public async Task<Employer> ExecuteAsync(int employerId)
        {
            return await _employerRepository.GetEmployerByIdAsync(employerId);
        }
    }
}
