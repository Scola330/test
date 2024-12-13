using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Root
    {
        [JsonPropertyName("MyArray")]
        public List<MyArray> MyArray { get; set; }
    }
}
