using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //////===============================
            Console.WriteLine('N');
            Console.WriteLine("\u004e"); //Unicode
            Console.WriteLine((char)78); //Ascii
            Console.ReadKey();
            //////===============================

            char letter;
            letter = 'N';
            letter = '1';
            letter = '!';
            //////===============================
            char letter1;
            char letter2 = new char();
            //////===============================
            char letter3 = 'N';
            Console.WriteLine(char.IsUpper(letter3));
            Console.ReadKey();
            //////===============================
            char letter4 = 'N';
            Console.WriteLine(char.IsDigit(letter4));
            Console.ReadKey();
            //////===============================
            char letter5 = 'N';
            Console.WriteLine(char.IsLetter(letter5));
            Console.ReadKey();
            //////===============================

            char letter6 = 'N';
            Console.WriteLine(char.IsPunctuation(letter6));
            Console.ReadKey();
            //////===============================
            char letter7 = 'n';
            Console.WriteLine(char.ToUpper(letter7));
            Console.ReadKey();
            //////===============================
            char letter8 = 'N';
            Console.WriteLine(char.ToLower(letter8));
            Console.ReadKey();
            //////===============================
            char chA = 'A';
            char ch1 = '1';
            string str = "test string";

            Console.WriteLine(chA.CompareTo('B'));          //-----------  Output: "-1" (meaning 'A' is 1 less than 'B')
            Console.WriteLine(chA.Equals('A'));             //-----------  Output: "True"
            Console.WriteLine(Char.GetNumericValue(ch1));   //-----------  Output: "1"
            Console.WriteLine(Char.IsControl('\t'));        //-----------  Output: "True"
            Console.WriteLine(Char.IsDigit(ch1));           //-----------  Output: "True"
            Console.WriteLine(Char.IsLetter(','));          //-----------  Output: "False"
            Console.WriteLine(Char.IsLower('u'));           //-----------  Output: "True"
            Console.WriteLine(Char.IsNumber(ch1));          //-----------  Output: "True"
            Console.WriteLine(Char.IsPunctuation('.'));     //-----------  Output: "True"
            Console.WriteLine(Char.IsSeparator(str, 4));    //-----------  Output: "True"
            Console.WriteLine(Char.IsSymbol('+'));          //-----------  Output: "True"
            Console.WriteLine(Char.IsWhiteSpace(str, 4));   //-----------  Output: "True"
            Console.WriteLine(Char.Parse("S"));             //-----------  Output: "S"
            Console.WriteLine(Char.ToLower('M'));           //-----------  Output: "m"
            Console.WriteLine('x'.ToString());              //-----------  Output: "x"


            //===================================

            // Define a string with a variety of character categories.
            String s = "11The red\t car drove down the long, 22narrow, secluded!\n road.";
            // Determine the category of each character.
            foreach (var ch in s)
                Console.WriteLine("'{0}': {1}", ch, Char.GetUnicodeCategory(ch));
           Console.ReadKey();

        }
    }
}
