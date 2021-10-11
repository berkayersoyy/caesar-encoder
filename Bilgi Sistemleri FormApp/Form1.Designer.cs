
namespace Bilgi_Sistemleri_FormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radiobuttonEncrypt = new System.Windows.Forms.RadioButton();
            this.radiobuttonDecrypt = new System.Windows.Forms.RadioButton();
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelResultIndexer = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxInput
            // 
            this.txtboxInput.Location = new System.Drawing.Point(94, 71);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(172, 23);
            this.txtboxInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metin: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radiobuttonEncrypt
            // 
            this.radiobuttonEncrypt.AutoSize = true;
            this.radiobuttonEncrypt.Location = new System.Drawing.Point(81, 142);
            this.radiobuttonEncrypt.Name = "radiobuttonEncrypt";
            this.radiobuttonEncrypt.Size = new System.Drawing.Size(57, 19);
            this.radiobuttonEncrypt.TabIndex = 2;
            this.radiobuttonEncrypt.TabStop = true;
            this.radiobuttonEncrypt.Text = "Şifrele";
            this.radiobuttonEncrypt.UseVisualStyleBackColor = true;
            this.radiobuttonEncrypt.CheckedChanged += new System.EventHandler(this.radiobuttonEncrypt_CheckedChanged);
            // 
            // radiobuttonDecrypt
            // 
            this.radiobuttonDecrypt.AutoSize = true;
            this.radiobuttonDecrypt.Location = new System.Drawing.Point(209, 142);
            this.radiobuttonDecrypt.Name = "radiobuttonDecrypt";
            this.radiobuttonDecrypt.Size = new System.Drawing.Size(71, 19);
            this.radiobuttonDecrypt.TabIndex = 2;
            this.radiobuttonDecrypt.TabStop = true;
            this.radiobuttonDecrypt.Text = "Şifre Çöz";
            this.radiobuttonDecrypt.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(134, 193);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "ÇALIŞTIR";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelResultIndexer
            // 
            this.labelResultIndexer.AutoSize = true;
            this.labelResultIndexer.Location = new System.Drawing.Point(44, 19);
            this.labelResultIndexer.Name = "labelResultIndexer";
            this.labelResultIndexer.Size = new System.Drawing.Size(46, 15);
            this.labelResultIndexer.TabIndex = 4;
            this.labelResultIndexer.Text = "Sonuç: ";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(96, 19);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 5;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.BackgroundImage = global::Bilgi_Sistemleri_FormApp.Properties.Resources.icons8_copy_24;
            this.buttonCopy.FlatAppearance.BorderSize = 0;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCopy.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCopy.Location = new System.Drawing.Point(13, 14);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(25, 25);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 258);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelResultIndexer);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.radiobuttonDecrypt);
            this.Controls.Add(this.radiobuttonEncrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radiobuttonEncrypt;
        private System.Windows.Forms.RadioButton radiobuttonDecrypt;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelResultIndexer;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCopy;
    }
}

