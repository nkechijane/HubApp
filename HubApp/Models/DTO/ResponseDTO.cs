using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubApp.Models.DTO
{
    public class ResponseDTO
    {
        public int code { get; set; }
        public string status { get; set; }
        public string message { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string name { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public string website { get; set; }
        public string tags { get; set; }
        public object image { get; set; }
    }


}
