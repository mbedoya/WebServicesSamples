using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServicesSamples.WCF.DataMembers;

namespace WebServicesSamples.WCF
{
    [ServiceContract]
    public interface CustomerServiceContract
    {
        [OperationContract]
        [WebGet (UriTemplate="Books/", ResponseFormat=WebMessageFormat.Json)]
        List<Customer> GetCustomers();
    }
}
