using System;

namespace ValidatorTask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string... ");

            string str = Console.ReadLine();

            if(str != "")
            {
                char[] strToUp = str.ToCharArray();

                strToUp[0] = char.ToUpper(strToUp[0]);

                for(int i = 0; i < strToUp.Length - 1; i++)
                {
                    if(strToUp[i] == '.' || strToUp[i] == '?' || strToUp[i] == '!')
                    {
                        if(strToUp[i + 1] == ' ')
                        {
                            strToUp[i + 2] = char.ToUpper(strToUp[i + 2]);
                        }
                        else
                        {
                            strToUp[i + 1] = char.ToUpper(strToUp[i + 1]);
                        }
                    }
                }

                Console.WriteLine("Someone forgot about capital letters ;)");

                Console.WriteLine(strToUp);
            }
            else
            {
                Console.WriteLine("You have not entered anything!");
            }

            Console.ReadKey();
        }
    }
}
