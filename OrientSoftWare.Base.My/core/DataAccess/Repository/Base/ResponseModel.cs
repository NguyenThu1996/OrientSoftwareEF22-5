using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientSoftWareBaseMy.core.DataAccess.Repository.Base
{
    public class ResponseModel
    {
        public System.Net.HttpStatusCode StatusCode { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
    }
}
}
