
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IAutoRegisterCustomer
    {
        
        //public ResponseModel Register(string email, string password, string confirmpass, string ba)
        //{
        //    RegisterDetails register_details = new RegisterDetails();
            

        //    ResponseModel resp = CallRegisterWebAPI.RegisterCustomer(email, password, confirmpass, ba);

        //    if (!resp.status)
        //    {
        //        return new ResponseModel { status = resp.status, message = resp.message };
        //        //return false;
        //    }

        //    return new ResponseModel { status = resp.status, message = resp.message };    
        //    //return true;
        //}

        public ResponseModel Register(string ba)
        {
            RegisterDetails register_details = new RegisterDetails();


            ResponseModel resp = CallRegisterWebAPI.RegisterCustomer(ba);

            if (!resp.status)
            {
                return new ResponseModel { status = resp.status, message = resp.message };
                //return false;
            }

            return new ResponseModel { status = resp.status, message = resp.message };
            //return true;
        }
    }
}
