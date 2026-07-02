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

        
    }
}