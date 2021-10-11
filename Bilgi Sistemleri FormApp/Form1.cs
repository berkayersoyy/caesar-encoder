using System;
using System.Windows.Forms;
using Bilgi_Sistemleri.Helpers;
using Encoder = Bilgi_Sistemleri.Helpers.Encoder;

namespace Bilgi_Sistemleri_FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radiobuttonEncrypt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtboxInput.Text))
            {
                MessageBox.Show("Boş içerik giremezsiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string encodedMessage;
            if (radiobuttonEncrypt.Checked)
            {
                encodedMessage = Encoder.Encipher(txtboxInput.Text, Constants.Key);
            }
            else
            {
                encodedMessage = Encoder.Decipher(txtboxInput.Text, Constants.Key);
            }

            labelResult.Text = encodedMessage;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelResult.Text);
        }
    }
}
