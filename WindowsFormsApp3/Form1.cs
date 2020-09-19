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
        
        public Form1()
        {
            InitializeComponent();
        }
       
        //************************************Метод Цезаря**********************************
       
       
        //Шифрование
        
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox_comment.Text = "Для шифрования требуется ввод двух ключей";
           
                int.TryParse(textBox_clean.Text, out int KeyNumber);
                if (textBox1.Text.Length >= 60)
                    throw new Exception("Длина ключевого слова слишком велика!");
                if (!(KeyNumber >= 0 && KeyNumber < 999999999))
                    throw new Exception("Не корректный ключевой сдвиг!");
                Caezar_Cipher caezar_Cipher = new Caezar_Cipher(textBox1.Text, KeyNumber, textBox2.Text);
                label1.Text = caezar_Cipher.Encode();
           
        }

        //********************************Афинный метод Цезаря**********************************
        private void Button2_Click(object sender, EventArgs e)
        {
                textBox_comment.Text = "Для шифрования требуется ввод двух численных ключей";
        }
            
        //********************************Двойной квадрат Уитстона**********************************
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox_comment.Text = "Для шифрования требуется ввод двух ключей";
        }
        //********************************Шифр двойной перестановки**********************************
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox_comment.Text = "Для шифрования требуется ввод двух ключей";
        }     
    }
}

