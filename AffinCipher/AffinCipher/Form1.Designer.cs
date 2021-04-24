
namespace AffinCipher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.TextBoxEncryption = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxDecryption = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericKeyB = new System.Windows.Forms.NumericUpDown();
            this.numericKeyA = new System.Windows.Forms.NumericUpDown();
            this.txtBoxSubsituitionAlphabet = new System.Windows.Forms.TextBox();
            this.txtBoxOrginalAlphabet = new System.Windows.Forms.TextBox();
            this.btnBuildSubsitutionAplhabet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TextBoxDecryptedText = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxCipherText = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxFilteredOT = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.TextBoxFilteredDecryptedText = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClearAllFields = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEncrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncrypt.Location = new System.Drawing.Point(163, 282);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(118, 53);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDecrypt.FlatAppearance.BorderSize = 2;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnDecrypt.Location = new System.Drawing.Point(497, 282);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(104, 53);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // TextBoxEncryption
            // 
            this.TextBoxEncryption.Location = new System.Drawing.Point(163, 191);
            this.TextBoxEncryption.Name = "TextBoxEncryption";
            this.TextBoxEncryption.Size = new System.Drawing.Size(141, 78);
            this.TextBoxEncryption.TabIndex = 2;
            this.TextBoxEncryption.Text = "";
            this.TextBoxEncryption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEncryption_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text To be Encrypted:";
            // 
            // TextBoxDecryption
            // 
            this.TextBoxDecryption.Location = new System.Drawing.Point(491, 189);
            this.TextBoxDecryption.Name = "TextBoxDecryption";
            this.TextBoxDecryption.Size = new System.Drawing.Size(141, 78);
            this.TextBoxDecryption.TabIndex = 4;
            this.TextBoxDecryption.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text to be Decrypted:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericKeyB);
            this.groupBox1.Controls.Add(this.numericKeyA);
            this.groupBox1.Controls.Add(this.txtBoxSubsituitionAlphabet);
            this.groupBox1.Controls.Add(this.txtBoxOrginalAlphabet);
            this.groupBox1.Controls.Add(this.btnBuildSubsitutionAplhabet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keys (COEFFICIENTS)";
            // 
            // numericKeyB
            // 
            this.numericKeyB.Location = new System.Drawing.Point(82, 67);
            this.numericKeyB.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.numericKeyB.Name = "numericKeyB";
            this.numericKeyB.Size = new System.Drawing.Size(100, 20);
            this.numericKeyB.TabIndex = 15;
            // 
            // numericKeyA
            // 
            this.numericKeyA.Location = new System.Drawing.Point(82, 30);
            this.numericKeyA.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericKeyA.Name = "numericKeyA";
            this.numericKeyA.Size = new System.Drawing.Size(100, 20);
            this.numericKeyA.TabIndex = 14;
            // 
            // txtBoxSubsituitionAlphabet
            // 
            this.txtBoxSubsituitionAlphabet.Location = new System.Drawing.Point(333, 74);
            this.txtBoxSubsituitionAlphabet.Name = "txtBoxSubsituitionAlphabet";
            this.txtBoxSubsituitionAlphabet.ReadOnly = true;
            this.txtBoxSubsituitionAlphabet.Size = new System.Drawing.Size(290, 20);
            this.txtBoxSubsituitionAlphabet.TabIndex = 8;
            // 
            // txtBoxOrginalAlphabet
            // 
            this.txtBoxOrginalAlphabet.Location = new System.Drawing.Point(333, 32);
            this.txtBoxOrginalAlphabet.Name = "txtBoxOrginalAlphabet";
            this.txtBoxOrginalAlphabet.ReadOnly = true;
            this.txtBoxOrginalAlphabet.Size = new System.Drawing.Size(290, 20);
            this.txtBoxOrginalAlphabet.TabIndex = 7;
            // 
            // btnBuildSubsitutionAplhabet
            // 
            this.btnBuildSubsitutionAplhabet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBuildSubsitutionAplhabet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuildSubsitutionAplhabet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildSubsitutionAplhabet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuildSubsitutionAplhabet.Location = new System.Drawing.Point(31, 95);
            this.btnBuildSubsitutionAplhabet.Name = "btnBuildSubsitutionAplhabet";
            this.btnBuildSubsitutionAplhabet.Size = new System.Drawing.Size(151, 27);
            this.btnBuildSubsitutionAplhabet.TabIndex = 6;
            this.btnBuildSubsitutionAplhabet.Text = "Build";
            this.btnBuildSubsitutionAplhabet.UseVisualStyleBackColor = false;
            this.btnBuildSubsitutionAplhabet.Click += new System.EventHandler(this.btnBuildSubsitutionAplhabet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "Subsitution Alphatbet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "Orginal Alphabet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "A:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(665, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-39, 492);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(852, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // TextBoxDecryptedText
            // 
            this.TextBoxDecryptedText.Location = new System.Drawing.Point(497, 356);
            this.TextBoxDecryptedText.Name = "TextBoxDecryptedText";
            this.TextBoxDecryptedText.ReadOnly = true;
            this.TextBoxDecryptedText.Size = new System.Drawing.Size(141, 78);
            this.TextBoxDecryptedText.TabIndex = 13;
            this.TextBoxDecryptedText.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Encrypted Text:";
            // 
            // TextBoxCipherText
            // 
            this.TextBoxCipherText.Location = new System.Drawing.Point(163, 452);
            this.TextBoxCipherText.Name = "TextBoxCipherText";
            this.TextBoxCipherText.ReadOnly = true;
            this.TextBoxCipherText.Size = new System.Drawing.Size(141, 78);
            this.TextBoxCipherText.TabIndex = 11;
            this.TextBoxCipherText.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(326, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Decrypted Text:";
            // 
            // TextBoxFilteredOT
            // 
            this.TextBoxFilteredOT.Location = new System.Drawing.Point(163, 356);
            this.TextBoxFilteredOT.Name = "TextBoxFilteredOT";
            this.TextBoxFilteredOT.ReadOnly = true;
            this.TextBoxFilteredOT.Size = new System.Drawing.Size(141, 78);
            this.TextBoxFilteredOT.TabIndex = 14;
            this.TextBoxFilteredOT.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Filtired OpenText(OT):";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(326, 456);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(168, 15);
            this.label.TabIndex = 16;
            this.label.Text = "Decrypted Text(Filtered):";
            // 
            // TextBoxFilteredDecryptedText
            // 
            this.TextBoxFilteredDecryptedText.Location = new System.Drawing.Point(497, 452);
            this.TextBoxFilteredDecryptedText.Name = "TextBoxFilteredDecryptedText";
            this.TextBoxFilteredDecryptedText.ReadOnly = true;
            this.TextBoxFilteredDecryptedText.Size = new System.Drawing.Size(141, 78);
            this.TextBoxFilteredDecryptedText.TabIndex = 17;
            this.TextBoxFilteredDecryptedText.Text = "";
            // 
            // btnClearAllFields
            // 
            this.btnClearAllFields.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClearAllFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearAllFields.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllFields.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearAllFields.Location = new System.Drawing.Point(271, 536);
            this.btnClearAllFields.Name = "btnClearAllFields";
            this.btnClearAllFields.Size = new System.Drawing.Size(245, 36);
            this.btnClearAllFields.TabIndex = 18;
            this.btnClearAllFields.Text = "Clear All Fields";
            this.btnClearAllFields.UseVisualStyleBackColor = false;
            this.btnClearAllFields.Click += new System.EventHandler(this.btnClearAllFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 638);
            this.Controls.Add(this.btnClearAllFields);
            this.Controls.Add(this.TextBoxFilteredDecryptedText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxFilteredOT);
            this.Controls.Add(this.TextBoxDecryptedText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxCipherText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxDecryption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxEncryption);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.Text = "AffinCipher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKeyA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.RichTextBox TextBoxEncryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextBoxDecryption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox TextBoxDecryptedText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox TextBoxCipherText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSubsituitionAlphabet;
        private System.Windows.Forms.TextBox txtBoxOrginalAlphabet;
        private System.Windows.Forms.Button btnBuildSubsitutionAplhabet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericKeyB;
        private System.Windows.Forms.NumericUpDown numericKeyA;
        private System.Windows.Forms.RichTextBox TextBoxFilteredOT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox TextBoxFilteredDecryptedText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClearAllFields;
    }
}

