using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMS.UseCases.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Employers
{
    public class DeleteEmployerUseCase : IDeleteEmployerUseCase
    {
        private readonly IEmployerRepository _employerRepository;

        public DeleteEmployerUseCase(IEmployerRepository employerRepository)
        {
            _employerRepository = employerRepository;
        }

        public async Task ExecuteAsync(int employerId)
        {
            await _employerRepository.DeleteEmployerAsync(employerId);
        }
    }
}
