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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent(); 
            
        }
        
        static void Main()
        {
           
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            if (rbtn18.Checked)
            {
                Form1 form1 = new Form1();
                form1.FormClosed += (s, args) => this.Close(); // Fecha o formulário Menu quando o Form1 é fechado
                form1.Show();
            }
            else
            {
                btnApostar.Enabled = false;
                MessageBox.Show("É necessário aceitar os termos de privacidade e ser maior de 18 anos para apostar");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbtn18_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn18.Checked)
            {
                btnApostar.Enabled = true;
            }
            else
            {
                btnApostar.Enabled = false;
            }
        }
    }
}