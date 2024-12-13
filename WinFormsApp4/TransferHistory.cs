using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp4
{
    public partial class TransferHistory : Form
    {
        public string hash;
        public TransferHistory()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string myJsonResponse = GetJsonResponse(); // Metoda, która zwraca dane JSON
            Root? myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

            if (myDeserializedClass != null && myDeserializedClass.MyArray != null)
            {
                dataGridView1.DataSource = myDeserializedClass.MyArray;
            }
        }

        private string GetJsonResponse()
        {
            using (var client = new HttpClient())
            {
                string url = "http://localhost/bankAPI/transfer/history";
                var data = new { token = hash };
                HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
                string json = response.Content.ReadAsStringAsync().Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    throw new Exception("Błąd podczas pobierania danych JSON");
                }
            }
        }
    }
}
