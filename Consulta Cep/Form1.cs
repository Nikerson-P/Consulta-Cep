using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Consulta_Cep
{
    public partial class Form1 : Form
    {
        string site = "http://viacep.com.br/ws/";
        string recebido;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultar_Click(object sender, EventArgs e)
        {
            consultar.Enabled = false;
            if (this.cep.Text != string.Empty || this.cep.Text != null )
            {
                string recebido1 = Consultar(this.cep.Text);
                Cep cepRecebido = JsonConvert.DeserializeObject<Cep>(recebido1);
                MessageBox.Show(cepRecebido.ToString());
                consultar.Enabled = true;
            }
            
        }

        private string Consultar(string textSite)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            wc.DownloadFile(site + textSite + "/json/","cep.json");
            string recebido = "";
            try
            {
                recebido = wc.DownloadString(site + textSite + "/json/");
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return recebido;
        }
    }
}
