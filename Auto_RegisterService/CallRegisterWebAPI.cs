using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using Auto_RegisterService.Model;

namespace Auto_RegisterService
{
    public class CallRegisterWebAPI
    {
        static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //public static ResponseModel RegisterCustomer(string email, string password, string conpass, string BAAccount)
        //{
        //    var errorMsg = "";
        //    try
        //    {
        //        //var client = new RestClient("http://10.0.70.60:8008");
        //        var client = new RestClient("http://localhost:50457");
        //        var request = new RestRequest("api/Account/Register", Method.POST);
        //        request.AddParameter("Email", email);
        //        request.AddParameter("Password", password);
        //        request.AddParameter("ConfirmPassword", conpass);
        //        request.AddParameter("BAAccount", BAAccount);

        //        IRestResponse<ResponseModel> response = client.Execute<ResponseModel>(request);

        //        if (!response.Data.status)
        //        {
        //            logger.Error("Error: Register() - call BA Api to RegisterAccount. " + response.Data.message);
        //            errorMsg += "Error: Register() - call BA Api to RegisterAccount. " + response.Data.message;
        //        }
        //        return new ResponseModel { status = response.Data.status, message = response.Data.message};

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error("Exception Error: Register() - call BA Api to RegisterAccount. ", ex);

        //        throw new Exception("There was an error while creating your account. Please contact our customer service for assistance !. " + ex.Message.ToString() + "  999: " + errorMsg);
        //    }

        //}

        public static ResponseModel RegisterCustomer(string BAAccount)
        {
            var errorMsg = "";
            try
            {
                //var client = new RestClient("http://10.0.70.60:8008");
                var client = new RestClient("http://10.0.70.60:8090");
                var request = new RestRequest("api/Account/AutoRegister", Method.POST);
                
                request.AddParameter("BAAccount", BAAccount);

                IRestResponse<ResponseModel> response = client.Execute<ResponseModel>(request);

                if (!response.Data.status)
                {
                    logger.Error("Error: Register() - call BA Api to RegisterAccount. " + response.Data.message);
                    errorMsg += "Error: Register() - call BA Api to RegisterAccount. " + response.Data.message;
                }
                return new ResponseModel { status = response.Data.status, message = response.Data.message };

            }
            catch (Exception ex)
            {
                logger.Error("Exception Error: Register() - call BA Api to RegisterAccount. ", ex);

                throw new Exception("There was an error while creating your account. Please contact our customer service for assistance !. " + ex.Message.ToString() + "  999: " + errorMsg);
            }

        }
    }
}