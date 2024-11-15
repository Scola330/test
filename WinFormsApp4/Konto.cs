using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Konto
    {
        [JsonProperty("money_value")]
        public double money_value { get; set; }

        [JsonProperty("money_type")]
        public string money_type { get; set; }
    }
}
