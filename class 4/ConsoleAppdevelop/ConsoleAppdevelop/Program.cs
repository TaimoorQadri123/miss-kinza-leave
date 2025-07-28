using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApphiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your First Number");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter your second Number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num1 = 10;
            //int num2 = 20;
            //Console.WriteLine($"Add: {num1} + {num2}  = {num1 + num2}");
            //Console.WriteLine($"Sub: {num1} - {num2}  = {num1 - num2}");
            //Console.WriteLine($"Mul: {num1} * {num2}  = {num1 * num2}");
            //Console.WriteLine($"Div: {num1} / {num2}  = {num1 / num2}");
            //Console.WriteLine($"Mod: {num1} % {num2}  = {num1 % num2}");


            //Console.WriteLine("enter first number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter first number");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Is Equal : {num1 == num1 }");
            //Console.WriteLine($"Is Not Equal : {num1 != num1 }");
            //Console.WriteLine($"Is Greater : {num1 > num1  }");
            //Console.WriteLine($"Is less : {num1 < num1  }");
            //Console.WriteLine($"Is Greater or equal : {num1 >= num1 }");
            //Console.WriteLine($"Is Less or equal : {num1 <= num1 }");


            //string username = "Ali@gmai.com".ToLower();
            //int password = 1234;

            //if ((username == "ali" || username == "ali@gmail.com") & password == 1234) ;
            //{
            //    Console.WriteLine("Login successful");

            //}
            //else {
            //    Console.WriteLine("Invalid username or password ");

            //}

            //int a = 13;
            //Console.WriteLine(a++);
            //Console.WriteLine(a);

            //int a = 13;
            //Console.WriteLine(a--);
            //Console.WriteLine(a);

            //if(!isRaning)
            //{
            //    Console.WriteLine("take an umbrella");
            //}
            //else 
            //{
            //    Console.WriteLine("Gofora walk");
            //}
            //double bankaccount = 2000;
            //double deposit = 1000;
            //bankaccount+= deposit;
            //Console.WriteLine(bankaccount);


            //double account = 2000;
            //double credit = 1000;
            //account -= credit;
            //Console.WriteLine(account);

            //double account = 2000;
            //double credit = 1000;
            //account *= credit;
            //Console.WriteLine(account);

            //double account = 2000;
            //double credit = 1000;
            //account /= credit;
            //Console.WriteLine(account);



            //Console.WriteLine("Enter your Number");
            //int number =Convert.toint  Console.ReadLine() ;

            //string res = (number % 2 == 0) ? "Even" : "Odd";

            //Console.WriteLine(res);


            //string day = "Monday";


            //switch (day) {

            //    case "Monday":
            //        Console.WriteLine(1);
            //    break;

            //    case "Tuesday":
            //        Console.WriteLine(2);
            //    break;

            //    case "wednesday":
            //        Console.WriteLine(3);
            //    break;

            //    case "thursday":
            //        Console.WriteLine(4);
            //    break;

            //    case "Friday":
            //        Console.WriteLine(5);
            //    break;

            //    case "Saturday":
            //        Console.WriteLine(6);
            //    break;

            //    case "Sunday":
            //        Console.WriteLine(7);
            //    break;

            //    default:
            //        Console.WriteLine("Invalid value");
            //        break;




            Console.WriteLine("Enter your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Operator");
            string opreator = Console.ReadLine();

            Console.WriteLine("Enter your second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());



            switch (opreator) {

                case "+" :
                Console.WriteLine(num1 + num2);
                break;

                case "-" :
                Console.WriteLine(num1 - num2);
                break;

                case "*" :
                Console.WriteLine(num1 * num2);
                break;

                case "/":

                 if (num2 == 0)
                 {
                     Console.WriteLine("invalid value");
                 }
                 else
                 { 
                 Console.WriteLine(num1 / num2);
                 }


                 break;



                case "%":
                Console.WriteLine(num1 % num2);
                break;

               

                default:
                    Console.WriteLine("invalid Operator");
                    break;
            }






        }



    }
    }
