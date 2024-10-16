using Newtonsoft.Json;
using System.Security.Principal;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
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
            Account account = JsonConvert.DeserializeObject<Account>(json);
            label1.Text = account.userid_account.ToString();
            label2.Text = account.kontomoney_value.ToString();
            label3.Text = account.useremail;
        }
    }
}
