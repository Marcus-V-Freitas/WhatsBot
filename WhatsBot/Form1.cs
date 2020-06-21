using OpenQA.Selenium;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsBot
{

    public partial class Form1 : Form
    {
        private static IWebDriver webDriver;
        private static bool Prosseguir = false;
        private delegate void Acao();
        string conviteUrl = @"https://chat.whatsapp.com/HJYelb7tUfqKjX2AU4whGF";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conviteUrl = txtConvite.Text;
            try
            {
                webDriver = WebDriverFactory.CreateWebDriver(Browser.Chrome, @"C:\Users\marcu\source\repos\Web Bots\Bot.WhatsApp.Share.Selenium\bin\Debug\netcoreapp2.0", false);
                Validar(new Acao(AbrirWhatApp));
                Validar(new Acao(BotaoJuntar));
                Validar(new Acao(SemDownload));
                Validar(new Acao(EntrarGrupo));
                Validar(new Acao(EnviarMensagem));
                Validar(new Acao(AbrirMenu));
                Validar(new Acao(SairGrupo));
                Validar(new Acao(ConfirmarSaida));
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AbrirWhatApp()
        {
            try
            {
                Console.WriteLine("Abrindo o WhatsApp Web");
                webDriver.LoadPage(TimeSpan.FromSeconds(10), "https://web.whatsapp.com");
                Console.WriteLine("Pegue seu celular e leia o QRCODE.");
                Thread.Sleep(TimeSpan.FromSeconds(10));
                Prosseguir = true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
                Prosseguir = false;
            }
        }

        private void BotaoJuntar()
        {
            try
            {
                Console.WriteLine("Carregando a página de convite.");
                webDriver.LoadPage(TimeSpan.FromSeconds(40), conviteUrl);
                //Clicar no botao Join
                Console.WriteLine("Clicando no botao join.");
                var btnJoin = webDriver.FindElement(By.Id("action-button"));
                btnJoin.Click();
                Prosseguir = true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
                Prosseguir = false;
            }
        }

        private void SemDownload()
        {
            try
            {
                Console.WriteLine("Sem Download.");
                Thread.Sleep(TimeSpan.FromSeconds(10));
                var btnSemDownload = webDriver.FindElements(By.ClassName("_36or"));
                btnSemDownload[75].Click();
                Prosseguir = true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
                Prosseguir = false;
            }
        }


        private void EntrarGrupo()
        {
            try
            {
                //Aguardo o botão Entrar no grupo aparecer
                Thread.Sleep(TimeSpan.FromSeconds(20));
                //Clicar no botão entrar no grupo
                Console.WriteLine("Clicando no botao entrar no grupo.");
                var btnEntrarNoGrupo = webDriver.FindElement(By.ClassName("PNlAR"));
                btnEntrarNoGrupo.Click();
                Prosseguir = true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
                Prosseguir = false;
            }
        }

        private void EnviarMensagem()
        {
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(20));
                //Digitar uma mensagem
                var txtMensagem = By.XPath("//*[@id='main']/footer/div[1]/div[2]/div/div[2]");
                webDriver.SetText(txtMensagem, "Ola sou da equipe do WhatsApp, seu grupo foi selecionado para realização de testes de segurança! Pedimos desculpas pelo transtorno. Esse teste deve levar alguns minutos.");

                //Enviamos a mensagem
                webDriver.FindElement(txtMensagem).SendKeys(OpenQA.Selenium.Keys.Enter);
                Prosseguir = true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
                Prosseguir = false;
            }
        }

        private void AbrirMenu()
        {
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                Console.WriteLine("Abrindo o menu.");
                var menus = webDriver.FindElements(By.ClassName("rAUz7"));
                if (menus[5].Displayed)
                {
                    menus[5].Click();
                }
                Prosseguir = true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
                Prosseguir = false;
            }
        }

        private void SairGrupo()
        {
            try
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                Console.WriteLine("Clicando em sair do grupo.");
                var opcoesDoMenu = webDriver.FindElements(By.ClassName("_34D8D"));
                if (opcoesDoMenu[4].Displayed)
                {
                    opcoesDoMenu[4].Click();
                }
                Prosseguir = true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
                Prosseguir = false;
            }
        }

        private void ConfirmarSaida()
        {
            try
            {
                Console.WriteLine("Aguardando 25 segundos para o botão sair aparacer.");
                Thread.Sleep(TimeSpan.FromSeconds(10));

                Console.WriteLine("Confirmando saida do grupo.");
                var btnSairGrupo = webDriver.FindElement(By.ClassName("PNlAR"));

                btnSairGrupo.Click();
                Console.WriteLine("Operação realizada com sucesso!");
                Prosseguir = true;
            }
            catch (Exception ex)
            {
                txtLog.Text += $"{ex.Message}\n";
                Prosseguir = false;
            }
        }


        private void Validar(Acao acao)
        {
            try
            {
                while (!Prosseguir)
                {
                    acao();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                Prosseguir = false;
            }
        }

    }
}
