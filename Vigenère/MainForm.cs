using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vigenère
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();

            this.txtCleartext.CharacterCasing = CharacterCasing.Upper;
            this.txtCiphertext.CharacterCasing = CharacterCasing.Upper;
            this.txtKey.CharacterCasing = CharacterCasing.Upper;

            this.txtCleartext.Validating += new CancelEventHandler((sender, e) => this.restrictToPermitChar(sender, e, "^[A-Z ]*$"));
            this.txtCiphertext.Validating += new CancelEventHandler((sender, e) => this.restrictToPermitChar(sender, e, "^[A-Z ]*$"));
            this.txtKey.Validating += new CancelEventHandler((sender, e) => this.restrictToPermitChar(sender, e, "^[A-Z ]*$"));

            foreach (string language in Vigenere.LETTER_FREQUENCY.Keys)
                this.cbbLanguage.Items.Add(language);

            if (this.cbbLanguage.Items.Count > 0)
                this.cbbLanguage.SelectedIndex = 0;

            // TEST 1 :
            //this.txtCiphertext.Text = "NLPKMVGNSOXYPTGCEMQYHGDTGYWGPWGEHGDSRTRKZRUPWVFRFPWFCSKEWNPWRWYUAVGNMGFBFPPJZQOPXQFXETXQJIPAIWEHQYGRLVNPVGNVKCIKXTTTQGCPKMVGXIPEWCFJCCIRZRFCIFPPCMYUOIEPXVPPKMITEIFLRUWIUNEUOIVPVOTRGDTCCPCWSK";
            //this.txtKey.Text = "CLE";
            //this.cbbLanguage.SelectedIndex = 1;
            //this.nudMaxKeyLength.Value = 6;

            // TEST 2 :
            this.txtCiphertext.Text = "UVQPF SYVSP TCAWL HQWLY VYAJE ELHQQ SXACM PLIUH ZMIYW SRSJE DLMWH IUTES XMFFA VEELI ARKIU UDMLC URKTL EFAXC KMKIE XZIUO YTDIE EZXSV QSOMW RUEOS FGWRZ IVAAT TXZIE EFLGH KTAHW JWAFX ZIKEF IULFI CYWWU RKTLS DOSCA WLHQW LYVYA JUVQP FSYVS PTCSR VCDCH XSNMC DWASW IQJWA FYJIK ORMFJ GRYEL MGNEI UYJIF CARXO DQSXA OZMFG DUPIU SFFUH WRLIM PAXQO DTJMN AOCVE LAURL IYRUX QEMTT IFXAC MXASF AZHFS FRQTM HAAFM GRWAO LGJLH QWWEK PQGLW GFYIK WSGQW WGMRU XQGSN MHVVW SEIVF QSFEF HSRPQ WXZOP WARUR KTLSY RMTZC TEEMV IKEJG ZEFGQ SXQWS EEYIK TASDW XRAQU VQPFS YVSPT CUEFB QEHTD IQHLS KHMVA RYAZE UGWSE OWCTE FAWIF MGPLM HLQTS VLIQW KSLHM XFSGN QTWVK OZGSR YAURS GUEEW LSSVM YDXTY MRQXO OAJLL WMOEF EFOFL WVJOX IAWAN FLWHW SUKFS XEXIU XJOZM UJGRY WGJUA EL";
            //this.txtKey.Text = "SESAME";
            this.cbbLanguage.SelectedIndex = 0;
            this.nudMaxKeyLength.Value = 8;

            //this.btnRunFriedman_Click(null, null);
            //this.btnAnalyseFrequency_Click(null, null);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;

            Keys keyCode = (Keys)(msg.WParam.ToInt32() & Convert.ToInt32(Keys.KeyCode));

            if ((msg.Msg == WM_KEYDOWN && keyCode == Keys.A) && (ModifierKeys == Keys.Control) && (this.ActiveControl.GetType() == typeof(TextBox)))
            {
                ((TextBox)this.ActiveControl).SelectAll();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (this.txtCleartext.Text == string.Empty)
                MessageBox.Show(this, "The cleartext message must be defined!", "Error");
            else if (this.txtKey.Text == string.Empty)
                MessageBox.Show(this, "The key must be defined!", "Error");
            else
                this.txtCiphertext.Text = Vigenere.Encrypt(this.txtCleartext.Text, this.txtKey.Text);
        }

        private void restrictToPermitChar(object sender, CancelEventArgs e, string expression)
        {
            this.erpError.Clear();

            if (!Regex.IsMatch(((TextBox)sender).Text, expression))
            {
                e.Cancel = true;
                this.erpError.SetError((Control)sender, "Invalid characters.");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (this.txtCiphertext.Text == string.Empty)
                MessageBox.Show(this, "The ciphertext message must be defined!", "Error");
            else if (this.txtKey.Text == string.Empty)
                MessageBox.Show(this, "The key must be defined!", "Error");
            else
                this.txtCleartext.Text = Vigenere.Decrypt(this.txtCiphertext.Text, this.txtKey.Text);
        }

        private void btnRunFriedman_Click(object sender, EventArgs e)
        {
            if (this.txtCiphertext.Text == string.Empty)
                MessageBox.Show(this, "The ciphertext message must be defined!", "Error");
            else
            {
                string ciphertext = this.txtCiphertext.Text.Replace(" ", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty);

                StringBuilder sb = new StringBuilder();
                Dictionary<int, List<double>> friedmanResults;
                int probableKeyLength = Vigenere.FriedmanTest(ciphertext, this.cbbLanguage.Text, out friedmanResults, (int)this.nudMaxKeyLength.Value);

                sb.Append("Key length : IC(x)\r\n");

                foreach (KeyValuePair<int, List<double>> friedmanResult in friedmanResults)
                {
                    sb.Append(friedmanResult.Key + " :");

                    foreach (double value in friedmanResult.Value)
                        sb.Append(" " + Math.Round(value, 3));

                    sb.Append("\r\n");
                }

                this.txtResultFriedman.Text = sb.ToString();
                this.txtProbableKeyLength.Text = probableKeyLength.ToString();
                this.nudAnalyseFrequencyKeyLength.Value = probableKeyLength;
            }
        }

        private void btnAnalyseFrequency_Click(object sender, EventArgs e)
        {
            if (this.txtCiphertext.Text == string.Empty)
                MessageBox.Show(this, "The ciphertext message must be defined!", "Error");
            else
            {
                string ciphertext = this.txtCiphertext.Text.Replace(" ", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty);

                this.txtAnalyseFrequenciesKey.Text = Vigenere.GuessKey(ciphertext, (int)this.nudAnalyseFrequencyKeyLength.Value, this.cbbLanguage.Text);
                this.txtKey.Text = this.txtAnalyseFrequenciesKey.Text;
            }
        }
    }
}
