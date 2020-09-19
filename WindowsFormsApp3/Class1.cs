using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace WindowsFormsApp3
{
    class Caezar_Cipher
    {
        private static string Alphabet="АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯяAaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuWwVvXxYyZz";
		private int Shift;//Числовой ключ сдвига
		private string key_word, enter;//Ключевое слово и ввод
		private string encode, uncode;
		
		public Caezar_Cipher(string key_word, int Shift = 0, string enter = "")
        {
			this.key_word = key_word;
			this.Shift = Shift;
			this.enter = enter;
		}
		private string Output()
        {
			char[] New_Alphabet = Alphabet.ToCharArray();//Создание резервного массива символов алфавита
			key_word = new string(key_word.Distinct().ToArray()).Replace(" ", "");//Удаление повторяющихся символов
			Shift %= New_Alphabet.Length;
			for (int Index = 0,  num = 0; num < New_Alphabet.Length; num++)
			{
				if (Index != key_word.Length)//Запись Слова в Алфавит, последний символ Слова завершает слияние
				{
					if (Shift == New_Alphabet.Length)
					{
						Shift = 0;
					}
					New_Alphabet[Shift] = key_word[Index];
					Shift++; Index++;
				}
			}
			string Lost_ABC = Alphabet;
			for (int num = 0; num < key_word.Length; num++)//Алфавит без Ключевого слова
			{
				Lost_ABC = Lost_ABC.Replace(key_word[num].ToString(), "");
			}

			for (int num = 0, _num = 0; num < New_Alphabet.Length && _num < Lost_ABC.Length; num++, _num++)
			{
				if (Shift == New_Alphabet.Length)
				{
					Shift = 0;
				}
				New_Alphabet[Shift++] = New_Alphabet[_num];
			}
			return new string(New_Alphabet);
		}
		public string Encode()//Шифрование
		{
			string Cipher = Output();
			for (int num = 0; num < enter.Length; num++)
			{
				int INDEX = Alphabet.IndexOf(enter[num]);
				encode += (INDEX != -1) ? Cipher[INDEX] : enter[num];
			}
			return encode;
		}
		public string Decode()//Дешифрование
		{
			string Cipher = Encode();
			for (int num = 0; num < enter.Length; num++)
			{
				int INDEX = Cipher.IndexOf(enter[num]);
				uncode += (INDEX != -1) ? Alphabet[INDEX] : enter[num];
			}
			return uncode;
		}


	}
}
