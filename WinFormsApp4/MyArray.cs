using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class History
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("source_usser_id")]
        public string source_usser_id { get; set; }

        [JsonProperty("destination_usser_id")]
        public string destination_usser_id { get; set; }

        [JsonProperty("timestamp")]
        public string timestamp { get; set; }

        [JsonProperty("transfer_amount")]
        public string transfer_amount { get; set; }
    }
}
