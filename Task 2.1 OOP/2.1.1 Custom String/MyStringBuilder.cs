using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1_Custom_String
{
    class MyStringBuilder
    {
        char[] newString;

        public MyStringBuilder(char[] newString) => this.newString = newString;

        public MyStringBuilder(string newString) => this.newString = newString.ToCharArray();

        public bool StringComparison(string strForCompare)
        {
            char[] forCompare = strForCompare.ToCharArray();

            bool result = false;

            if (newString.Length == forCompare.Length)
            {
                for (int i = 0; i < newString.Length; i++)
                {
                    if (newString[i] == forCompare[i])
                        result = true;
                    else
                        return false;
                }
            }
            else
                result = false;

            return result;
        }

        public static MyStringBuilder operator + (MyStringBuilder firstStr, MyStringBuilder secondStr)
        {
            return new MyStringBuilder(firstStr.newString.Concat(secondStr.newString).ToArray());
        }

        public string MySearch(char searchChar)
        {
            string result = "";

            foreach (char el in newString)
            {
                if(searchChar == el)
                {
                    result = $"Символ {searchChar} был найден";
                    break;
                }
                else
                {
                    result = $"Символ {searchChar} не был найден";
                }
            }

            return result;
        }

        public string MyToString()
        {
            string str = new string(newString);
            return str;
        }

        public string MyToString(char [] ch)
        {
            string str = ch.ToString();
            return str;
        }

        public char[] MyToArray(string str)
        {
            char[] arrChars = str.ToCharArray();
            return arrChars;
        }
    }
}
