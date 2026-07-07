namespace Task4;

class Program
{



    //Task 1 - Personalized Welcome Function
    public static void PrintWelcome(string name)
    {
        Console.WriteLine("welcome" + name);
    }
    
    //Task 2 - Square Number Function
    public static int Square(int number)
    {
        return number * number;
    }
    
    //Task 3 - Celsius to Fahrenheit Function
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
   
    //Task 4 - Fixed Menu Display Function 
    public static void DisplayMenu()
    {
        Console.WriteLine("1) Start");
        Console.WriteLine("2) Help");
        Console.WriteLine("3) Exit");
    }
    
    //Task 5 - Even or Odd Function
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
    
    
    //Task 6 - Rectangle Area & Perimeter Functions
    public static double CalculateArea(double length, double width) // Calculate rectangle area
                                                                    
    {
        return length * width;
    }
    public static double CalculatePerimeter(double length, double width) // Calculate rectangle perimeter

    {
        return 2 * (length + width);
    }
    
   

    //Task 7 - Grade Letter Function

    public static string GetGradeLetter(int score)
    {
        if (score >= 90)
        {
            return "A";
        }
        else if (score >= 80)
        {
            return "B";
        }
        else if (score >= 70)
        {
            return "C";
        }
        else if (score >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
    
    
    
    //Main 
    static void Main(string[] args)
    {
        
        //Task 1 - Personalized Welcome Function
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        PrintWelcome(name);
        
        
        //Task 2 - Square Number Function
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        int result = Square(num);
        Console.WriteLine(result);
        
        //Task 3 - Celsius to Fahrenheit Function
        Console.WriteLine("Enter temperature in Celsius:");
        double c = double.Parse(Console.ReadLine());
        double result2 = CelsiusToFahrenheit(c);
        Console.WriteLine("Temperature in Fahrenheit: " + result2);
        
        
        //Task 4 - Fixed Menu Display Function
        DisplayMenu();

        
        //Task 5 - Even or Odd Function
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        bool result3 = IsEven(number);
        if (result3)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
        
        
        
        //Task 6 - Rectangle Area & Perimeter Functions
        Console.WriteLine("Enter length:");
        double length = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter width:");
        double width = double.Parse(Console.ReadLine());
        
        double area = CalculateArea(length, width);
        double perimeter = CalculatePerimeter(length, width);

        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);

        
        
        //Task 7 - Grade Letter Function
        Console.WriteLine("Enter score:");
        int scoregrad = int.Parse(Console.ReadLine());
        string result4 = GetGradeLetter(scoregrad);
        Console.WriteLine("Your result is: " + result4);

    }
}