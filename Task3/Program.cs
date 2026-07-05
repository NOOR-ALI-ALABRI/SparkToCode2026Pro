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
      
      
     /////////////////////////////////////////
     //Task 2 - Power & Root Explorer
     Console.WriteLine("Enter a number ");
     int number = int.Parse(Console.ReadLine());

     double power = Math.Pow(number, 2);
     double sqrt = Math.Sqrt(number);
     Console.WriteLine("the power of number is" + power);
     Console.WriteLine("the sqrt of number is" + sqrt);
     
     
       /////////////////////////////////////////
     */
     
     //Task 3 - Name Formatter
     
     Console.WriteLine("Enter Your Fill Name:");
      string name = Console.ReadLine();
      
      Console.WriteLine( "name in upper case:"+ name.ToUpper());
      Console.WriteLine("name in lower case :"+ name.ToLower());
      Console.WriteLine("the Length of your na"+name.Length );
    

    }
}