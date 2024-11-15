using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Account
    {
            [JsonProperty("user")]
            public User user { get; set; }

            [JsonProperty("konto")]
            public Konto konto { get; set; }

    }
}