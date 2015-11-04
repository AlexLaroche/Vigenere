namespace Vigenère
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbpEncryptDecrypt = new System.Windows.Forms.TabPage();
            this.gbEncryptDecrypt = new System.Windows.Forms.GroupBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblCiphertext = new System.Windows.Forms.Label();
            this.txtCleartext = new System.Windows.Forms.TextBox();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.lblCleartext = new System.Windows.Forms.Label();
            this.tbcVigenere = new System.Windows.Forms.TabControl();
            this.tbpCryptanalyze = new System.Windows.Forms.TabPage();
            this.gbCryptanalyze = new System.Windows.Forms.GroupBox();
            this.gnAnalyseFrequencies = new System.Windows.Forms.GroupBox();
            this.btnAnalyseFrequency = new System.Windows.Forms.Button();
            this.lblAnalyseFrequenciesKey = new System.Windows.Forms.Label();
            this.txtAnalyseFrequenciesKey = new System.Windows.Forms.TextBox();
            this.nudMaxKeyLength = new System.Windows.Forms.NumericUpDown();
            this.gbFriedmanTest = new System.Windows.Forms.GroupBox();
            this.btnRunFriedman = new System.Windows.Forms.Button();
            this.lblResultFriedman = new System.Windows.Forms.Label();
            this.txtResultFriedman = new System.Windows.Forms.TextBox();
            this.lblMaxKeyLength = new System.Windows.Forms.Label();
            this.cbbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtProbableKeyLength = new System.Windows.Forms.TextBox();
            this.lblProbableKeyLength = new System.Windows.Forms.Label();
            this.nudAnalyseFrequencyKeyLength = new System.Windows.Forms.NumericUpDown();
            this.lblAnalyseFrequencyKeyLength = new System.Windows.Forms.Label();
            this.tbpEncryptDecrypt.SuspendLayout();
            this.gbEncryptDecrypt.SuspendLayout();
            this.tbcVigenere.SuspendLayout();
            this.tbpCryptanalyze.SuspendLayout();
            this.gbCryptanalyze.SuspendLayout();
            this.gnAnalyseFrequencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxKeyLength)).BeginInit();
            this.gbFriedmanTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalyseFrequencyKeyLength)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpEncryptDecrypt
            // 
            this.tbpEncryptDecrypt.Controls.Add(this.gbEncryptDecrypt);
            this.tbpEncryptDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpEncryptDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tbpEncryptDecrypt.Name = "tbpEncryptDecrypt";
            this.tbpEncryptDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEncryptDecrypt.Size = new System.Drawing.Size(567, 368);
            this.tbpEncryptDecrypt.TabIndex = 0;
            this.tbpEncryptDecrypt.Text = "Encrypt/Decrypt";
            this.tbpEncryptDecrypt.UseVisualStyleBackColor = true;
            // 
            // gbEncryptDecrypt
            // 
            this.gbEncryptDecrypt.Controls.Add(this.btnDecrypt);
            this.gbEncryptDecrypt.Controls.Add(this.btnEncrypt);
            this.gbEncryptDecrypt.Controls.Add(this.lblKey);
            this.gbEncryptDecrypt.Controls.Add(this.txtKey);
            this.gbEncryptDecrypt.Controls.Add(this.lblCiphertext);
            this.gbEncryptDecrypt.Controls.Add(this.txtCleartext);
            this.gbEncryptDecrypt.Controls.Add(this.txtCiphertext);
            this.gbEncryptDecrypt.Controls.Add(this.lblCleartext);
            this.gbEncryptDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEncryptDecrypt.Location = new System.Drawing.Point(3, 3);
            this.gbEncryptDecrypt.Name = "gbEncryptDecrypt";
            this.gbEncryptDecrypt.Size = new System.Drawing.Size(561, 362);
            this.gbEncryptDecrypt.TabIndex = 0;
            this.gbEncryptDecrypt.TabStop = false;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(467, 320);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(372, 320);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(6, 268);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(31, 13);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "Key :";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(6, 284);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(536, 20);
            this.txtKey.TabIndex = 5;
            // 
            // lblCiphertext
            // 
            this.lblCiphertext.AutoSize = true;
            this.lblCiphertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiphertext.Location = new System.Drawing.Point(6, 142);
            this.lblCiphertext.Name = "lblCiphertext";
            this.lblCiphertext.Size = new System.Drawing.Size(105, 13);
            this.lblCiphertext.TabIndex = 2;
            this.lblCiphertext.Text = "Ciphertext message :";
            // 
            // txtCleartext
            // 
            this.txtCleartext.Location = new System.Drawing.Point(9, 32);
            this.txtCleartext.Multiline = true;
            this.txtCleartext.Name = "txtCleartext";
            this.txtCleartext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCleartext.Size = new System.Drawing.Size(533, 97);
            this.txtCleartext.TabIndex = 1;
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(9, 158);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCiphertext.Size = new System.Drawing.Size(533, 97);
            this.txtCiphertext.TabIndex = 3;
            // 
            // lblCleartext
            // 
            this.lblCleartext.AutoSize = true;
            this.lblCleartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleartext.Location = new System.Drawing.Point(6, 16);
            this.lblCleartext.Name = "lblCleartext";
            this.lblCleartext.Size = new System.Drawing.Size(99, 13);
            this.lblCleartext.TabIndex = 0;
            this.lblCleartext.Text = "Cleartext message :";
            // 
            // tbcVigenere
            // 
            this.tbcVigenere.Controls.Add(this.tbpEncryptDecrypt);
            this.tbcVigenere.Controls.Add(this.tbpCryptanalyze);
            this.tbcVigenere.Location = new System.Drawing.Point(13, 13);
            this.tbcVigenere.Name = "tbcVigenere";
            this.tbcVigenere.SelectedIndex = 0;
            this.tbcVigenere.Size = new System.Drawing.Size(575, 394);
            this.tbcVigenere.TabIndex = 0;
            // 
            // tbpCryptanalyze
            // 
            this.tbpCryptanalyze.Controls.Add(this.gbCryptanalyze);
            this.tbpCryptanalyze.Location = new System.Drawing.Point(4, 22);
            this.tbpCryptanalyze.Name = "tbpCryptanalyze";
            this.tbpCryptanalyze.Size = new System.Drawing.Size(567, 368);
            this.tbpCryptanalyze.TabIndex = 1;
            this.tbpCryptanalyze.Text = "Cryptanalyze";
            this.tbpCryptanalyze.UseVisualStyleBackColor = true;
            // 
            // gbCryptanalyze
            // 
            this.gbCryptanalyze.Controls.Add(this.gnAnalyseFrequencies);
            this.gbCryptanalyze.Controls.Add(this.nudMaxKeyLength);
            this.gbCryptanalyze.Controls.Add(this.gbFriedmanTest);
            this.gbCryptanalyze.Controls.Add(this.lblMaxKeyLength);
            this.gbCryptanalyze.Controls.Add(this.cbbLanguage);
            this.gbCryptanalyze.Controls.Add(this.lblLanguage);
            this.gbCryptanalyze.Location = new System.Drawing.Point(3, 3);
            this.gbCryptanalyze.Name = "gbCryptanalyze";
            this.gbCryptanalyze.Size = new System.Drawing.Size(561, 362);
            this.gbCryptanalyze.TabIndex = 0;
            this.gbCryptanalyze.TabStop = false;
            // 
            // gnAnalyseFrequencies
            // 
            this.gnAnalyseFrequencies.Controls.Add(this.nudAnalyseFrequencyKeyLength);
            this.gnAnalyseFrequencies.Controls.Add(this.btnAnalyseFrequency);
            this.gnAnalyseFrequencies.Controls.Add(this.lblAnalyseFrequencyKeyLength);
            this.gnAnalyseFrequencies.Controls.Add(this.lblAnalyseFrequenciesKey);
            this.gnAnalyseFrequencies.Controls.Add(this.txtAnalyseFrequenciesKey);
            this.gnAnalyseFrequencies.Location = new System.Drawing.Point(10, 212);
            this.gnAnalyseFrequencies.Name = "gnAnalyseFrequencies";
            this.gnAnalyseFrequencies.Size = new System.Drawing.Size(545, 90);
            this.gnAnalyseFrequencies.TabIndex = 12;
            this.gnAnalyseFrequencies.TabStop = false;
            this.gnAnalyseFrequencies.Text = "Analyse frequencies";
            // 
            // btnAnalyseFrequency
            // 
            this.btnAnalyseFrequency.Location = new System.Drawing.Point(464, 54);
            this.btnAnalyseFrequency.Name = "btnAnalyseFrequency";
            this.btnAnalyseFrequency.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyseFrequency.TabIndex = 6;
            this.btnAnalyseFrequency.Text = "Run";
            this.btnAnalyseFrequency.UseVisualStyleBackColor = true;
            this.btnAnalyseFrequency.Click += new System.EventHandler(this.btnAnalyseFrequency_Click);
            // 
            // lblAnalyseFrequenciesKey
            // 
            this.lblAnalyseFrequenciesKey.AutoSize = true;
            this.lblAnalyseFrequenciesKey.Location = new System.Drawing.Point(6, 57);
            this.lblAnalyseFrequenciesKey.Name = "lblAnalyseFrequenciesKey";
            this.lblAnalyseFrequenciesKey.Size = new System.Drawing.Size(31, 13);
            this.lblAnalyseFrequenciesKey.TabIndex = 11;
            this.lblAnalyseFrequenciesKey.Text = "Key :";
            // 
            // txtAnalyseFrequenciesKey
            // 
            this.txtAnalyseFrequenciesKey.Location = new System.Drawing.Point(43, 54);
            this.txtAnalyseFrequenciesKey.Name = "txtAnalyseFrequenciesKey";
            this.txtAnalyseFrequenciesKey.ReadOnly = true;
            this.txtAnalyseFrequenciesKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnalyseFrequenciesKey.Size = new System.Drawing.Size(415, 20);
            this.txtAnalyseFrequenciesKey.TabIndex = 6;
            // 
            // nudMaxKeyLength
            // 
            this.nudMaxKeyLength.Location = new System.Drawing.Point(359, 19);
            this.nudMaxKeyLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaxKeyLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMaxKeyLength.Name = "nudMaxKeyLength";
            this.nudMaxKeyLength.Size = new System.Drawing.Size(58, 20);
            this.nudMaxKeyLength.TabIndex = 5;
            this.nudMaxKeyLength.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // gbFriedmanTest
            // 
            this.gbFriedmanTest.Controls.Add(this.txtProbableKeyLength);
            this.gbFriedmanTest.Controls.Add(this.lblProbableKeyLength);
            this.gbFriedmanTest.Controls.Add(this.btnRunFriedman);
            this.gbFriedmanTest.Controls.Add(this.lblResultFriedman);
            this.gbFriedmanTest.Controls.Add(this.txtResultFriedman);
            this.gbFriedmanTest.Location = new System.Drawing.Point(10, 45);
            this.gbFriedmanTest.Name = "gbFriedmanTest";
            this.gbFriedmanTest.Size = new System.Drawing.Size(545, 161);
            this.gbFriedmanTest.TabIndex = 5;
            this.gbFriedmanTest.TabStop = false;
            this.gbFriedmanTest.Text = "Friedman Test";
            // 
            // btnRunFriedman
            // 
            this.btnRunFriedman.Location = new System.Drawing.Point(464, 19);
            this.btnRunFriedman.Name = "btnRunFriedman";
            this.btnRunFriedman.Size = new System.Drawing.Size(75, 23);
            this.btnRunFriedman.TabIndex = 6;
            this.btnRunFriedman.Text = "Run";
            this.btnRunFriedman.UseVisualStyleBackColor = true;
            this.btnRunFriedman.Click += new System.EventHandler(this.btnRunFriedman_Click);
            // 
            // lblResultFriedman
            // 
            this.lblResultFriedman.AutoSize = true;
            this.lblResultFriedman.Location = new System.Drawing.Point(6, 49);
            this.lblResultFriedman.Name = "lblResultFriedman";
            this.lblResultFriedman.Size = new System.Drawing.Size(43, 13);
            this.lblResultFriedman.TabIndex = 11;
            this.lblResultFriedman.Text = "Result :";
            // 
            // txtResultFriedman
            // 
            this.txtResultFriedman.Location = new System.Drawing.Point(9, 75);
            this.txtResultFriedman.Multiline = true;
            this.txtResultFriedman.Name = "txtResultFriedman";
            this.txtResultFriedman.ReadOnly = true;
            this.txtResultFriedman.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultFriedman.Size = new System.Drawing.Size(533, 80);
            this.txtResultFriedman.TabIndex = 6;
            // 
            // lblMaxKeyLength
            // 
            this.lblMaxKeyLength.AutoSize = true;
            this.lblMaxKeyLength.Location = new System.Drawing.Point(235, 21);
            this.lblMaxKeyLength.Name = "lblMaxKeyLength";
            this.lblMaxKeyLength.Size = new System.Drawing.Size(88, 13);
            this.lblMaxKeyLength.TabIndex = 4;
            this.lblMaxKeyLength.Text = "Max. key length :";
            // 
            // cbbLanguage
            // 
            this.cbbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLanguage.FormattingEnabled = true;
            this.cbbLanguage.Location = new System.Drawing.Point(83, 18);
            this.cbbLanguage.Name = "cbbLanguage";
            this.cbbLanguage.Size = new System.Drawing.Size(133, 21);
            this.cbbLanguage.TabIndex = 1;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(16, 21);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Language :";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // txtProbableKeyLength
            // 
            this.txtProbableKeyLength.Location = new System.Drawing.Point(153, 21);
            this.txtProbableKeyLength.Name = "txtProbableKeyLength";
            this.txtProbableKeyLength.ReadOnly = true;
            this.txtProbableKeyLength.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProbableKeyLength.Size = new System.Drawing.Size(117, 20);
            this.txtProbableKeyLength.TabIndex = 12;
            // 
            // lblProbableKeyLength
            // 
            this.lblProbableKeyLength.AutoSize = true;
            this.lblProbableKeyLength.Location = new System.Drawing.Point(6, 24);
            this.lblProbableKeyLength.Name = "lblProbableKeyLength";
            this.lblProbableKeyLength.Size = new System.Drawing.Size(141, 13);
            this.lblProbableKeyLength.TabIndex = 12;
            this.lblProbableKeyLength.Text = "The probable key length is : ";
            // 
            // nudAnalyseFrequencyKeyLength
            // 
            this.nudAnalyseFrequencyKeyLength.Location = new System.Drawing.Point(75, 19);
            this.nudAnalyseFrequencyKeyLength.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAnalyseFrequencyKeyLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAnalyseFrequencyKeyLength.Name = "nudAnalyseFrequencyKeyLength";
            this.nudAnalyseFrequencyKeyLength.Size = new System.Drawing.Size(58, 20);
            this.nudAnalyseFrequencyKeyLength.TabIndex = 14;
            this.nudAnalyseFrequencyKeyLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblAnalyseFrequencyKeyLength
            // 
            this.lblAnalyseFrequencyKeyLength.AutoSize = true;
            this.lblAnalyseFrequencyKeyLength.Location = new System.Drawing.Point(6, 21);
            this.lblAnalyseFrequencyKeyLength.Name = "lblAnalyseFrequencyKeyLength";
            this.lblAnalyseFrequencyKeyLength.Size = new System.Drawing.Size(63, 13);
            this.lblAnalyseFrequencyKeyLength.TabIndex = 13;
            this.lblAnalyseFrequencyKeyLength.Text = "Key length :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 419);
            this.Controls.Add(this.tbcVigenere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Vigenère";
            this.tbpEncryptDecrypt.ResumeLayout(false);
            this.gbEncryptDecrypt.ResumeLayout(false);
            this.gbEncryptDecrypt.PerformLayout();
            this.tbcVigenere.ResumeLayout(false);
            this.tbpCryptanalyze.ResumeLayout(false);
            this.gbCryptanalyze.ResumeLayout(false);
            this.gbCryptanalyze.PerformLayout();
            this.gnAnalyseFrequencies.ResumeLayout(false);
            this.gnAnalyseFrequencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxKeyLength)).EndInit();
            this.gbFriedmanTest.ResumeLayout(false);
            this.gbFriedmanTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalyseFrequencyKeyLength)).EndInit();
            this.ResumeLayout(false);

        }

        private void TxtCiphertext_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabPage tbpEncryptDecrypt;
        private System.Windows.Forms.GroupBox gbEncryptDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblCiphertext;
        private System.Windows.Forms.TextBox txtCleartext;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.Label lblCleartext;
        private System.Windows.Forms.TabControl tbcVigenere;
        private System.Windows.Forms.ErrorProvider erpError;
        private System.Windows.Forms.TabPage tbpCryptanalyze;
        private System.Windows.Forms.GroupBox gbCryptanalyze;
        private System.Windows.Forms.ComboBox cbbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.GroupBox gbFriedmanTest;
        private System.Windows.Forms.Label lblMaxKeyLength;
        private System.Windows.Forms.NumericUpDown nudMaxKeyLength;
        private System.Windows.Forms.TextBox txtResultFriedman;
        private System.Windows.Forms.Label lblResultFriedman;
        private System.Windows.Forms.Button btnRunFriedman;
        private System.Windows.Forms.GroupBox gnAnalyseFrequencies;
        private System.Windows.Forms.Button btnAnalyseFrequency;
        private System.Windows.Forms.Label lblAnalyseFrequenciesKey;
        private System.Windows.Forms.TextBox txtAnalyseFrequenciesKey;
        private System.Windows.Forms.TextBox txtProbableKeyLength;
        private System.Windows.Forms.Label lblProbableKeyLength;
        private System.Windows.Forms.NumericUpDown nudAnalyseFrequencyKeyLength;
        private System.Windows.Forms.Label lblAnalyseFrequencyKeyLength;
    }
}

