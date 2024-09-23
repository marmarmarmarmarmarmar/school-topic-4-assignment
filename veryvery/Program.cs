/* 
Coda | 2024/09/18
Topic 4 - User Input - Assignment
*/

using System;
namespace ui_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vars
            string usersName;
            int usersAge;
            double usersSalary;
            string firstName;
            string lastName;
            int currentGrade;
            int studentID;
            string studentLogin;
            double studentAverage;
            double firstNum;
            double secondNum;
            double thirdNum;
            // Vars

            // PART 1 //
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("Part 1: Inquisitive Prompts");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("Hello user! Might I ask, what is your name?");
            usersName = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("I see,");
            Thread.Sleep(1500);
            Console.Write(" your name is " + usersName + "!");
            Thread.Sleep(2000);
            Console.WriteLine(" How old are you, " + usersName + "?");
            Int32.TryParse(Console.ReadLine(), out usersAge);
            Console.WriteLine("");
            Console.WriteLine(usersAge + ", hm?");
            Thread.Sleep(3000);
            Console.WriteLine("...");
            Thread.Sleep(3000);
            Console.Write("Interesting.");
            Thread.Sleep(1500);
            Console.WriteLine(" Might I also ask what your salary is, " + usersName + "?");
            Double.TryParse(Console.ReadLine(), out usersSalary);
            Console.WriteLine("");
            Console.WriteLine("Your salary is " + (usersSalary).ToString("C") + ", yes?");
            Thread.Sleep(3000);
            Console.WriteLine("Hm...");
            Thread.Sleep(5000);

            // PART 2 //
            Console.WriteLine("");
            Console.WriteLine("Part 2: Modern Internet Simulator");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.Write("Hello user!");
            Thread.Sleep(3000);
            Console.WriteLine(" In order for us to sell your personal information to advertisers and data brokers...");
            Thread.Sleep(5000);
            Console.Write("Uh...");
            Thread.Sleep(3000);
            Console.WriteLine(" I mean, to improve your user experience...");
            Thread.Sleep(3000);
            Console.WriteLine("Please enter the following information related to yourself!");
            Console.WriteLine("");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName = Console.ReadLine();
            Console.Write("Grade (9 - 12): ");
            Int32.TryParse(Console.ReadLine(), out currentGrade);
            Console.Write("Student ID: ");
            Int32.TryParse(Console.ReadLine(), out studentID);
            Console.Write("Login: ");
            studentLogin = Console.ReadLine();
            Console.Write("Average: ");
            Double.TryParse(Console.ReadLine(), out studentAverage);
            Console.WriteLine("");
            Console.WriteLine("I see! So your information is:");
            Thread.Sleep(2000);
            Console.WriteLine("Name:\t\t" + lastName + ", " + firstName);
            Console.WriteLine("Login:\t\t" + studentLogin);
            Console.WriteLine("ID:\t\t" + studentID);
            Console.WriteLine("Grade:\t\t" + currentGrade);
            Console.WriteLine("Average:\t" + studentAverage + "%");
            Console.WriteLine("");
            Thread.Sleep(5000);
            Console.WriteLine("Thank you for your cooperation, you can trust us that your personal data will be kept safe!");
            Thread.Sleep(5000);
            Console.Write("Very safe...");
            Thread.Sleep(1000);
            Console.Write(" and private!");
            Thread.Sleep(1000);
            Console.Write(" Yes, definitely!");
            Thread.Sleep(1000);
            Console.WriteLine(" Certainly!");
            Thread.Sleep(5000);

            // PART 3 //
            Console.WriteLine("");
            Console.WriteLine("Part 3: Ominous Remark");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.Write("Hello user! What is your name? ");
            usersName = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Greetings, " + usersName + "! How old are you currently? ");
            Int32.TryParse(Console.ReadLine(), out usersAge);
            Console.WriteLine("");
            Console.WriteLine("I see! Did you know that in five years, you will be " + (usersAge + 5) + "?");
            Console.WriteLine("And that, five years ago, you were " + (usersAge - 5) + "?");
            Thread.Sleep(5000);
            Console.WriteLine("...");
            Thread.Sleep(5000);
            Console.WriteLine("Time is surely a curious thing. Isn't it, " + usersName + "?");
            Thread.Sleep(5000);

            // PART 4 //
            Console.WriteLine("");
            Console.WriteLine("Part 4: Silly Calculator");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("Halo! Can you give me three numbers pleas?");
            Console.Write("First Number: ");
            Double.TryParse(Console.ReadLine(), out firstNum);
            Console.Write("Second Number: ");
            Double.TryParse(Console.ReadLine(), out secondNum);
            Console.Write("Third Number: ");
            Double.TryParse(Console.ReadLine(), out thirdNum);
            Thread.Sleep(2000);
            Console.Write("Thank you! Did you know, that if you, uh");
            Thread.Sleep(3000);
            Console.WriteLine(" if you added those numbers together, and divided the sum by two, you'd get...");
            Thread.Sleep(3000);
            Console.WriteLine(((firstNum + secondNum + thirdNum) * 23.0) + ("?"));
            Thread.Sleep(3000);
            Console.WriteLine("No... you would get...");
            Thread.Sleep(3000);
            Console.WriteLine(((firstNum + secondNum + thirdNum) / 2.0) + ("!"));
            Thread.Sleep(3000);
            Console.WriteLine("Yes! That is correct, it would be " + ((firstNum + secondNum + thirdNum) / 2.0));
            Thread.Sleep(5000);

            // PART 5 //
            Console.WriteLine("");
            Console.WriteLine("Part 5: Silly Calculator");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine("Halo! Can you give me three numbers pleas?");
        }
    }
}

