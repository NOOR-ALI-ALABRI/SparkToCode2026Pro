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
    
    //Task 8 - Countdown Function  
    public static void Countdown(int num)
    {
        for (int i = num; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
    
    
    //Task 9 - Overloaded Multiply Function

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }
    
    
    //Task 10 - Overloaded Area Calculator
    public static double CalculateAreaa(double side)
    {
        return side * side;
    }

    public static double CalculateAreaa(double length, double width)
    {
        return length * width;
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
        
        
        //Task 8 - Countdown Function  
        Console.WriteLine("Enter number ");
        int numb = int.Parse(Console.ReadLine());
        Countdown(numb);
        
        

        //Task 9 - Overloaded Multiply Function
        int resultFunc1 = Multiply(2, 3);
        Console.WriteLine("Two integers result: " + resultFunc1);

        double resultFunc2 = Multiply(2.5, 3.5);
        Console.WriteLine("Two doubles result: " + resultFunc2);

        int resultFunc3 = Multiply(2, 3, 4);
        Console.WriteLine("Three integers result: " + resultFunc3);
        
        
        
        //Task 10 - Overloaded Area Calculator
        Console.WriteLine("Choose shape: 1 for Square, 2 for Rectangle");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine("Enter side:");
            double side = double.Parse(Console.ReadLine());

            double squareArea = CalculateAreaa(side);

            Console.WriteLine("Square area: " + squareArea);
        }
        
        else if (choice == 2)
        {
            Console.WriteLine("Enter length:");
            double rectLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width:");
            double rectWidth = double.Parse(Console.ReadLine());

            double rectangleArea = CalculateAreaa(rectLength, rectWidth);

            Console.WriteLine("Rectangle area: " + rectangleArea);
        }

    }
}