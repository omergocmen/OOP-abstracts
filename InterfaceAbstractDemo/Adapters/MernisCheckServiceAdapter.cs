using InterfaceAbstractDemo.Abstracts;
using InterfaceAbstractDemo.Entities;
using MernisCheckService;
using System;
using System.Collections.Generic;
using System.Text;
using static MernisCheckService.KPSPublicSoapClient;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisCheckServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfReelPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(long.Parse(customer.NationallyId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
