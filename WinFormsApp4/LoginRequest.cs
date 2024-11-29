using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    
    internal class LoginRequest
    {
        public string email { get; set; }
        public string password { get; set; }

        public LoginRequest(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
