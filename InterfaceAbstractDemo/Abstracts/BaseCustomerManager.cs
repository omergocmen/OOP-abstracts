using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstracts
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void saveCustomer(Customer customer)
        {
            Console.WriteLine("Save to DB successfully");
        }
    }
}
