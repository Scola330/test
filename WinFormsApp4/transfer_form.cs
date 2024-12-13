using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class transfer_form : Form
    {
        Form1 MainForm;
        public string hash;
        public string id_account;
        public transfer_form(Form1 twoja_stara)
        {
            MainForm = twoja_stara;
            InitializeComponent();
        }

        private void ExitButtonPressed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransferMoneh(object sender, EventArgs e)
        {
            string target_account = TargetTextBox2.Text;
            double amount_input = double.Parse(ilośćNumericUpDown1.Text);
            int amount = (int)Math.Round(amount_input * 100);
            var data = new
            {
                token = hash,
                id_account = id_account,
                target_account = target_account,
                amount = amount
            };
            string url = "http://localhost/bankAPI/transfer/new";
            HttpClient client = new HttpClient();

            HttpResponseMessage responde = client.PostAsJsonAsync(url, data).Result;
            if (responde.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Transfer completed successfully");
            }
            else
            {
                MessageBox.Show("Transfer failed");
            }
        }

        private void OpenTransferHistory(object sender, EventArgs e)
        {
            TransferHistory transferHistoryForm = new TransferHistory();
            transferHistoryForm.Show();
        }
    }
}
