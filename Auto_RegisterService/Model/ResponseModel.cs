using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Auto_RegisterService.Model
{
    [DataContract]
    public class ResponseModel
    {
        [DataMember]
        public bool status { get; set; }

        [DataMember]
        public string message { get; set; }
    }
}
