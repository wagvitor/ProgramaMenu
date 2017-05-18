using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_1_Cliente frmTela1 = new Tela_1_Cliente();

            frmTela1.MdiParent = this;

            frmTela1.Show();          

        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_2_Servico frmTela2 = new Tela_2_Servico();

            frmTela2.MdiParent = this;

            frmTela2.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_3_Produtos frmTela3 = new Tela_3_Produtos();

            frmTela3.MdiParent = this;

            frmTela3.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela_4_Relatórios frmTela4 = new Tela_4_Relatórios();

            frmTela4.MdiParent = this;

            frmTela4.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void brunoSantanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(RA: 2215112684 - Nome: Bruno Santana)", "RA | Nome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void caiqueReisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(RA: 2215110016 - Nome: Caique Reis)", "RA | Nome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void larissaTayaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(RA: 2215202786 - Nome: Larissa Tayane)", "RA | Nome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void wagnerVitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(RA: 2215101553 - Nome: Wagner Vitor)", "RA | Nome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //MessageBox.Show("(RA: 2215101553 - Nome: Wagner Vitor)", "RA | Nome", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk); - MessageBoxButtons.OKCancel - serve para inserir botão de "OK" e "Cancelar" à caixa de mensagem de informação
        }
    }
}
