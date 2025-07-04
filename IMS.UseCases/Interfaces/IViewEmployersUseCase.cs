﻿using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Interfaces
{
    public interface IViewEmployersUseCase
    {
        Task<List<Employer>> ExecuteAsync();
    }
}
