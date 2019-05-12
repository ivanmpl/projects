using System;
using System.Collections.Generic;
using Acme.Data.Entity;
using Acme.Data.Repository;

namespace Acme.Service
{
    public class DepartmentService
    {
        IRepository<Department> departmentRepository;
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository();
        }

        public int Insert(Department obj)
        {
            return departmentRepository.Add(obj);
        }

        public int Delete(int id)
        {
            return departmentRepository.Delete(id);
        }

        public int Update(Department obj)
        {
            return departmentRepository.Update(obj);
        }

        public IEnumerable<Department> GetAll()
        {
            return departmentRepository.GetAll();
        }

        public Department GetById(int id)
        {
            return departmentRepository.GetById(id);
        }
    }

}
