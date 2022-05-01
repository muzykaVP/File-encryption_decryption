using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AAJGen;

namespace File_encryption_decryption
{
    public partial class Form1 : Form
    {
        List<Panel> panelList = new List<Panel>();
        RandomGen randomGen = new RandomGen(Option.IncludeCapital);
        AES aES = new AES();
        RSAEnc rSA = new RSAEnc();
        RSACryptoServiceProvider rSACryptoService = new RSACryptoServiceProvider();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            DES_panel.Visible = true;
            panelList.Add(TripleDES_panel);
            panelList.Add(DES_panel);
            panelList.Add(AES_panel);
            panelList.Add(RSA_panel);
        }
        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            path_textBox.BringToFront();
        }


        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // Dragable form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TDES_encrypt_button_Click(object sender, EventArgs e)
        {
            TripleDES tDES = new TripleDES(tDES_key_textBox.Text);
            tDES.EncryptFileTDES(path_textBox.Text);
        }
        private void TDES_decrypt_button_Click(object sender, EventArgs e)
        {
            TripleDES tDES = new TripleDES(tDES_key_textBox.Text);
            tDES.DecryptFileTDES(path_textBox.Text);
        }



        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            path_textBox.Clear();
            for (int i = 0; i < panelList.Count; i++)
                panelList[i].Visible = panelList[i].Name.Equals(comboBox1.Text + "_panel") ? true : false;
        }


        private void DES_encrypt_button_Click(object sender, EventArgs e)
        {
            DataEncS dES = new DataEncS(dES_key_textBox.Text);
            dES.EncryptFileDES(path_textBox.Text);
        }

        private void DES_decrypt_button_Click(object sender, EventArgs e)
        {
            DataEncS dES = new DataEncS(dES_key_textBox.Text);
            dES.DecryptFileDES(path_textBox.Text);
        }



        private void RandomKeyGenarator(object sender, EventArgs e)
        {
            foreach (Panel panel in panelList)
            {
                if (panel.Visible == true)
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is TextBox)
                        {
                            control.Text = randomGen.Gen(((TextBox)control).MaxLength);
                            Clipboard.SetText(((TextBox)control).Text);
                        }
                    }
                }
            }
        }

        private void AES_encrypt_button_Click(object sender, EventArgs e)
        {
            aES.EncryptFileAES(aES_key_textBox.Text, path_textBox.Text, null);
        }
        private void AES_decrypt_button_Click(object sender, EventArgs e)
        {
            aES.DecryptFileAES(aES_key_textBox.Text, path_textBox.Text, null);
        }

        private void RSA_encrypt_button_Click(object sender, EventArgs e)
        {
            rSA.EncryptFileRSA(path_textBox.Text, rSA_public_key_textBox.Text);
        }

        private void RSA_decrypt_button_Click(object sender, EventArgs e)
        {
            rSA.DecryptFileRSA(path_textBox.Text, rSA_private_key_textBox.Text);
        }
        private void File_select_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path_textBox.Text = openFileDialog.FileName;
            }
        }

        private void select_public_key_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML - File | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rSA_public_key_textBox.Text = openFileDialog.FileName;
                File.WriteAllText(rSA_public_key_textBox.Text, rSACryptoService.ToXmlString(false));
            }
        }

        private void select_private_key_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML - File | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rSA_private_key_textBox.Text = openFileDialog.FileName;
                File.WriteAllText(rSA_private_key_textBox.Text, rSACryptoService.ToXmlString(true));
            }
        }
    }
}
