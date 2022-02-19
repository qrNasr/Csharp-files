class Hassouna
{

    public static void Main(string[] arg)
    {

        System.Console.WriteLine("{0},{1},{2}", 1, 2, 3);
        System.Console.WriteLine(System.DateTime.Now);
        System.Console.WriteLine("Amount is: {0:c1}", 99.99f);// c for currency
        System.Console.WriteLine("Amount is: {0:c3}", 99.99f);
        System.Console.WriteLine("Amount is: {0:c5}", 99.99f);
        System.Console.WriteLine("{0:d}", System.DateTime.Now);// date
        System.Console.WriteLine("{0:t}", System.DateTime.Now);//time
        System.Console.WriteLine("{0:t}", System.DateTime.Now);
        System.Console.WriteLine("{0}", System.DateTime.Now);
        System.Console.WriteLine("{0:dd}", System.DateTime.Now);
        System.Console.WriteLine("{0:mm}", System.DateTime.Now);
        System.Console.WriteLine("{0:yyyy}", System.DateTime.Now);
        System.Console.WriteLine("{0:yy}", System.DateTime.Now);
        System.Console.WriteLine("{0:hh}", System.DateTime.Now);
        System.Console.WriteLine("{0:mm}", System.DateTime.Now);
        System.Console.WriteLine("{0:ss}", System.DateTime.Now);
        System.Console.WriteLine("{0:tt}", System.DateTime.Now);
        System.Console.WriteLine(System.DateTime.DaysInMonth(12, 12));
        System.Console.WriteLine(System.DateTime.IsLeapYear(2025));
        System.Console.WriteLine("{0:n}", 1000000);
        System.Console.WriteLine("{0:N0}", 1000000);
        System.Console.WriteLine("{0:N5}", 1000000); // five digits
        System.Console.WriteLine("{0:g}: {0:x}", 255);
        System.Console.WriteLine(string.Concat("Hello", " ", "Nasr"));//string concat
        System.Console.WriteLine(string.Concat("Hello", " ", "Nasr ", 2, true));
        // arithmetics

        System.Console.WriteLine(7 / 3f); //7 divide float 3
        System.Console.WriteLine(7 % 3);
        //Decimal is a class , Float is a class and all capital letters are classes

        //String variables in one go
        string name1 = "Mona", name2 = "nasr", name3 = "omar";
        System.Console.WriteLine(name1 + " " + name2 + " " + name3);

        long BigNumber = 777_000_000_999_333;
        System.Console.WriteLine(BigNumber.ToString("#,#"));//# means number

        int x = 0;
        System.Console.WriteLine(x);
        x++;
        System.Console.WriteLine(x);
        ++x;
        System.Console.WriteLine(x);
        x--;
        System.Console.WriteLine(x);
        --x;

        // post fix increment
        int k = 5;
        int m = k++;
        System.Console.WriteLine("m=" + m);
        System.Console.WriteLine("k=" + k);

        // pre fix increment
        int now = 5;
        int later = ++now;
        System.Console.WriteLine("later=" + later);
        System.Console.WriteLine("now=" + now);

        // String Format

        string str = string.Format("{0}", 5);// visit Microsoft
        System.Console.WriteLine(str);
        string str2 = string.Format("{0,15:E3}{0,15:e5}", 333.555555);
        System.Console.WriteLine(str2);
        string str3 = string.Format("{0,-10}{1,-10}\n", "ID", "Name");
        System.Console.WriteLine(str3);
        string str4 = string.Format("{0,-10}{1,-10}\n", "--", "----");
        System.Console.WriteLine(str4);
        string str5 = string.Format("{0,-10}{1,-10}\n", "11", "Omar");
        System.Console.WriteLine(str5);
        string str6 = string.Format("{0,-10}{1,-10}\n", "22", "Nasr");
        System.Console.WriteLine(str6);
        string str7 = string.Format("{0,-10}{1,-10}\n", "33", "Mona");
        System.Console.WriteLine(str7);

        // add string

        string str10 = string.Format("{0,-10}{1,-10}\n", "ID", "Name");
        str10 += str7;
        System.Console.WriteLine(str10.GetType().Name);// get variable type
        System.Console.WriteLine(str10.GetType().Attributes);
        System.Console.WriteLine(str10.GetType().GetHashCode);
        System.Console.WriteLine("z".GetType().Name);
        System.Console.WriteLine("Nasr".GetType().Name);
        System.Console.WriteLine(9999999L.GetType().Name);
        System.Console.WriteLine(999999999999999F.GetType().Name);//single
        System.Console.WriteLine(99u.GetType().Name);//uint

        // Data type size:
        // var v01 ="byte " + byte.MaxValue+ ":" + byte.MaxValue;
        // var v02 ="sbyte " + sbyte.MaxValue+ ":" + sbyte.MaxValue;
        // var v03 ="short " + short.MaxValue+ ":" + short.MaxValue;
        // var v04 ="ushort " + ushort.MaxValue+ ":" + ushort.MaxValue;
        // // int,uint,long,float,double,decimal,char
        // System.Console.WriteLine(v01);
        // System.Console.WriteLine(v02);
        // System.Console.WriteLine(v03);
        // System.Console.WriteLine(v04);

        var v01 = "size of byte " + sizeof(byte);
        var v02 = "size of sbyte " + sizeof(sbyte);
        var v03 = "size of short " + sizeof(short);
        var v04 = "size of ushort " + sizeof(ushort);
        // int,uint,long,float,double,decimal,char
        System.Console.WriteLine(v01);
        System.Console.WriteLine(v02);
        System.Console.WriteLine(v03);
        System.Console.WriteLine(v04);

        // MultiLine String
        //string st = @"";

        // String interpolation
        string nam7 = "Nasr";
        System.Console.WriteLine($"Hello {nam7}");

        // Arrays single dimiension

        int[] numbers = new int[3];
        numbers[0] = 33;
        numbers[1] = 77;
        numbers[2] = 99;
        System.Console.WriteLine(numbers[0]);
        System.Console.WriteLine(numbers[1]);
        System.Console.WriteLine(numbers[2]);

        int[] nums = { 11, 22, 33 };// int array
        string[] names = { "Nasr", "Mona", "Shahd" };// string array
        System.Console.WriteLine(nums[0]);
        System.Console.WriteLine(nums[1]);
        System.Console.WriteLine(nums[2]);

        System.Console.WriteLine(names[0]);
        System.Console.WriteLine(names[1]);
        System.Console.WriteLine(names[2]);
        names [0] = "Malak"; // change array values
        names [1] = "Omar";
        System.Console.WriteLine(names[0]);
        System.Console.WriteLine(names[1]);

        object [] sortt = {"Omar",2,true,"1243"};
        System.Console.WriteLine(sortt);
        System.Array.Resize(ref sortt,12);
       // System.Array. etc ....

       

        // arrayName.resize (ref Array_name ,6)

































































    }

}