using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar a aplicação?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditor janela = new FrmEditor();
            janela.MdiParent = this;
            janela.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditor janela = new FrmEditor();
            janela.MdiParent = this;
            if (janela.AbrirArquivo())
                janela.Show();
            else
                janela.Dispose();
        }
    }
}
