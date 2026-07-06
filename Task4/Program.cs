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
        
        
        
        
        
    }
}