using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Auto_RegisterService
{
    [DataContract]
    public class RegisterDetails
    {
            [DataMember]
        //private string fname;
        //private string lname;
        //private string email;
        //private string phoneNumber;
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpass { get; set; }
        

        public string baaccount { get; set; }

           
            
        
    }
}
