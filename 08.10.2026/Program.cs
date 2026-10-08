namespace _08._10._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Uprazhnenie
            //Console.WriteLine("Calculating first rectangle:");
            //Console.Write("Enter a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter b = ");
            //int b = int.Parse(Console.ReadLine());
            //int p = 2 * (a + b);
            //int s = a * b;
            //Console.WriteLine("P = {0}", p);
            //Console.WriteLine("S = {0}", s);
            //Console.WriteLine();

            //Console.WriteLine("Calculating second rectangle:");
            //Console.Write("Enter a = ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Enter b = ");
            //b = int.Parse(Console.ReadLine());
            //p = 2 * (a + b);
            //s = a * b;
            //Console.WriteLine("P = {0}", p);
            //Console.WriteLine("S = {0}", s);
            //Console.WriteLine();

            //Console.WriteLine("Calculating third rectangle:");
            //Console.Write("Enter a = ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Enter b = ");
            //b = int.Parse(Console.ReadLine());
            //p = 2 * (a + b);
            //s = a * b;
            //Console.WriteLine("P = {0}", p);
            //Console.WriteLine("S = {0}", s);
            #endregion

            #region zadacha1
            //Console.Write("Enter first number: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            #endregion

            #region zadacha2
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Hello {name}! In 10 years you will be {age + 10} years old.");
            #endregion

            #region zadacha3
            //Console.WriteLine("Enter first side: ");
            //double firstSide = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second side: ");
            //double secondSide = double.Parse(Console.ReadLine());
            //Console.WriteLine("Rectangle's area is {0}", Math.Round(firstSide * secondSide, 2));
            #endregion

            #region zadacha4
            //Console.Write("Enter dimension in centimeters: ");
            //int cm = int.Parse(Console.ReadLine());
            //double m = (double)cm / 100;
            //int mm = cm * 100;
            //Console.WriteLine("Dimension in milimeters is " + mm + " and in meters is " + Math.Round(m, 2));
            #endregion

            #region zadacha5            
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter days: ");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter money: ");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("In {0} days {1} will have {2:c}.", days, name, money * days);
            #endregion

            #region zadacha6

            #endregion
        }
    }
}
