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
using System.Threading;

namespace Consulta_Cep
{
    public partial class Form1 : Form
    {
        string site = "http://viacep.com.br/ws/";
        
        public Form1()
        {
            InitializeComponent();
            logra.Enabled = false;
            comple.Enabled = false;
            local.Enabled = false;
            uf.Enabled = false;
            ibge.Enabled = false;
            gia.Enabled = false;
            ddd.Enabled = false;
            siafi.Enabled = false;
            bairro.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void consultar_Click(object sender, EventArgs e)
        {
            consultar.Enabled = false;
            if (this.cep.Text != string.Empty || this.cep.Text != null )
            {
                string recebido1 = await Task.Run(() => Consultar(this.cep.Text));

                Cep cepRecebido = JsonConvert.DeserializeObject<Cep>(recebido1);

                if (cepRecebido.erro == "true")
                {
                    MessageBox.Show("Erro : Cep não encontrado\nVerificar o cep");
                    consultar.Enabled = true;
                }

                else
                {
                    
                    //MessageBox.Show(cepRecebido.ToString());
                    consultar.Enabled = true;

                    logra.Text = cepRecebido.logradouro;
                    comple.Text = cepRecebido.complemento;
                    local.Text = cepRecebido.localidade;
                    uf.Text = cepRecebido.uf;
                    ibge.Text = cepRecebido.ibge;
                    gia.Text = cepRecebido.gia;
                    ddd.Text = cepRecebido.ddd;
                    siafi.Text = cepRecebido.siafi;
                    bairro.Text = cepRecebido.bairro;
                    
                   logra.Enabled = true;
                    comple.Enabled = true;
                    local.Enabled = true;
                    uf.Enabled = true;
                    ibge.Enabled = true;
                    gia.Enabled = true;
                    ddd.Enabled = true;
                    siafi.Enabled = true;
                    bairro.Enabled = true;
                   
                }
            }
            
        }

        private string Consultar(string textSite)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            wc.DownloadFile(site + textSite + "/json/","cep.json");
            Thread.Sleep(5000);

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
