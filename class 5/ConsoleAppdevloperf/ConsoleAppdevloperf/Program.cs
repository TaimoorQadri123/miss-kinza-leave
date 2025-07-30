namespace ConsoleAppdevloperf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <=10; i++)
            //{ 
            //Console.WriteLine(i);
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i =0; i <= 20  ; i++)
            //{
            //    Console.WriteLine(i++ );
            //}
            //for (int i = 0; i <= 20; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 20; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 19; i >= 1; i -= 2)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.WriteLine("Enter your table Number ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 10; i ++)
            //{


            //    Console.WriteLine($"Table: {num} x {i} = {i * num}");

            //}

            //int i = 1;
            //while (i<=10)
            //{ 
            //Console.WriteLine(i);
            //    i++;
            //}

            //int i = 10;
            //while (i >= 1)
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}

            //string correctusername ="Admin".ToLower();
            //string correctpassword = "1234";

            //string username, password;

            //while (true) 

            //{
            //    Console.WriteLine("Enter your username ");
            //    username = Console.ReadLine();
            //    Console.WriteLine("Enter your password ");
            //    password = Console.ReadLine();


            //    if (username == correctusername && password == correctpassword) 

            //    {
            //    Console.WriteLine("Login Successful");
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Invalid credentials");
            //    }


            //}



            //Console.WriteLine("Enter any word");
            //string word = Console.ReadLine();


            //while (i = word) ;
            //{
            //    Console.WriteLine(i);
            //    i--;
            //}


            Console.WriteLine("Enter your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 to 5 ");
            string opreator = Console.ReadLine();

            Console.WriteLine("Enter your second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());



            switch (opreator)
            {

                case "1":
                    Console.WriteLine(num1 + num2);
                    break;

                case "2":
                    Console.WriteLine(num1 - num2);
                    break;

                case "3":
                    Console.WriteLine(num1 * num2);
                    break;

                case "4":

                    if (num2 == 0)
                    {
                        Console.WriteLine("invalid value");
                    }
                    else
                    {
                        Console.WriteLine(num1 / num2);
                    }


                    break;



                case "5":
                    Console.WriteLine(num1 % num2);
                    break;



                default:
                    Console.WriteLine("invalid Operator");
                    break;
            }
        }
    }
}
