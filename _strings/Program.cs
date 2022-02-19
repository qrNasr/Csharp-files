using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace ConsoleApplication4

{

    class Program

    {

        static void Main(string[] args)

        {

            //String Length

            //string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            //            Console.WriteLine("The length of the txt string is: " + txt.Length);

            //string txt = "Hello World";

            //Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"

            //Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            //string firstName = "badie ";

            //string lastName = "mousa";

            //string name = firstName + lastName;

            //Console.WriteLine(name);

            //string firstName = "mona ";

            //string lastName = "aly";

            //string name = string.Concat(firstName, lastName);

            //Console.WriteLine(name);

            //string firstName = "badie";

            //string lastName = "mousa";

            //string name = $"My full name is: {firstName} {lastName}";

            //Console.WriteLine(name);

            //string myString = "Hello";

            //Console.WriteLine(myString[0]);  // Outputs "H"

            //Console.WriteLine(myString[1]);  // Outputs "e"

            //Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"

            //// Full name

            //string name = "John Doe";

            //// Location of the letter D

            //int charPos = name.IndexOf("D");

            //// Get last name

            //string lastName = name.Substring(charPos);

            //// Print the result

            //Console.WriteLine(lastName); //output Doe

            //string txt = "We are the so-called \"Vikings\" from the north.";

            //Console.WriteLine(txt);

            //string txt = "It\'s alright.";

            //Console.WriteLine(txt);

            //string txt = "The character \\ is called backslash.";

            //string a = "hello";

            //string b = "h";

            //b += "ello";

            //Console.WriteLine(a == b);//true

            //Console.WriteLine((object)a == (object)b);  //false

            //Console.ReadKey();

            ////=============================

            //string word1;

            //word1 = "This is a simple string";

            ////=============================

            //string word;

            //word = "This is a simple string\n This is other line";

            //Console.WriteLine(word);

            //Console.ReadKey();

            ////======================

            //string path;

            ////path = "d:\\my files\\e.txt";

            //path = @"d:\my files\e.txt";

            //Console.WriteLine(path);

            //Console.ReadKey();

            ////================

            //string s = "Hasan";

            ////  -للحصول على عدد أحرف عبارة نصية استخدم التابع

            //Console.WriteLine(s.Count()); // Prints 5

            //                          //:Last و First - للحصول على أول وآخر حرف استخدم التابعين

            //Console.WriteLine(s.First()); // Prints H

            //Console.WriteLine(s.Last()); // Prints n

            //                         //:Insert - لإضافة أحرف إلى عبارة نصية استخدم التابع

            //Console.WriteLine(s.Insert(2, "ppss")); // Prints Hasssan

            ////  ToLower - لتصغير جميع أحرف عبارة نصية أو تكبيرها استخدم التابعين

            ////:ToUpper و

            //Console.WriteLine(s.ToLower()); // Prints hasan

            //Console.WriteLine(s.ToUpper()); // Prints HASAN

            //                            //    -لمعرفة فيما إذا كان محتوى المتغير يحوي قيمة نصية معينة:

            //bool b = s.Contains("s"); //True

            //Console.WriteLine(b);

            //int i = s.IndexOf("s"); //2

            //Console.WriteLine( i);               //  -بإمكانك استبدال قيمة نصية ضمن قيمة نصية أخرى:

            //string s2 = s.Replace("n", "N"); //s2 = HasaN

            //                                 // كما يمكن الاستفادة من الاستبدال وذلك لإزالة قيم نصية محددة ضمن

            //                                 //قيمة نصية أخرى:

            //Console.WriteLine(s2);

            //string s21 = s.Replace("n", string.Empty); //s2 = Hasa

            //Console.WriteLine(s21);                                       //  -لإزالة الفراغات التي لا طعمة لها:

            //s += " ";

            //string s22 = s.Trim(); //s2 = Hasan

            //Console.WriteLine(s22);

            //Console.ReadKey();


            Console.WriteLine("{0:c}", 27.1); //27.1 $
            Console.WriteLine("{0:d1}", 27); //27
            Console.WriteLine("{0:d5}", 27); //00027
            Console.WriteLine("{0:e}", 2700); //2.700000e +003
            Console.WriteLine("{0:f2}", 27); //27
            Console.WriteLine("{0:f3}", 27); //27.000
            Console.WriteLine("{0:g}", 2.7); //2.7
            Console.WriteLine("{0:n}", 2700); //2,700.00
            Console.WriteLine("{0:x}", 27); //1b
            Console.ReadKey();
        }

    }

}

