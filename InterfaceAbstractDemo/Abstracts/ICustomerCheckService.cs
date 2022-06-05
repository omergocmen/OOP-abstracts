using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstracts
{
    interface ICustomerCheckService
    {
        public bool CheckIfReelPerson(Customer customer);
    }
}
