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
            this.label_type = new System.Windows.Forms.Label();
            this.textBox_clean = new System.Windows.Forms.TextBox();
            this.label_text_for_cipher = new System.Windows.Forms.Label();
            this.label_ciphered_text = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_key = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(105, 1);
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
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(309, 17);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.ReadOnly = true;
            this.textBox_comment.Size = new System.Drawing.Size(254, 112);
            this.textBox_comment.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(397, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 216);
            this.label1.TabIndex = 6;
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Location = new System.Drawing.Point(1, 161);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(102, 15);
            this.label_key.TabIndex = 7;
            this.label_key.Text = "Ключевое слово:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "3ашифровать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(490, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Шифр Цезаря";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(660, 35);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "3ашифровать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "3ашифровать";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 38);
            this.button4.TabIndex = 9;
            this.button4.Text = "3ашифровать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(205, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "Расшифровать";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(205, 85);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 38);
            this.button6.TabIndex = 9;
            this.button6.Text = "Расшифровать";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(205, 52);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 38);
            this.button9.TabIndex = 9;
            this.button9.Text = "Расшифровать";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(205, 17);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(98, 38);
            this.button10.TabIndex = 9;
            this.button10.Text = "Расшифровать";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(96, 85);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(112, 38);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Двойной квадрат         Уинтстона";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(96, 120);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(112, 38);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Шифр  Двойной            3амены";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(96, 52);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(112, 38);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "      Афинный            Шифр Цезаря";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 17);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(112, 38);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Шифр Цезаря";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_comment);
            this.Controls.Add(this.label_ciphered_text);
            this.Controls.Add(this.label_text_for_cipher);
            this.Controls.Add(this.textBox_clean);
            this.Controls.Add(this.label_type);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox textBox_clean;
        private System.Windows.Forms.Label label_text_for_cipher;
        private System.Windows.Forms.Label label_ciphered_text;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
    }
}

