using System;

namespace FontAdjustmentTask_6
{
    class Program
    {
        [Flags]
        public enum Fonts : byte
        {
            NotSelected = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            var font = Fonts.NotSelected;

            while (true)
            {
                Console.WriteLine("Current Font: " + font);
                Console.WriteLine("1: Bold");
                Console.WriteLine("2: Italic");
                Console.WriteLine("3: Underline");

                if(int.TryParse(Console.ReadLine(), out int selectedFont))
                {
                    switch (selectedFont)
                    {
                        case 1:
                            font ^= Fonts.Bold;
                            break;
                        case 2:
                            font ^= Fonts.Italic;
                            break;
                        case 3:
                            font ^= Fonts.Underline;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
        }
    }
}
