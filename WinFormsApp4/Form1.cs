using Newtonsoft.Json;
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
            string numerKonta = AcountTextBox.Text;
            HttpClient client = new HttpClient();
            string url = "http://localhost/bankAPI/account/" + numerKonta;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = client.GetAsync(client.BaseAddress).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            testBox.Text = json;
            Account? account = JsonConvert.DeserializeObject<Account>(json);
            if (account != null)
            {
                label1.Text = account.konto?.money_value.ToString() + " " + account.konto?.money_type.ToString();
                label2.Text = account.user?.email.ToString();
                label3.Text = account.user?.id_account.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            login loginForm = new login(this);
            //this to argument do wyœietlania okienek lub do zamykania okienek
            if (loginForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
