﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class User
    {
        [JsonProperty("id_account")]
        public int id_account { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }
    }
}
