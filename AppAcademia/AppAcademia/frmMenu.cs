using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAcademia
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDanca tela = new frmDanca();
            tela.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void lblMusculacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMusculacao tela = new frmMusculacao();
            tela.ShowDialog();
        }

        private void lblNatacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNatacao tela = new frmNatacao();
            tela.ShowDialog();
        }

        private void lblAvaliacao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAvaliacao tela = new frmAvaliacao();
            tela.ShowDialog();
        }

        private void btnGerarFicha_Click(object sender, EventArgs e)
        {
            frmFicha tela = new frmFicha();
            tela.ShowDialog();
        }
    }
}
