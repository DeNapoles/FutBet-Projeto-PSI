using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace projetoPSI3
{
    public partial class Form1 : Form
    {
        private string equipaescolhida = "";
        private string equipaescolhida1j3 = "";
        private string equipaescolhida2j3 = "";
        private string equipaVencedora1 = "";
        private string equipaVencedora2 = "";
        double saldo = 1000.0;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            Saldo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Saldo()
        {
            dinheirot.Text = saldo + " €";
        }   

        private string ObterOpcaoAposta()
        {
            if (rbtnGanhar1.Checked || rbtnGanharBr.Checked || rbtn3Ganhar1.Checked || rbtnGanharS.Checked || rbtnGanharPo.Checked || rbtn3Ganhar2.Checked)
            {
                return "Ganhar";
            } 
            else if (rbtnGanharS.Checked || rbtnGanharPo.Checked || rbtn3Ganhar2.Checked || rbtnGanhar1.Checked || rbtnGanharBr.Checked || rbtn3Ganhar1.Checked)
            {
                return "Perder";
            }  
         return "";
        }
        private void RealizarAposta(string equipaApostada, double valorApostado) //faz a aposta
        {
            dinheiro.Visible = false;
            int Equipa1 = random.Next(6);
            int Equipa2 = random.Next(6);
            string resultadoJogo = $"{Equipa1} - {Equipa2}";
            if (equipaApostada == "Benfica")
            {
                dinheiro.Visible = true;
                if (Equipa1 < Equipa2)
                {
                    MessageBox.Show("Perdeste a aposta! Equipa Vencedora: Sporting. Resultado: " + resultadoJogo);
                    pictrofeu2.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Red;
                    saldo -= valorApostado;
                    dinheiro.Text = Convert.ToString("-" + valorApostado); //color.Green.
                    equipaVencedora1 = "Sporting";
                    btnequipa2j3.Visible = true;
                }
                else if (Equipa1 > Equipa2)
                {
                    MessageBox.Show("Ganhaste a aposta. Equipa Vencedora: Benfica. Resultado: " + resultadoJogo);
                    pictrofeu1.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Green;
                    saldo += valorApostado * 2;
                    dinheiro.Text = Convert.ToString("+" + valorApostado * 2);
                    equipaVencedora1 = "Benfica";
                    btnequipa1j3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Empate! Resultado: " + resultadoJogo);
                }
            }
            else if (equipaApostada == "Sporting")
            {
                dinheiro.Visible = true;
                if (Equipa1 > Equipa2)
                {
                    MessageBox.Show("Perdeste a aposta! Equipa Vencedora: Benfica. Resultado: " + resultadoJogo);
                    pictrofeu1.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Red;
                    saldo -= valorApostado;
                    dinheiro.Text = Convert.ToString("-" + valorApostado);
                    equipaVencedora1 = "Benfica";
                    btnequipa1j3.Visible = true;
                }
                else if (Equipa1 < Equipa2)
                {
                    MessageBox.Show("Ganhaste a aposta. Equipa Vencedora: Sporting. Resultado: " + resultadoJogo);
                    pictrofeu2.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Green;
                    saldo += valorApostado * 2;
                    dinheiro.Text = Convert.ToString("+" + valorApostado * 2);
                    equipaVencedora1 = "Sporting";
                    btnequipa2j3.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("Empate! Resultado: " + resultadoJogo);
                }
            }
            Saldo();//atualizar o saldo
        }
        private void RealizarAposta2(string equipaApostada2, double valorApostado2) //faz a aposta
        {
            dinheiro.Visible = false;
            int Equipa3 = random.Next(6);
            int Equipa4 = random.Next(6);
            string resultadoJogo = $"{Equipa3} - {Equipa4}";

            if (equipaApostada2 == "Braga")
            {
                dinheiro.Visible = true;
                if (Equipa3 < Equipa4)
                {
                    MessageBox.Show("Perdeste a aposta! Equipa Vencedora: Porto. Resultado: " + resultadoJogo);
                    pictrofeu4.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Red;
                    saldo -= valorApostado2;
                    dinheiro.Text = Convert.ToString("-" + valorApostado2); //color.Green.
                    equipaVencedora2 = "Porto";
                    btnequipa4j3.Visible = true;
                }
                else if (Equipa3 > Equipa4)
                {
                    MessageBox.Show("Ganhaste a aposta. Equipa Vencedora: Braga. Resultado: " + resultadoJogo);
                    pictrofeu3.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Green;
                    saldo += valorApostado2 * 2;
                    dinheiro.Text = Convert.ToString("+" + valorApostado2 * 2);
                    equipaVencedora2 = "Braga";
                    btnequipa3j3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Empate! Resultado: " + resultadoJogo);
                }
            }
            else if (equipaApostada2 == "Porto")
            {
                dinheiro.Visible = true;
                if (Equipa3 > Equipa4)
                {
                    MessageBox.Show("Perdeste a aposta a aposta! Equipa Vencedora: Braga. Resultado: " + resultadoJogo);
                    pictrofeu3.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Red;
                    saldo -= valorApostado2;
                    dinheiro.Text = Convert.ToString("-" + valorApostado2);
                    equipaVencedora2 = "Braga";
                    btnequipa3j3.Visible = true;
                }
                else if (Equipa3 < Equipa4)
                {
                    MessageBox.Show("Ganhaste a aposta. Equipa Vencedora: Porto. Resultado: " + resultadoJogo);
                    pictrofeu4.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Green;
                    saldo += valorApostado2 * 2;
                    dinheiro.Text = Convert.ToString("+" + valorApostado2 * 2);
                    equipaVencedora2 = "Porto";
                    btnequipa4j3.Visible = true;
                }
                else
                {
                    MessageBox.Show("Empate! Resultado: " + resultadoJogo);
                }   }
            Saldo();
        }
        private void RealizarAposta3(string equipaApostada3, double valorApostado3) //faz a aposta
        {
            dinheiro.Visible = false;
            int Equipa5 = random.Next(6);
            int Equipa6 = random.Next(6);
            string resultadoJogo3 = $"{Equipa5} - {Equipa6}";
            if (equipaApostada3 == equipaVencedora2)
            {
                dinheiro.Visible = true;
                if (Equipa5 < Equipa6)
                {
                    MessageBox.Show("Perdeste a aposta! Equipa Vencedora: "+ equipaVencedora2 +". Resultado: " + resultadoJogo3);
                    pictrofeu6.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Red;
                    saldo -= valorApostado3;
                    dinheiro.Text = Convert.ToString("-" + valorApostado3); 
                }
                else if (Equipa5 > Equipa6)
                {
                    MessageBox.Show("Ganhaste a aposta. Equipa Vencedora: " + equipaVencedora1 + " Resultado:" + resultadoJogo3);
                    pictrofeu5.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Green;
                    saldo += valorApostado3 * 2;
                    dinheiro.Text = Convert.ToString("+" + valorApostado3 * 2);
                }
                else
                {
                    MessageBox.Show("Empate! Resultado: " + resultadoJogo3);
                }
            }
            else if (equipaApostada3 == equipaVencedora1)
            {
                dinheiro.Visible = true;
                if (Equipa5 > Equipa6)  //Equipa1 - 5 Equipa2 - 6
                {
                    MessageBox.Show("Perdeste a aposta a aposta! Equipa Vencedora: " + equipaVencedora1 + ". Resultado: " + resultadoJogo3);
                    pictrofeu5.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Red;
                    saldo -= valorApostado3;
                    dinheiro.Text = Convert.ToString("-" + 3);
                }
                else if (Equipa5 < Equipa6)
                {
                    MessageBox.Show("Ganhaste a aposta. Equipa Vencedora: " + equipaVencedora2 + ". Resultado: " + resultadoJogo3);
                    pictrofeu6.Visible = true;
                    dinheiro.ForeColor = System.Drawing.Color.Green;
                    saldo += valorApostado3 * 2;
                    dinheiro.Text = Convert.ToString("+" + valorApostado3 * 2);
                }
                else
                {
                    MessageBox.Show("Empate! Resultado: " + resultadoJogo3);
                }
            }
            Saldo();
        }
        private bool ResultadoAposta(string opcaoAposta, int Equipa1, int Equipa2)
        {
            switch (opcaoAposta)
            {
                case "Ganhar":
                    return Equipa1 > Equipa2;
                case "Perder":
                    return Equipa1 < Equipa2;
                default:
                    return false;
            }
        }
        private bool ResultadoAposta2(string opcaoAposta2, int Equipa3, int Equipa4)
        {
            switch (opcaoAposta2)
            {
                case "Ganhar":
                    return Equipa3 > Equipa4;
                case "Perder":
                    return Equipa3 < Equipa4;
                default:
                    return false;
            }
        }
        private bool ResultadoAposta3(string opcaoAposta3, int Equipa5, int Equipa6)
        {
            switch (opcaoAposta3)
            {
                case "Ganhar":
                    return Equipa5 > Equipa6;
                case "Perder":
                    return Equipa5 < Equipa6;
                default:
                    return false;
            }
        }
        private void btnequipa1_Click(object sender, EventArgs e) //benfica
        {
            labelMontante1.Visible = true;
            txtValorApostado1.Visible = true;
            labelResultado1.Visible = true;
            rbtnGanhar1.Visible = true;
            rbtnGanharS.Visible = true;
            btnConfirmar1.Visible = true;
        }
        private void btnequipa2_Click(object sender, EventArgs e)//sporting
        {
            labelMontante1.Visible = true;
            txtValorApostado1.Visible = true;
            labelResultado1.Visible = true;
            rbtnGanhar1.Visible = true;
            rbtnGanharS.Visible = true;
            btnConfirmar1.Visible = true;    
        }
        private void btnequipa3_Click(object sender, EventArgs e)//braga
        {
            labelMontante2.Visible = true;
            txtValorApostado2.Visible = true;
            labelResultado2.Visible = true;
            rbtnGanharBr.Visible = true;
            rbtnGanharPo.Visible = true;
            btnConfirmar2.Visible = true;
        }
        private void btnequipa4_Click(object sender, EventArgs e)//porto
        {
            labelMontante2.Visible = true;
            txtValorApostado2.Visible = true;
            labelResultado2.Visible = true;
            rbtnGanharBr.Visible = true;
            rbtnGanharPo.Visible = true;
            btnConfirmar2.Visible = true;    
        }
        private void txtValorApostado1_TextChanged(object sender, EventArgs e)
        {  
        }
        private void txtValorApostado2_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtValorApostado3_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnConfirmar1_Click(object sender, EventArgs e) //Confirmar Aposta 1
        {
            pictrofeu1.Visible = false;
            pictrofeu2.Visible = false;
            if (double.TryParse(txtValorApostado1.Text, out double valorApostado) && valorApostado > 0 && valorApostado <= saldo)
            {
                RealizarAposta(equipaescolhida, valorApostado);
            }
            else
            {
                MessageBox.Show("Digite um valor de aposta válido.", "Erro");
            }
        }
        private void btnConfirmar2_Click(object sender, EventArgs e)  //Confirmar Aposta 2
        {
            pictrofeu3.Visible = false;
            pictrofeu4.Visible = false;
            if (double.TryParse(txtValorApostado2.Text, out double valorApostado2) && valorApostado2 > 0 && valorApostado2 <= saldo)
            {
                RealizarAposta2(equipaescolhida, valorApostado2);
            }
            else
            {
                MessageBox.Show("Digite um valor de aposta válido.", "Erro");
            }
        }
        private void btnConfirmar3_Click(object sender, EventArgs e)  //Confirmar Aposta 3
        {
            pictrofeu6.Visible = false;
            pictrofeu5.Visible = false;
            if (double.TryParse(txtValorApostado3.Text, out double valorApostado3) && valorApostado3 > 0 && valorApostado3 <= saldo)
            {
                RealizarAposta3(equipaescolhida, valorApostado3);
            }
            else
            {
                MessageBox.Show("Digite um valor de aposta válido.", "Erro");
            }
        }
        private void rbtnGanhar1_CheckedChanged(object sender, EventArgs e)
        {
            equipaescolhida = "Benfica";
        }
        private void rbtnGanharS_CheckedChanged(object sender, EventArgs e)
        {
            equipaescolhida = "Sporting";
        }
        private void rbtnGanharBr_CheckedChanged(object sender, EventArgs e)
        {
            equipaescolhida = "Braga";
        }
        private void rbtnGanharPo_CheckedChanged(object sender, EventArgs e)
        {
            equipaescolhida = "Porto";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//botão para fechar o programa
        private void rbtn3Ganhar1_CheckedChanged(object sender, EventArgs e)
        {
            equipaVencedora1 = equipaescolhida1j3;
        }
        private void rbtn3Ganhar2_CheckedChanged(object sender, EventArgs e)
        {
            equipaVencedora2 = equipaescolhida2j3;
        }
        private void btnequipa2j3_Click(object sender, EventArgs e)
        {
            rbtn3Ganhar1.Text = " Ganhar " + equipaVencedora1;
            rbtn3Ganhar2.Text = " Ganhar" + equipaVencedora2;
            dinheiro.Visible = false;
            labelMontante3.Visible = true;
            txtValorApostado3.Visible = true;
            labelResultado3.Visible = true;
            rbtn3Ganhar1.Visible = true;
            rbtn3Ganhar2.Visible = true;
            btnConfirmar3.Visible = true;
        }
        private void btnequipa4j3_Click(object sender, EventArgs e)
        {
            rbtn3Ganhar1.Text = " Ganhar " + equipaVencedora1;
            rbtn3Ganhar2.Text = " Ganhar" + equipaVencedora2;
            dinheiro.Visible = false;
            labelMontante3.Visible = true;
            txtValorApostado3.Visible = true;
            labelResultado3.Visible = true;
            rbtn3Ganhar1.Visible = true;
            rbtn3Ganhar2.Visible = true;
            btnConfirmar3.Visible = true;
        }
        private void btnquipa1j3_Click(object sender, EventArgs e)
        {
            rbtn3Ganhar1.Text = " Ganhar " + equipaVencedora1;
            rbtn3Ganhar2.Text = " Ganhar" + equipaVencedora2;
            dinheiro.Visible = false;
            labelMontante3.Visible = true;
            txtValorApostado3.Visible = true;
            labelResultado3.Visible = true;
            rbtn3Ganhar1.Visible = true;
            rbtn3Ganhar2.Visible = true;
            btnConfirmar3.Visible = true;
        }
        private void btnquipa3j3_Click(object sender, EventArgs e)
        {
            rbtn3Ganhar1.Text = " Ganhar " + equipaVencedora1;
            rbtn3Ganhar2.Text = " Ganhar" + equipaVencedora2;
            dinheiro.Visible = false;
            labelMontante3.Visible = true;
            txtValorApostado3.Visible = true;
            labelResultado3.Visible = true;
            rbtn3Ganhar1.Visible = true;
            rbtn3Ganhar2.Visible = true;
            btnConfirmar3.Visible = true;
        }  }  }