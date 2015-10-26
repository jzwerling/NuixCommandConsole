using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuix.Response
{
    class Authentication
    {
        public string username { get; set; }
        public string authToken { get; set; }
        public string licenceDescription { get; set; }

        public string ToString()
        {
            return "[username=" + username + ",licenceDescription=" + licenceDescription + ",authToken=" + authToken + "]";
        }
    }
}
