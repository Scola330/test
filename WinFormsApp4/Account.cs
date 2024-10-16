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
        [JsonProperty("user.id_account")]
        public required int userid_account { get; set; }

        [JsonProperty("konto.money_value")]
        public required string kontomoney_value { get; set; }

        [JsonProperty("user.email")]
        public required string useremail { get; set; }
    }
}