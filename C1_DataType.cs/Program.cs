using System;
class DataType{


    public static void Main(string[] args){

        Console.WriteLine("Hello Nasr");

        int myInt = 9;
        double myDouble = myInt;       // Automatic casting: int to double

        Console.WriteLine(myInt);      // Outputs 9
        Console.WriteLine(myDouble);   // Outputs 9

        /*Explicit Casting

        Explicit casting must be done manually by placing the type in parentheses in 
        front of the value:*/


        double my_Double = 9.78;
        int my_Int = (int) myDouble;    // Manual casting: double to int

        Console.WriteLine(my_Double);   // Outputs 9.78
        Console.WriteLine(my_Int);      // Outputs 9

        /*Type Conversion Methods

        It is also possible to convert data types explicitly by using built-in methods, 
        such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):*/

        int my__Int = 10;
        double my__Double = 5.25;
        bool my__Bool = true;

        Console.WriteLine(Convert.ToString(my__Int));    // convert int to string
        Console.WriteLine(Convert.ToDouble(my__Int));    // convert int to double
        Console.WriteLine(Convert.ToInt32(my__Double));  // convert double to int
        Console.WriteLine(Convert.ToString(my__Bool));   // convert bool to string

        // int myInt = 10;
        // double myDouble = 5.25;
        // bool myBool = true;

        Console.WriteLine(Convert.ToString(my__Int));    // convert int to string
        Console.WriteLine(Convert.ToDouble(my__Int));    // convert int to double
        Console.WriteLine(Convert.ToInt32(my__Double));  // convert double to int
        Console.WriteLine(Convert.ToString(my__Bool));   // convert bool to string

        // Type your username and press enter
        Console.WriteLine("Enter username:");

        // Create a string variable and get user input from the keyboard and store it in the variable
        string userName = Console.ReadLine();

        // Print the value of the variable (userName), which will display the input value
        Console.WriteLine("Username is: " + userName);

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your name is " + userName);
        //Console.WriteLine($" your name is {username} and your age is {age} ");



        /*C# Type Casting

    Type casting is when you assign a value of one data type to another type.

    In C#, there are two types of casting:

    Implicit Casting (automatically) - converting a smaller type to a larger type size
    char -> int -> long -> float -> double

    Explicit Casting (manually) - converting a larger type to a smaller size type
    double -> float -> long -> int -> char

    Implicit Casting

    Implicit casting is done automatically when passing a smaller size type to a larger size type:*/


        // double num = 12.5;
        // int num2 = Convert.ToInt32(num);// will explicityly convert, some values will be trimmed
        // System.Console.WriteLine(num2);
        // System.Console.WriteLine(Convert.ToString(num));

        // to see where each type belong to, use the below.
        // System.Console.WriteLine(typeof(float));
        // System.Console.WriteLine(typeof(string));
        // System.Console.WriteLine(typeof(double));
        // System.Console.WriteLine(typeof(Boolean));

        // var num3 = "123";
        // var num4= Convert.ToInt32(num3);
        // System.Console.WriteLine(num3);

        var num6 = 123;
        var num7= num6.ToString();// convert int to string
        System.Console.WriteLine(num7);
        

    }

}