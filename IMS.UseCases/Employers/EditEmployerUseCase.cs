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
    public class EditEmployerUseCase : IEditEmployerUseCase
    {
        private readonly IEmployerRepository _employerRepository;

        public EditEmployerUseCase(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public async Task ExecuteAsync(Employer employer)
        {
            await _employerRepository.UpdateEmployerAsync(employer);
        }
    }
}
