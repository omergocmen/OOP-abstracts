using InterfaceAbstractDemo.Abstracts;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concretes
{
    class StarBucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarBucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void saveCustomer(Customer customer)
        {
            if (_customerCheckService.CheckIfReelPerson(customer))
            {
                base.saveCustomer(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
