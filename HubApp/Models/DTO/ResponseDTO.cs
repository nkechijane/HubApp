using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HubApp.Models.DTO
{
    public class ResponseDTO
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public Datum[] Data { get; set; }
    }

    public class Datum
    {
        public string Name { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public string Tags { get; set; }
        public object Image { get; set; }
    }


}
