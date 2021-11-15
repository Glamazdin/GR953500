using GR953500.Models;
using System;
using System.Collections.Generic;

namespace GR953500.Contracts
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetEmployee(Guid id);
        void CreateEmployee(Employee employee);
    }
}
