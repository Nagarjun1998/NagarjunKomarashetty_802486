using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticateService.Models
{
    public class Token
    {
        public string message { get; set; }
        public string token { get; set; }

        public string username { get; set; }
        public string active { get; set; }

        public string useid { get; set; }
    }
}
