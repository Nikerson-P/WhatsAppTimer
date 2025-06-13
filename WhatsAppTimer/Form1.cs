using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using static System.Windows.Forms.LinkLabel;



namespace WhatsAppTimer
{
    public partial class Form1 : Form
    {
        IWebDriver driver ;
        string grupo ;
        List<string> links = new List<string>();
        int contador = 0;
        int timer;
        public Form1()
        {
            InitializeComponent();
            radioSegundos.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
        private void Conexao(object sender,EventArgs e)
        {
            btnCon.Enabled = false;
            try
            {
                driver = new EdgeDriver();
                driver.Navigate().GoToUrl("https://web.whatsapp.com");
                Console.WriteLine("Escaneie o QR Code e pressione Enter...");
                Console.ReadLine();

                lStatus.Text = "Conectado";
            }
            catch(Exception ex)
            {
                lStatus.Text = "Não conectado";
                Console.WriteLine(ex.ToString());
            }
            btnCon.Enabled = true;
            
        }
        private void Busca(object sender, EventArgs e)
        {
            grupo = verifica(txtNomeGrupo.Text) ? txtNomeGrupo.Text: null ;
            if (grupo != null)
            {
                try
                {
                    var searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true' and @data-tab='3']"));
                    searchBox.Click();
                    searchBox.SendKeys(grupo);
                    Thread.Sleep(2000);
                    searchBox.SendKeys(OpenQA.Selenium.Keys.Enter);
                    lGrupo.Text = "Encontrado";
                }
                catch (Exception ex)
                {
                    lGrupo.Text = "Não encontrado";

                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Nome do grupo Invalido");
            }
            
        }

        private void Envio(object sender, EventArgs e)
        {
           
                try
                {
                    // Envia a mensagem
                    if (contador <= links.Count) {
                        var campoMensagem = driver.FindElement(By.XPath("//div[@role='textbox' and @data-tab='10']"));
                        campoMensagem.SendKeys(links[contador]);
                        Thread.Sleep(30000);
                        campoMensagem.SendKeys(OpenQA.Selenium.Keys.Enter);
                    }
                } catch (Exception ex)
                {
                    lEnvio.Text = "Não enviado";

                    Console.WriteLine(ex.ToString());
               }
            
          
            
        }

        private bool verifica(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            if(text.Length > 5)
            {
                return true;
            }
            return false;
           
        }


       

        private void Timer(object sender ,EventArgs e)
        {
            timer1.Interval = timer;

         
            if (timer > 0)
            {

                if (timer1.Enabled)
                {
                    timer1.Stop();
                    
                }
                else
                {
                    timer1.Start();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Envio(this, EventArgs.Empty);
            contador++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (driver != null)
            {
                driver.Close();
            }

            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            links.Add(txtLink.Text);
            richLinks.Text += txtLink.Text + "\n";
            lQtLinks.Text = txtLink.Text;
            MessageBox.Show("Total de Links adicionados"+links.Count);
        }

        private void btnSetTimer_Click(object sender, EventArgs e)
        {
            setTimer(this, EventArgs.Empty);
            lIntervalo.Text = txtIntervalo.Text;

        }

        private void procurarArquivo(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Selecione o Arquivo";
            fileDialog.Filter = "Arquivos de texto (*.txt) |*.txt|Arquivos de CSV (*.csv)|*.csv|Todos os Arquivos (*.*)|*.* ";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminho = fileDialog.FileName;
                string extensao = Path.GetExtension(caminho);
                if (extensao == ".txt")
                {
                     string conteudo = File.ReadAllText(caminho);

                     string[] conteudoPar = conteudo.Split(';');

                     foreach (string par in conteudoPar)
                      {
                         links.Add(par);
                         richLinks.Text += par + "\n";
                    }
                    lQtLinks.Text = links.Count.ToString();
                    MessageBox.Show("Conteudo:" + conteudoPar.Length + "Link(s) adicionado(s)");
                    
                }
                if(extensao == ".csv")
                {

                        StreamReader stream = new StreamReader(caminho);
                    CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = false
                    };
                    CsvReader reader = new CsvReader(stream, config);

                    reader.Read();
                        var produtos = reader.GetRecords<classeShoppe>();


                        foreach (var p in produtos)
                        {
                            links.Add(p.OfferLink);
                            richLinks.Text += p.OfferLink + "\n";
                        }
                    lQtLinks.Text = links.Count.ToString();

                    MessageBox.Show("Link(s) adicionado(s)");
                }
                else
                {
                    MessageBox.Show("Conteudo:desconhecido");
                }
            }


        }


        private void setTimer(object sender,EventArgs e)
        {
            if (radioSegundos.Enabled)
            {
                timer = Convert.ToInt32(txtIntervalo.Text) * 1000;
            }
            if (radioMinutos.Enabled)
            {
                timer = Convert.ToInt32(txtIntervalo.Text) * 60000;
                                
            }
        }


        private void zerarCon(object sender, EventArgs e)
        {
            contador = 0;
        }
    }
}
