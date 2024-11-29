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

        private async void LoginButtonPressed(object sender, EventArgs e)
        {
            string email = EmailRichTextBox1.Text;
            string password = HasloRichTextBox2.Text;
            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/login/";
            LoginRequest data = new LoginRequest(email, password);
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(url, data);
                string json = await response.Content.ReadAsStringAsync();
                hash_data hash = JsonConvert.DeserializeObject<hash_data>(json);
                MainForm.hash = hash.token;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("The request was canceled. Please try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void WyjdzButtonPressed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmailRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
