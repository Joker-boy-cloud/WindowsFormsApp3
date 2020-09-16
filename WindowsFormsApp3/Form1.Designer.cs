namespace WindowsFormsApp3
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
            this.radioButton_caezar_cipher = new System.Windows.Forms.RadioButton();
            this.radioButton_afin_caezar_cipher = new System.Windows.Forms.RadioButton();
            this.radioButton_witston_cipher = new System.Windows.Forms.RadioButton();
            this.radioButton_double_exchange_cipher = new System.Windows.Forms.RadioButton();
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_clean = new System.Windows.Forms.TextBox();
            this.label_text_for_cipher = new System.Windows.Forms.Label();
            this.label_ciphered_text = new System.Windows.Forms.Label();
            this.textBox_ciphered = new System.Windows.Forms.TextBox();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton_caezar_cipher
            // 
            this.radioButton_caezar_cipher.AutoSize = true;
            this.radioButton_caezar_cipher.Location = new System.Drawing.Point(12, 35);
            this.radioButton_caezar_cipher.Name = "radioButton_caezar_cipher";
            this.radioButton_caezar_cipher.Size = new System.Drawing.Size(101, 19);
            this.radioButton_caezar_cipher.TabIndex = 0;
            this.radioButton_caezar_cipher.TabStop = true;
            this.radioButton_caezar_cipher.Text = "Шифр Цезаря";
            this.radioButton_caezar_cipher.UseVisualStyleBackColor = true;
            this.radioButton_caezar_cipher.CheckedChanged += new System.EventHandler(this.radioButton_caezar_cipher_CheckedChanged);
            // 
            // radioButton_afin_caezar_cipher
            // 
            this.radioButton_afin_caezar_cipher.AutoSize = true;
            this.radioButton_afin_caezar_cipher.Location = new System.Drawing.Point(12, 60);
            this.radioButton_afin_caezar_cipher.Name = "radioButton_afin_caezar_cipher";
            this.radioButton_afin_caezar_cipher.Size = new System.Drawing.Size(166, 19);
            this.radioButton_afin_caezar_cipher.TabIndex = 0;
            this.radioButton_afin_caezar_cipher.TabStop = true;
            this.radioButton_afin_caezar_cipher.Text = "Шифр Цезаря - Афинный";
            this.radioButton_afin_caezar_cipher.UseVisualStyleBackColor = true;
            this.radioButton_afin_caezar_cipher.CheckedChanged += new System.EventHandler(this.radioButton_afin_caezar_cipher_CheckedChanged);
            // 
            // radioButton_witston_cipher
            // 
            this.radioButton_witston_cipher.AutoSize = true;
            this.radioButton_witston_cipher.Location = new System.Drawing.Point(12, 85);
            this.radioButton_witston_cipher.Name = "radioButton_witston_cipher";
            this.radioButton_witston_cipher.Size = new System.Drawing.Size(112, 19);
            this.radioButton_witston_cipher.TabIndex = 0;
            this.radioButton_witston_cipher.TabStop = true;
            this.radioButton_witston_cipher.Text = "Шифр Уитстона";
            this.radioButton_witston_cipher.UseVisualStyleBackColor = true;
            this.radioButton_witston_cipher.CheckedChanged += new System.EventHandler(this.radioButton_witston_cipher_CheckedChanged);
            // 
            // radioButton_double_exchange_cipher
            // 
            this.radioButton_double_exchange_cipher.AutoSize = true;
            this.radioButton_double_exchange_cipher.Location = new System.Drawing.Point(12, 110);
            this.radioButton_double_exchange_cipher.Name = "radioButton_double_exchange_cipher";
            this.radioButton_double_exchange_cipher.Size = new System.Drawing.Size(154, 19);
            this.radioButton_double_exchange_cipher.TabIndex = 0;
            this.radioButton_double_exchange_cipher.TabStop = true;
            this.radioButton_double_exchange_cipher.Text = "Шифр двойной замены";
            this.radioButton_double_exchange_cipher.UseVisualStyleBackColor = true;
            this.radioButton_double_exchange_cipher.CheckedChanged += new System.EventHandler(this.radioButton_double_exchange_cipher_CheckedChanged);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(12, 17);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(76, 15);
            this.label_type.TabIndex = 1;
            this.label_type.Text = "Тип шифра: ";
            // 
            // textBox_clean
            // 
            this.textBox_clean.Location = new System.Drawing.Point(1, 233);
            this.textBox_clean.Multiline = true;
            this.textBox_clean.Name = "textBox_clean";
            this.textBox_clean.Size = new System.Drawing.Size(398, 216);
            this.textBox_clean.TabIndex = 2;
            // 
            // label_text_for_cipher
            // 
            this.label_text_for_cipher.AutoSize = true;
            this.label_text_for_cipher.Location = new System.Drawing.Point(1, 215);
            this.label_text_for_cipher.Name = "label_text_for_cipher";
            this.label_text_for_cipher.Size = new System.Drawing.Size(137, 15);
            this.label_text_for_cipher.TabIndex = 3;
            this.label_text_for_cipher.Text = "Текст для шифрования:";
            // 
            // label_ciphered_text
            // 
            this.label_ciphered_text.AutoSize = true;
            this.label_ciphered_text.Location = new System.Drawing.Point(397, 215);
            this.label_ciphered_text.Name = "label_ciphered_text";
            this.label_ciphered_text.Size = new System.Drawing.Size(134, 15);
            this.label_ciphered_text.TabIndex = 3;
            this.label_ciphered_text.Text = "Зашифрованный текст";
            // 
            // textBox_ciphered
            // 
            this.textBox_ciphered.Location = new System.Drawing.Point(397, 233);
            this.textBox_ciphered.Multiline = true;
            this.textBox_ciphered.Name = "textBox_ciphered";
            this.textBox_ciphered.Size = new System.Drawing.Size(401, 216);
            this.textBox_ciphered.TabIndex = 2;
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(184, 17);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.ReadOnly = true;
            this.textBox_comment.Size = new System.Drawing.Size(254, 112);
            this.textBox_comment.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(12, 132);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(102, 15);
            this.label_key.TabIndex = 7;
            this.label_key.Text = "Ключевое слово:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_ciphered_text);
            this.Controls.Add(this.label_text_for_cipher);
            this.Controls.Add(this.textBox_ciphered);
            this.Controls.Add(this.textBox_clean);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.radioButton_double_exchange_cipher);
            this.Controls.Add(this.radioButton_witston_cipher);
            this.Controls.Add(this.radioButton_afin_caezar_cipher);
            this.Controls.Add(this.radioButton_caezar_cipher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_caezar_cipher;
        private System.Windows.Forms.RadioButton radioButton_afin_caezar_cipher;
        private System.Windows.Forms.RadioButton radioButton_witston_cipher;
        private System.Windows.Forms.RadioButton radioButton_double_exchange_cipher;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox textBox_clean;
        private System.Windows.Forms.Label label_text_for_cipher;
        private System.Windows.Forms.Label label_ciphered_text;
        private System.Windows.Forms.TextBox textBox_ciphered;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.TextBox textBox1;
    }
}

