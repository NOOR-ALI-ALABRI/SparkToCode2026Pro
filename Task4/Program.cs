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
    
    
    
    
    //Main 
    static void Main(string[] args)
    {
        
        //Task 1 - Personalized Welcome Function
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        PrintWelcome(name);
        
        
        //Task 2 - Square Number Function
        int num = int.Parse(Console.ReadLine());
        int result = Square(num);
        Console.WriteLine(result);
        
        
        
    }
}