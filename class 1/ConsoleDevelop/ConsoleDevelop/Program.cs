using System;
namespace ConsoleDevelop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Welcome to Aptech");

            string stdName = "Ali";
            int stdAge = 20;
            bool stdNic = true;
            char stdGrade = 'A';
            double stdCGPA = 3.21;


            //Console.WriteLine("Student Name is " + stdName + " " +stdGrade);
            Console.WriteLine("Student Name is " + stdName );

            Console.WriteLine("Student age is " + stdAge);
            Console.WriteLine("Student NIC is " + stdNic);
            Console.WriteLine("Student Grade is " + stdGrade);
            Console.WriteLine("Student CGPA is " + stdCGPA);



            //double aur float task  find with example


            float a = 1.1234567f;     // float mein 7 digits tak accuracy milegi
            double b = 1.1234567890123; // double mein 15 digits tak

            Console.WriteLine(a); // Output: 1.123457
            Console.WriteLine(b); // Output: 1.1234567890123

            //Console.WriteLine("Enter your Name ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Enter your Age ");
            //int userAge = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("UserName is " + userName);
            //Console.WriteLine("UserAge is " + userAge);


            Console.WriteLine("Enter your Physics Marks ");
            int PhyMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Chemistry Marks ");
            int cheMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Maths Marks ");
            int MathsMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your islamiat Marks ");
            int IslMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Urdu Marks ");
            int UrduMarks = Convert.ToInt32(Console.ReadLine());


            int totalMarks = PhyMarks + cheMarks + MathsMarks + IslMarks + UrduMarks;
            Console.WriteLine("total" + totalMarks);

            Console.WriteLine(totalMarks * 100 / 500);


            //Console.WriteLine(PhyMarks + cheMarks + MathsMarks + IslMarks + UrduMarks *100 /500);
        }
    }
}
