namespace Task1;

class Program
{
    static void Main(string[] args)
    {
       
        //Task 1 - Personal Info Card

        string name = "sara";
        int age = 21;
        double height = 1.65;
        bool student = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Student: " + student);
        
        
       //Task 2 - Rectangle Calculator

        Console.Write("Please Enter Your length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Please Enter Your width: ");
        double width = double.Parse(Console.ReadLine());

        double Area = length * width;
        double Perimeter = 2 * (length + width);

        Console.WriteLine("the Area:" + Area);
        Console.WriteLine("the Perimeter:" + Perimeter);
        
        //Task 3 - Even or Odd Checker 

        Console.WriteLine("plase Enter The whole number:");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("even number");
        }
        else
        {
            Console.WriteLine("odd number ");
        }
        
        
        //Task 4 - Voting Eligibility

        Console.WriteLine("Enter your Age:");
        int age = int.Parse(Console.ReadLine());
        bool id = true;

        if (age >= 18 && id == true)
        {
            Console.WriteLine(" allow to vote");
        }
        else
        {
            Console.WriteLine("not allow to vote");
        }
        
        //Task 5 - Grade Letter Lookup

        Console.WriteLine("enter a single character");
        char character = char.Parse(Console.ReadLine());

        switch (character)
        {
            case 'A':
                Console.WriteLine("Excellent");
                break;

            case 'B':
                Console.WriteLine("Very Good");
                break;

            case 'C':
                Console.WriteLine("Good");
                break;

            case 'D':
                Console.WriteLine("Pass");
                break;

            case 'F':
                Console.WriteLine("Fail");
                break;

            default:
                Console.WriteLine("please choose a correct character");
                break;
        }

        
        //Task 6 - Temperature Converter

        Console.WriteLine("enter a temperature in Celsius");
        double temperature = double.Parse(Console.ReadLine());

        double fahrenheit = (temperature * 9 / 5) + 32;

        Console.WriteLine("the Fahrenheit " + fahrenheit);

        ///////////////////////////////////////
        
        //Task 7 - Movie Ticket

        Console.WriteLine("enter your age ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 0 && age <= 12)
        {
            Console.WriteLine("Child :2.000 OMR");
        }
        else if (age >= 13 && age <= 59)
        {
            Console.WriteLine("Adult :5.000 OMR");
        }
        else if (age >= 60)
        {
            Console.WriteLine("Senior :3.000 OMR.");
        }
        else
        {
            Console.WriteLine("error");
        }
        
        
        
        
        //Task 8 - Restaurant Bill with Membership Discount

        Console.WriteLine("Enter total bill amount:");
        double bill = double.Parse(Console.ReadLine());

        Console.WriteLine("Are you a loyalty member? (yes/no):");
        string input = Console.ReadLine();

        bool loyalty = (input == "yes");

        double discount = 0;
        double finalAmount = bill;

        if (bill > 20 && loyalty)
        {
            discount = bill * 0.15;
            finalAmount = bill - discount;
        }
        else
        {
            discount = 0;
            finalAmount = bill;
        }

        Console.WriteLine("Original bill: " + bill);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Final amount: " + finalAmount);
      
        
        
        //Task 9 - Day Name Finder

        Console.WriteLine("Enter a number from 1 to 7: ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;

            case 2:
                Console.WriteLine("Monday");
                break;

            case 3:
                Console.WriteLine("Tuesday");
                break;

            case 4:
                Console.WriteLine("Wednesday");
                break;

            case 5:
                Console.WriteLine("Thursday");
                break;

            case 6:
                Console.WriteLine("Friday");
                break;

            case 7:
                Console.WriteLine("Saturday");
                break;

            default:
                Console.WriteLine("Invalid day number");
                break;
        }

        //////////////////////
        ////Task 10 - Mini Calculator

        Console.WriteLine("enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("enter operator (+, -, *, /, %):");
        char op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Result :" + (firstNumber + secondNumber));
                break;

            case '-':
                Console.WriteLine("Result:" + (firstNumber - secondNumber));
                break;

            case '*':
                Console.WriteLine("Result:" + (firstNumber * secondNumber));
                break;

            case '/':
                Console.WriteLine("Result:" + (firstNumber / secondNumber));
                break;

            case '%':
                if (secondNumber != 0)
                {
                    Console.WriteLine("Result:" + (firstNumber % secondNumber));
                    break;
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
                break;

            default:
                Console.WriteLine("Invalid operator");
                break;
        }
        
        //////////////////
        // Task 11 - Loan Eligibility System

        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your monthly income:");
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Do you have an existing loan? (yes/no):");
        string input = Console.ReadLine();

        bool loan = (input == "yes");

        if (age >= 21 && age <= 60 && salary >= 400 && !loan)
        {
            Console.WriteLine("Eligible");
        }
        else
        {
            if (age < 21)
            {
                Console.WriteLine("Not eligible: Age out of range");
            }

            if (salary < 400)
            {
                Console.WriteLine("Not eligible: Income too low");
            }

            if (loan)
            {
                Console.WriteLine("Not eligible: Existing loan");
            }
        }

        //////////////////////
        ///Task 12 - Shipping Cost Calculator

        Console.WriteLine("Enter a region code (A, B, C):");
        char code = char.Parse(Console.ReadLine());

        Console.WriteLine("Enter package weight (kg):");
        double weight = double.Parse(Console.ReadLine());

        double baseCost = 0;
        double charge = 0;
        double totalcost = 0;

        switch (code)
        {
            case 'A':
                baseCost = 1.000;

                if (weight > 10)
                    charge = 5.000;
                else if (weight > 5)
                    charge = 2.000;
                else
                    charge = 0;

                break;

            case 'B':
                baseCost = 3.000;

                if (weight > 10)
                    charge = 5.000;
                else if (weight > 5)
                    charge = 2.000;
                else
                    charge = 0;

                break;

            case 'C':
                baseCost = 7.000;

                if (weight > 10)
                    charge = 5.000;
                else if (weight > 5)
                    charge = 2.000;
                else
                    charge = 0;

                break;

            default:
                Console.WriteLine("Invalid region");
                break;
        }
        
        //////////////////
        //Task 13 - Triangle Type Classifier

        Console.WriteLine("Enter side 1:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 2:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side 3:");
        double c = double.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Equilateral");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Scalene");
            }
        }
        else
        {
            Console.WriteLine("Not a valid triangle");
        }

        
    }
}