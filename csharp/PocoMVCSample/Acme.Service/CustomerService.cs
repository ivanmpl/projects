using System;
using System.Collections.Generic;
using Acme.Data.Entity;
using Acme.Data.Repository;

namespace Acme.Service
{
    public class CustomerService
    {
        IRepository<Customer> customerRepository;
        public CustomerService()
        {
            customerRepository = new CustomerRepository();
        }

        public int Insert(Customer obj)
        {
            return customerRepository.Add(obj);
        }

        public int Delete(int id)
        {
            return customerRepository.Delete(id);
        }

        public int Update(Customer obj)
        {
            return customerRepository.Update(obj);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public Customer GetById(int id)
        {
            return customerRepository.GetById(id);
        }
    }

}
