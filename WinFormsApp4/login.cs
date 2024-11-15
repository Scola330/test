using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class login : Form
    {
        Form1 MainForm;
        public login(Form1 twoj_stary)
        {
            MainForm = twoj_stary;
            InitializeComponent();
        }

        private void LoginButtonPressed(object sender, EventArgs e)
        {
            string email = EmailRichTextBox1.Text;
            string password = HasloRichTextBox2.Text;
            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/login/";
            var data = new { email = email, password = password };
            HttpResponseMessage response = 
                client.PostAsJsonAsync(url, data).Result;
            string json = response.Content.ReadAsStringAsync().Result ?? "";
            hash_data hash = JsonConvert.DeserializeObject<hash_data>(json);
            MainForm.hash = hash.token;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void WyjdzButtonPressed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
