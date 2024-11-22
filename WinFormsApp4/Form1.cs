using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security.Principal;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public string hash;
        public Form1()
        {
            InitializeComponent();
        }


        private void NumerKontaLabel_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/account/details";
            var data = new { token = hash };
            HttpResponseMessage response = client.PostAsJsonAsync(url, data).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            testBox.Text = json;
            testBox.Text = hash;
            Account? account = JsonConvert.DeserializeObject<Account>(json);
            if (account != null)
            {
                double? money_value = account.konto?.money_value / 100;
                amountTextBox.Text = money_value + " " + account.konto?.money_type.ToString();
                EmailTextbox.Text = account.user?.email.ToString();
                numberTextbox.Text = account.user?.id_account.ToString();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            login loginForm = new login(this);
            //this to argument do wyœietlania okienek lub do zamykania okienek
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
                testBox.Text = hash;
            }
            else
            {
                Application.Exit();
            }
        }

        private void transfeerButton(object sender, EventArgs e)
        {
            transfer_form transfer = new transfer_form(this);
            //this to argument do wyœietlania okienek lub do zamykania okienek
            if (transfer.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
                testBox.Text = hash;
            }

        }

        private void testBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
