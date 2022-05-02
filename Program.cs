using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Calculator ObjCalc=new Calculator();
            Console.WriteLine("Enter 1st number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2=Convert.ToInt32(Console.ReadLine());
            ObjCalc.addition(num1, num2);
            ObjCalc.subtraction(num1, num2);
        }
    }
}