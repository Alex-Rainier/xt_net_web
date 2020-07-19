using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._2_Super_String
{
    public static class ExtensionString
    {
        public static string Language(this string str)
        {
            string ru = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string en = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string num = "0123456789";

            string language = str.ToUpper();

            if(language.All(el => ru.Contains(el)))
            {
                return "Эта строка на русском языке";
            }
            else if(language.All(el => en.Contains(el)))
            {
                return "This string is in English";
            }
            else if(language.All(el => num.Contains(el)))
            {
                return "Эта строка содержит числа";
            }
            else
            {
                return "Это смешанная строка";
            }
        }
    }
}
