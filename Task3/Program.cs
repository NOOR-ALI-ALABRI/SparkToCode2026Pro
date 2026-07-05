namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        /*
     //Task 1 - Absolute Difference
     Console.WriteLine("Enter Two Number");
     int num1 = int.Parse(Console.ReadLine());
     int num2= int.Parse(Console.ReadLine());
     int result = num1 - num2;
      
      Console.WriteLine(Math.Abs(result));
     */
      
     //Task 2 - Power & Root Explorer
     Console.WriteLine("Enter a number ");
     int number = int.Parse(Console.ReadLine());

     double power = Math.Pow(number, 2);
     double sqrt = Math.Sqrt(number);
     Console.WriteLine("the power of number is" + power);
     Console.WriteLine("the sqrt of number is" + sqrt);
     
     
     
     
     
     
     
    }
}