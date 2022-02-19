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

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                       Console.WriteLine("The length of the txt string is: " + txt.Length);

            string txt2 = "Hello World";
            Console.WriteLine(txt2.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt2.ToLower());   // Outputs "hello world"


            string firstName = "badie ";
            string lastName = "mousa";
            string name = firstName + lastName;
            Console.WriteLine(name);


            string firs_tName = "mona ";
            string last_Name = "aly";
            string name_= string.Concat(firstName, lastName);
            Console.WriteLine(name);


            // string first__Name = "badie";
            // string last__Name = "mousa";
            // string name__ = $"My full name is: {firstName} {lastName}";
            // Console.WriteLine(name);


            // string myString = "Hello";
            // Console.WriteLine(myString[0]);  // Outputs "H"
            // Console.WriteLine(myString[1]);  // Outputs "e"
            // Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"


            // Full name
            // string name = "John Doe";

            // // Location of the letter D
            // int charPos = name.IndexOf("D");

            // // Get last name
            // string lastName = name.Substring(charPos);

            // // Print the result
            // Console.WriteLine(lastName); //output Doe 


            // string txt = "We are the so-called \"Vikings\" from the north.";
            // Console.WriteLine(txt);


            // string txt = "It\'s alright.";
            // Console.WriteLine(txt);

            // string txt = "The character \\ is called backslash.";



            string a = "hello";
            string b = "h";
            b += "ello";
            Console.WriteLine(a == b);//true
            Console.WriteLine((object)a == (object)b);  //false
            Console.ReadKey();





        }
    }
}
