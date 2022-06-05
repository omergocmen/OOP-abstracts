using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstracts
{
    public interface ICustomerService
    {
        public void saveCustomer(Customer customer);
    }
}
