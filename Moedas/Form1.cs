using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moedas
{
    public partial class Form1 : Form
    {
        double cambioDolar = 5.48;
        double cambioEuro = 6.14;
        public Form1()
        {
            InitializeComponent();
        }
        //botao de atualizar cambio
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbNew.Text != "")
                {
                    double New = double.Parse(txbNew.Text);
                    if (New > 0)
                    {
                        cambioDolar = New;
                        lblCambio.Text = "O valor do Real em Dólar é: " + cambioDolar + " R$";
                        txbNew.Text = "";
                    }
                    else
                    {
                        lblAviso.Text = "impossível efetuar mudança";
                    }
                }
                else if (txbEuro.Text != "")
                {
                    double New1 = double.Parse(txbEuro.Text);
                    if (New1 > 0)
                    {
                        cambioEuro = New1;
                        lblEuro.Text = "O valor do Real em Euro é: " + cambioEuro + " R$";
                        txbEuro.Text = "";
                    }
                    else
                    {
                        lblAviso.Text = "impossível efetuar mudança";
                    }
                }
            }
            catch(Exception ex) 
            { 
                lblAviso.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCambio.Text = "O valor do Real em Dólar é: " + cambioDolar + " R$.";
            lblEuro.Text = "O valor do Real em Euro é: " + cambioEuro + " R$";
            lblAviso.Text = "";
            lblResult.Text = "";
        }
        //botão do conversor 
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try 
            {
                double dolar = 0;
                double reais = 0;
                double euro = 0;
                double result = 0;
                //Dolar
                if (cbDinheiro.SelectedItem == "Dolar")
                {
                    if (cbConvert.SelectedItem == "Real")
                    {
                        dolar = double.Parse(txbDinheiro.Text);
                        result = dolar * cambioDolar;
                        lblResult.Text = "Em Reais fica: " + result.ToString("F2") + " R$.";
                    }
                    if (cbConvert.SelectedItem == "Dolar")
                    {
                        lblResult.Text = "Impossível fazer conversão por ja ser do mesmo tipo.";
                    }
                    if (cbConvert.SelectedItem == "Euro")
                    {
                        dolar = double.Parse(txbDinheiro.Text);
                        result = dolar / 1.11;
                        lblResult.Text = "Em Euros fica: " + result.ToString("F2") + " €.";
                    }
                }
                //Euro
                if (cbDinheiro.SelectedItem == "Euro")
                {
                    if (cbConvert.SelectedItem == "Real")
                    {
                        euro = double.Parse(txbDinheiro.Text);
                        result = euro * cambioEuro;
                        lblResult.Text = "Em Reais fica: " + result.ToString("F2") + " R$";
                    }
                    if (cbConvert.SelectedItem == "Dolar")
                    {
                        euro = double.Parse(txbDinheiro.Text);
                        result = euro * 1.11;
                        lblResult.Text = "Em Dolár fica: " + result.ToString("F2") + " $";
                    }
                    if (cbConvert.SelectedItem == "Euro")
                    {
                        lblResult.Text = "Impossível fazer conversão por ja ser do mesmo tipo.";
                    }
                }
                //Reais
                if (cbDinheiro.SelectedItem == "Real")
                {
                    if (cbConvert.SelectedItem == "Real")
                    {
                        lblResult.Text = "Impossível fazer conversão por ja ser do mesmo tipo.";
                    }
                    if (cbConvert.SelectedItem == "Dolar")
                    {
                        reais = double.Parse(txbDinheiro.Text);
                        result = reais / cambioDolar;
                        lblResult.Text = "Em Dolar fica: " + result.ToString("F2") + " $";
                    }
                    if (cbConvert.SelectedItem == "Euro")
                    {
                        reais = double.Parse(txbDinheiro.Text);
                        result = reais / cambioEuro;
                        lblResult.Text = "Em Euros fica: " + result.ToString("F2") + " €";
                    }
                }
            }
            catch(Exception ex)
            {
                lblResult.Text = ex.Message;
            }
            
        }
    }
}
