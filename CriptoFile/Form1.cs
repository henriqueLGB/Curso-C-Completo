using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Criptografia.cspp = new CspParameters();
            Criptografia.EncrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Encrypt\";
            Criptografia.DecrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Decrypt\";
            Criptografia.SrcFolder  = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        }

        private void btnCriptografarArq_Click(object sender, EventArgs e)
        {
            if(Criptografia.rsa == null)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Chave não definida.";
            }
            else
            {
                //Mostra uma caixa de dialogo para escolher um arquivo para criptografar
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Criptografia.SrcFolder;

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);

                    //Passa o nome do arquivo com o caminho
                    string name = fInfo.FullName;
                    label1.Text = Criptografia.EncryptFile(name);
                }
            }
        }

        private void btnDescriptografarArq_Click(object sender, EventArgs e)
        {
            if (Criptografia.rsa == null)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Chave não definida.";
            }
            else
            {
                //Mostra uma caixa de dialogo para escolher um arquivo para criptografar
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Criptografia.SrcFolder;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);

                    //Passa o nome do arquivo com o caminho
                    string name = fInfo.Name;
                    label1.Text = Criptografia.DecryptFile(name);
                }
            }
        }

        private void btnCriarChaves_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Insira um valor para definir a chave pública.";
                txtSearch.Focus();
                return;
            }

            Criptografia.keyName = txtSearch.Text;
            label1.ForeColor = Color.DarkBlue;

            label1.Text = Criptografia.CreateAsmKeys();
               
        }

        private void btnExportarChavePub_Click(object sender, EventArgs e)
        {
            if (Criptografia.ExportPublicKey())
            {
                label1.ForeColor = Color.DarkBlue;
                label1.Text = "Chave pública exportada.";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Chave pública não exportada.";
            }
        }

        private void btnImportarChavePub_Click(object sender, EventArgs e)
        {
            Criptografia.keyName = "Publica";
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Criptografia.ImportPublicKey();
        }

        private void btnObterChavePrivada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Insira um valor para definir a chave privada.";
                txtSearch.Focus();
                return;
            }

            Criptografia.keyName = txtSearch.Text;
            label1.ForeColor = Color.DarkBlue;
            label1.Text = Criptografia.GetPrivateKey();
        }
    }
}
