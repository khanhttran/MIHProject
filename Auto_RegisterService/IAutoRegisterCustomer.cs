using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Auto_RegisterService.Model;

namespace Auto_RegisterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAutoRegisterCustomer
    {
        // TODO: Add your service operations here

        [OperationContract]
        //ResponseModel Register(string email, string password, string confirmpass, string ba);

        ResponseModel Register(string ba);
    }


   
    
}
