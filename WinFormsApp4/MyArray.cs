using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class MyArray
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("source_usser_id")]
        public string source_usser_id { get; set; }

        [JsonPropertyName("destination_usser_id")]
        public string destination_usser_id { get; set; }

        [JsonPropertyName("timestamp")]
        public string timestamp { get; set; }

        [JsonPropertyName("transfer_amount")]
        public string transfer_amount { get; set; }
    }
}
