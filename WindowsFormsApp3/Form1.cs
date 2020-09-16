using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private byte Switch_Status;
        public Form1()
        {
            InitializeComponent();
        }
        //************************************Метод Цезаря**********************************

        private void radioButton_caezar_cipher_CheckedChanged(object sender, EventArgs e)
        {
                if (radioButton_caezar_cipher.Checked)
                {
                    textBox_comment.Text = "Для шифрования требуется ввод ключа сдвига и ввод ключевой фразы";
                }
                else
                {
                    textBox_comment.Text = "";
                }
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    Switch_Status = 1;
                }
        }
        //Шифрование
        private void Caezar_Cipher()
        {
            try
            {
                int.TryParse(textBox_clean.Text, out int KeyNumber);
                if (textBox1.Text.Length >= 60)
                    throw new Exception("Длина ключевого слова слишком велика!");
                if (!(KeyNumber >= 0 && KeyNumber < 999999999))
                    throw new Exception("Не корректный ключевой сдвиг!");
                Caezar_Cipher caezar_Cipher = new Caezar_Cipher(textBox1.Text, KeyNumber, textBox1.Text);
                label1.Text = caezar_Cipher.Encode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //********************************Афинный метод Цезаря**********************************
        private void radioButton_afin_caezar_cipher_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_afin_caezar_cipher.Checked)
            {
                textBox_comment.Text = "Для шифрования требуется ввод двух численных ключей";
            }
            else
            {
                textBox_comment.Text = "";
            }
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Switch_Status = 2;
            }
        }
        //********************************Двойной квадрат Уитстона**********************************
        private void radioButton_witston_cipher_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_witston_cipher.Checked)
            {
                textBox_comment.Text = "Для шифрования требуется ввод двух ключей";
            }
            else
            {
                textBox_comment.Text = "";
            }
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Switch_Status = 3;
            }
        }
        //********************************Шифр двойной перестановки**********************************
        private void radioButton_double_exchange_cipher_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_double_exchange_cipher.Checked)
            {
                textBox_comment.Text = "Для шифрования требуется ввод двух ключей";
            }
            else
            {
                textBox_comment.Text = "";
            }
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Switch_Status = 4;
            }
        }

    }
}
