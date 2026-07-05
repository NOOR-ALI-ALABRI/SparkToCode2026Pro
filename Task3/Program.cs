namespace Task3;

class Program
{
    static void Main(string[] args)
    {
     //Task 1 - Absolute Difference
     Console.WriteLine("Enter Two Number");
     int num1 = int.Parse(Console.ReadLine());
     int num2= int.Parse(Console.ReadLine());
     int result = num1 - num2;
      
      Console.WriteLine(Math.Abs(result));

      



    }
}