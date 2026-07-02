namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        //Task 1 - Countdown Timer
        Console.WriteLine("enter a starting number:"); 
        int number = int.Parse(Console.ReadLine());
        for(int i=number ; i >= 1 ; i--) 
            Console.WriteLine(i);
        
        //Task 2 - Sum of Numbers 1 to
        
        Console.WriteLine("enter a positive whole number:"); 
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
       for (int i = 1; i <= num; i++) 
           sum = sum + i;
           Console.WriteLine("Sum = " + sum);

           //Task 3 - Multiplication Table

           Console.WriteLine("Enter a number:");
           int num = int.Parse(Console.ReadLine());
           for (int i = 1; i <= 10; i++)
           
           /////////////////////////
           ///Task 4 - Password Retry
           string Password = "Spark2026";
           Console.WriteLine("Enter password:");
           string input = Console.ReadLine();
           
           
           while (input != Password)
           {
               Console.WriteLine("Incorrect password, try again");
               Console.WriteLine("Enter password:");
               input = Console.ReadLine();
           }

           Console.WriteLine("Access Granted");
           ///////////////////////////////
           //Task 5 - Number Guessing Game
           
           int secret = 42;
           int guess;
           int attempts;
           do
           {
               Console.WriteLine("Guess the number:");
               guess = int.Parse(Console.ReadLine());
               attempts++;

               if (guess > secret)
                   Console.WriteLine("Too high");
               else if (guess < secret)
                   Console.WriteLine("Too low");
               else
                   Console.WriteLine("Correct!");
           }while (guess != secret);
           Console.WriteLine("Attempts: " + attempts);
           
           ///////////////////////////
           //Task 6 - Safe Division Calculator
           try
           {
               Console.WriteLine("Enter first number:");
               int num1 = int.Parse(Console.ReadLine());

               Console.WriteLine("Enter second number:");
               int num2 = int.Parse(Console.ReadLine());

               int result = num1 / num2;
               Console.WriteLine("Result = " + result);
           }
           catch (DivideByZeroException)
           {
               Console.WriteLine("Cannot divide by zero");
           }
           catch (FormatException)
           {
               Console.WriteLine("Please enter valid numbers only");
           }
           catch (Exception)
           {
               Console.WriteLine("Something went wrong");
           }
           
           //////////////////////
           //Task 7 - Repeating Menu with Exit Option
           int choice = 0;
           
           while (choice != 3)
           {
               Console.WriteLine("\nMenu:");
               Console.WriteLine("1) Say Hello");
               Console.WriteLine("2) Show Greeting");
               Console.WriteLine("3) Exit");
           
           
           try
           {
               Console.WriteLine("Enter your choice:");
               choice = int.Parse(Console.ReadLine());

               switch (choice)
               {
                   case 1:
                       Console.WriteLine("Hello!");
                       break;

                   case 2:
                       Console.WriteLine("Good day!");
                       break;

                   case 3:
                       Console.WriteLine("Exiting...");
                       break;

                   default:
                       Console.WriteLine("Invalid option");
                       break; 
               }
           }
           catch (FormatException)
           {
               Console.WriteLine("Please enter numbers only");
           }
    }
           ////////////////////////
           //Task 8 - Sum of Even Numbers Only
           Console.WriteLine("Enter a positive whole number:");
           int num = int.Parse(Console.ReadLine()); 
           
           int sum = 0;
           
           for (int i = 1; i <= num; i++)
           {
               if (i % 2 == 0)
               {
                   sum = sum + i;
               }
           }

           Console.WriteLine("Sum = " + sum);
           
           //////////////////////////////////////
           //Task 9 - Validated Positive Number Input
           int number = 0;
           bool valid = false;

           do
           {
               try
               {
                   Console.WriteLine("Enter a positive whole number:");
                   number = int.Parse(Console.ReadLine());

                   if (number > 0)
                   {
                       valid = true;
                   }
                   else
                   {
                       Console.WriteLine("Number must be greater than 0");
                   }
               }
               catch (FormatException)
               {
                   Console.WriteLine("Invalid input, please enter a number");
               }

           } while (!valid);
           
           
    }
}