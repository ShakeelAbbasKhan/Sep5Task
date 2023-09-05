using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sep5Task
{
    //public delegate void Calculation(int a, int b);

    internal class Program
    {
 
        //public static void Addition(int a, int b)
        //{
        //    int result = a + b;
        //    Console.WriteLine("Addition = " + result);
        //}
        //public static void Subtraction(int a, int b)
        //{
        //    int result = a - b;
        //    Console.WriteLine("Subtraction = " + result);
        //}
        //public static void Multiplication(int a, int b)
        //{
        //    int result = a * b;
        //    Console.WriteLine("Division = "+ result);
        //}
        //public static void Division(int a, int b)
        //{
        //    int result = a / b;
        //    Console.WriteLine("Division = "+ result);
        //}
        static void Main(string[] args)
        {

            //Calculation obj = new Calculation(Program.Addition);
            //obj.Invoke(10,30);
            //obj = Subtraction;
            //obj.Invoke(10,30);
            //obj = Multiplication;
            //obj.Invoke(10,30); 
            //obj =  Division;
            //obj.Invoke(30,10);
            //Console.ReadLine();

            // call sync

            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();


        }

        // for sync 

        //public static void Task1()
        //{
        //    Console.WriteLine("Task1 is Starting..");
        //    Thread.Sleep(4000);
        //    Console.WriteLine("Task1 is Completed");
        //}
        //public static void Task2()
        //{
        //    Console.WriteLine("Task2 is Starting..");
        //    Thread.Sleep(2000);
        //    Console.WriteLine("Task2 is Completed");
        //}
        //public static void Task3()
        //{
        //    Console.WriteLine("Task3 is Starting..");
        //    Thread.Sleep(5000);
        //    Console.WriteLine("Task3 is Completed");
        //}
        //public static void Task4()
        //{
        //    Console.WriteLine("Task4 is Starting..");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("Task4 is Completed");
        //}

        // for aynsc

        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 is Starting..");
                Thread.Sleep(4000);
                Console.WriteLine("Task1 is Completed");
            });

        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 is Starting..");
                Thread.Sleep(5000);
                Console.WriteLine("Task2 is Completed");
            });

        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 is Starting..");
                Thread.Sleep(3000);
                Console.WriteLine("Task3 is Completed");
            });

        }
        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task4 is Starting..");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 is Completed");
            });

        }


    }
}
