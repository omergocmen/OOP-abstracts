﻿using InterfaceAbstractDemo.Abstracts;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concretes
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfReelPerson(Customer customer)
        {
            return true;
        }
    }
}
