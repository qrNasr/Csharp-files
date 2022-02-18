﻿using System;
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



        /*C# Type Casting

Type casting is when you assign a value of one data type to another type.

In C#, there are two types of casting:

    Implicit Casting (automatically) - converting a smaller type to a larger type size
    char -> int -> long -> float -> double

    Explicit Casting (manually) - converting a larger type to a smaller size type
    double -> float -> long -> int -> char

Implicit Casting

Implicit casting is done automatically when passing a smaller size type to a larger size type:*/

    }
}