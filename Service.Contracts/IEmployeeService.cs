﻿using Entities.Models;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployees(Guid companyId, bool trackChanges);
        Task<EmployeeDto> GetEmployee(Guid companyId, Guid id, bool trackChanges);
        Task<EmployeeDto> CreateEmployeeForCompany(Guid companyId, EmployeeForCreationDto
            employeeForCreation, bool trackChanges);
        Task DeleteEmployeeForCompany(Guid companyId, Guid id, bool trackChanges);
        Task UpdateEmployeeForCompany(Guid companyId, Guid id, 
            EmployeeForUpdateDto employeeForUpdate, bool compTrackChanges, bool empTrackChanges);
        Task<(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity)> GetEmployeeForPatch(Guid companyId, Guid id, 
            bool compTrackChanges, bool empTrackChanges);
        Task SaveChangesForPatch(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity);

    }
}
