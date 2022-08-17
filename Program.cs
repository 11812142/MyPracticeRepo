// See https://aka.ms/new-console-template for more information
//using System;//base class library--- parent


//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 10;
//            Int32 j = 20;
//            int k = i + j;
//            Console.WriteLine(k);
//            Console.WriteLine("--------------------------");
//            Console.WriteLine("enter i for multiplication");
//            i = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter j for multiplication");
//            j = Convert.ToInt32(Console.ReadLine());
//            k = i * j;

//            Console.WriteLine("The multiplication of i and j=" + k);
//            Console.WriteLine("The multiplication of {0} and {1}={2}", i, j, k);


//            Console.WriteLine("Hello");
//            Console.Write(DateTime.Now);

//            Console.ReadLine();//Read()/ ReadKey()
//            //comment


//        }
//    }

using System;


namespace LanguageBasicsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name;
            //DateTime bdate;
            int i;
            float radius;
            float pi = 3.14f;
            Console.WriteLine("enter radius");
            radius = Convert.ToSingle(Console.ReadLine());

            double area = pi * radius * radius;
            Console.WriteLine(area);


            //comment---(Select the code to comment)Ctrl+ K+ C
            // Console.WriteLine("Enter a string");
            // name = Console.ReadLine();
            //Console.WriteLine("Enter your date of birth");
            // bdate = Convert.ToDateTime(Console.ReadLine());

            // Console.WriteLine("Hello " + name);
            // Console.WriteLine("You entered date as = " + bdate);
            // CalculateAge(bdate);

            Console.ReadLine();




        }

        static void CalculateAge(DateTime birthdate)
        {
            int currentDate = DateTime.Now.Year;
            int byear = birthdate.Year;
            int age = currentDate - byear;
            Console.WriteLine("Your age as per your birth date= " + age);

        }
    }
}