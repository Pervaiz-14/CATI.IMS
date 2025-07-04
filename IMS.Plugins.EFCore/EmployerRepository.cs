using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMS.CoreBusiness;
using IMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;

namespace IMS.Plugins.EFCore.Repositories
{
    public class EmployerRepository : IEmployerRepository
    {
        private readonly IMSContext db;

        public EmployerRepository(IMSContext db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public async Task AddEmployerAsync(Employer employer)
        {
            if (db.Employers.AsEnumerable().Any(x => x.EmployerName.Equals(employer.EmployerName, StringComparison.OrdinalIgnoreCase)))
                return;

            db.Employers.Add(employer);
            await db.SaveChangesAsync();
        }

        public async Task UpdateEmployerAsync(Employer employer)
        {
            var existingEmployer = await db.Employers.FindAsync(employer.EmployerId);
            if (existingEmployer != null)
            {
                existingEmployer.EmployerName = employer.EmployerName;
                existingEmployer.EmployerPosition = employer.EmployerPosition;
                existingEmployer.EmployerDepartment = employer.EmployerDepartment;

                await db.SaveChangesAsync();
            }
        }

        public async Task<Employer> GetEmployerByIdAsync(int employerId)
        {
            return await db.Employers.FindAsync(employerId);
        }

        public async Task<List<Employer>> GetEmployersAsync()
        {
            return await db.Employers.ToListAsync();
        }

        public async Task DeleteEmployerAsync(int employerId)
        {
            var employer = await db.Employers.FindAsync(employerId);
            if (employer != null)
            {
                db.Employers.Remove(employer);
                await db.SaveChangesAsync();
            }
        }
    }
}
