using System.Text;
using System;
class ManyMethodes{

public static void Main(string[] args) {
    
int num =123;
int num2 = 456;

System.Console.WriteLine(int.Equals(num,num2));
System.Console.WriteLine(int.MaxValue);
System.Console.WriteLine($"int max value is {Int32.MaxValue}");

float flt =12.5f;
System.Console.WriteLine(float.IsNaN(flt));
//System.Console.WriteLine(float.Equals(flt));
System.Console.WriteLine(float.IsFinite(flt));
System.Console.WriteLine(float.IsNegative(flt));
System.Console.WriteLine($" float max value is {float.MaxValue}");
System.Console.WriteLine($" float min value is {float.MinValue}");

double d = 1345.55;
System.Console.WriteLine(double.NaN);
System.Console.WriteLine(double.IsFinite(d));
System.Console.WriteLine(double.IsNegativeInfinity(d));
System.Console.WriteLine(double.IsNormal(d));
System.Console.WriteLine(double.IsPositiveInfinity(d));
System.Console.WriteLine(double.IsFinite(d));
System.Console.WriteLine(double.Epsilon);
System.Console.WriteLine(double.MaxValue);
System.Console.WriteLine(double.MinValue);
//System.Console.WriteLine(double.ReferenceEquals(d));;

string s0 =" ";
string s = "Nasr";
string s2 = "Henidaa";
string s3 ="Elznaty";
string s4="";

System.Console.WriteLine(string.Compare(s, s2));
System.Console.WriteLine(string.Join(',',s,s2));
System.Console.WriteLine(string.Concat(s,s0,s2,s0,s3));
System.Console.WriteLine(string.GetHashCode(s3));
System.Console.WriteLine(string.IsNullOrEmpty(s3));
System.Console.WriteLine(string.IsNullOrEmpty(s4));
System.Console.WriteLine(string.Intern(s3));
System.Console.WriteLine(string.CompareOrdinal(s2,s3));
System.Console.WriteLine(String.IsNullOrWhiteSpace(s0));


decimal a = 1.0m;
decimal b = 2.1m;
Console.WriteLine(a+b);
Console.WriteLine((decimal)a + b);
System.Console.WriteLine(decimal.Ceiling(a));
System.Console.WriteLine(decimal.Compare(a,b));
System.Console.WriteLine(decimal.Divide(b,a));
System.Console.WriteLine(decimal.Equals(a,b));
System.Console.WriteLine(decimal.Floor(a));
System.Console.WriteLine(decimal.MaxValue);
System.Console.WriteLine(decimal.MinValue);
System.Console.WriteLine(decimal.Multiply(a,b));
System.Console.WriteLine(decimal.Negate(a));
System.Console.WriteLine(decimal.Add(a,b));
System.Console.WriteLine(decimal.Remainder(a,b));
System.Console.WriteLine(decimal.Round(a));
System.Console.WriteLine(decimal.ToByte(a));
System.Console.WriteLine(decimal.ToDouble(b));
System.Console.WriteLine(decimal.ToInt16(a));
System.Console.WriteLine(decimal.ToSByte(a));
System.Console.WriteLine(decimal.ToSingle(a));
System.Console.WriteLine(decimal.Truncate(b));

// String methodes

string someText ="Hello Nasr";
String greet = "Nice to see you !";

System.Console.WriteLine(someText.CompareTo(greet));
System.Console.WriteLine(someText.Contains("N"));
System.Console.WriteLine(someText.EndsWith("r"));
System.Console.WriteLine(someText.Equals(greet));
System.Console.WriteLine(someText.GetHashCode());
System.Console.WriteLine(someText.GetType());
System.Console.WriteLine(someText.IndexOf("N"));
System.Console.WriteLine(someText.Length);
System.Console.WriteLine(someText.Remove(3));// remove first three chars
System.Console.WriteLine(someText.Remove(7));
System.Console.WriteLine(someText.Normalize());
System.Console.WriteLine(someText.Replace("N","K"));
//System.Console.WriteLine(someText.Split("/",3));
System.Console.WriteLine(someText.Substring(3));
System.Console.WriteLine(someText.ToCharArray());
System.Console.WriteLine(someText.ToLower());
System.Console.WriteLine(someText.ToUpper());
//System.Console.WriteLine(string.CopyTo


// create an object string from string class
StringBuilder txt2 = new StringBuilder();
System.Console.WriteLine(txt2.Append("Nasr"));


// int methodes
int mat = -12;
System.Console.WriteLine(Math.Cbrt(mat));//cube root
System.Console.WriteLine(Math.Abs(mat));
System.Console.WriteLine(Math.Abs(mat));
//System.Console.WriteLine(Math.Ceiling());// only takes decimal value
System.Console.WriteLine(Math.Exp(mat));//Returns e raised to the specified power.
//System.Console.WriteLine(Math.);
System.Console.WriteLine(Convert.ToInt16(mat));
System.Console.WriteLine(Convert.ToString(mat));
System.Console.WriteLine(Convert.ToBoolean(mat));
System.Console.WriteLine(Convert.ToDecimal(mat));
System.Console.WriteLine(Convert.ToDouble(mat));

/*

float x = 77.5f;
            float x1 = (float)77.5;
            Double y = 77.999;


            //int myInt = 9;
            //double myDouble = myInt;       // Automatic casting: int to double

            //Console.WriteLine(myInt);      // Outputs 9
            //Console.WriteLine(myDouble);   // Outputs 9



            //double myDouble = 9.78;
            //int myInt = (int)myDouble;    // Manual casting: double to int

            //Console.WriteLine(myDouble);   // Outputs 9.78
            //Console.WriteLine(myInt);      // Outputs 9


            //int myInt = 10;
            //double myDouble = 5.25;
            //bool myBool = true;

            //Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            //Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            //Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            //Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


            //string s = Console.ReadLine();
            //int i = Convert.ToInt32(s); // convert to int
            //long l = Convert.ToInt64(s); // convert to long
            //float f = Convert.ToSingle(s); // convert to float
            //double d = Convert.ToDouble(s); // convert to double
            //decimal c = Convert.ToDecimal(s); // convert to decimal


            string s = Console.ReadLine();
            long A = Int64.Parse(s); // convert to long
            float A1 = float.Parse(s); // convert to float
            decimal A2 = decimal.Parse(s); // convert to decimal
            double A3 = double.Parse(s); // convert to double
            int A4 = int.Parse(s); // convert to int
            
            */
}
}