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
    public partial class FrmEditor : Form
    {
        public FrmEditor()
        {
            InitializeComponent();
        }

        public bool AbrirArquivo()
        {
            objAbrir.ShowDialog();
            if (!string.IsNullOrEmpty(objAbrir.FileName))
            {
                objSalvar.FileName = objAbrir.FileName;
                if (objAbrir.FilterIndex == 1)
                    txtEditor.LoadFile(objAbrir.FileName, RichTextBoxStreamType.RichText);
                else
                    txtEditor.LoadFile(objAbrir.FileName, RichTextBoxStreamType.PlainText);

                return true;
            }
            return false;

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar este arquivo?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(objSalvar.FileName))
            {
                objSalvar.ShowDialog();
                if (!string.IsNullOrEmpty(objSalvar.FileName))
                    if (objSalvar.FilterIndex == 1)
                        txtEditor.SaveFile(objSalvar.FileName, RichTextBoxStreamType.RichText);
                    else
                        txtEditor.SaveFile(objSalvar.FileName, RichTextBoxStreamType.PlainText);
            }
            else
            {
                    if (objSalvar.FilterIndex == 1)
                        txtEditor.SaveFile(objSalvar.FileName, RichTextBoxStreamType.RichText);
                    else
                        txtEditor.SaveFile(objSalvar.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEditor.SelectedText);
            txtEditor.SelectedText = "";
        }

        private void corDaFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objCor.ShowDialog();
            txtEditor.SelectionColor = objCor.Color;
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objCor.ShowDialog();
            txtEditor.SelectionBackColor = objCor.Color;
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objFonte.ShowDialog();
            txtEditor.SelectionFont = objFonte.Font;
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEditor.SelectedText);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.Paste();
        }

        private void selecionarTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEditor.SelectAll();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objSalvar.ShowDialog();
            if (!string.IsNullOrEmpty(objSalvar.FileName))
                if (objSalvar.FilterIndex == 1)
                    txtEditor.SaveFile(objSalvar.FileName, RichTextBoxStreamType.RichText);
                else
                    txtEditor.SaveFile(objSalvar.FileName, RichTextBoxStreamType.PlainText);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
