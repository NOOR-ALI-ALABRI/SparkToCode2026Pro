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
     
     
     //Task 3 - Name Formatter
     
     Console.WriteLine("Enter Your Fill Name:");
      string name = Console.ReadLine();
      
      Console.WriteLine( "name in upper case:"+ name.ToUpper());
      Console.WriteLine("name in lower case :"+ name.ToLower());
      Console.WriteLine("the Length of your na"+name.Length );
   
        /////////////////////////////////////////
        
        //Task 4 - Subscription End Date
        Console.WriteLine("Enter the number of days for the free trial:");
        int numberOfDay = int.Parse(Console.ReadLine());
        
        
        DateTime today = DateTime.Today;
        DateTime endDate = today.AddDays(numberOfDay);


        Console.WriteLine(today);
        Console.WriteLine(endDate);

        Console.WriteLine(endDate.ToString("yyyy-MM-dd"));

        
        /////////////////////////////////////////
        
       //Task 5 - Grade Rounding System
       
     Console.WriteLine("Enter your raw exam score (e.g., 74.6)");
     double score = double.Parse(Console.ReadLine());

     double roundScore= Math.Round(score, 0);
     Console.WriteLine($"Rounded Score: {roundScore}");
     
     if (roundScore >= 60)
     {
         Console.WriteLine("Result: Pass");
     }
     else
     {
         Console.WriteLine("Result: Fail");
     }
     
     /////////////////////////////////////////
  
        //Task 6 - Password Strength Checker
        Console.WriteLine("Enter password ");
        string password =(Console.ReadLine());
        string lowerPassword = password.ToLower();
        
        bool islength = password.Length >= 8;
        bool hasPassword = lowerPassword.Contains("password");

        if ( islength && !hasPassword)
        {
            Console.WriteLine("Strong");
        }
        else
        {
            Console.WriteLine("Weak");
        }
        
        
        
        //////////////////////////
        //Task 7 - Clean Name Comparator
        Console.WriteLine("Enter your name: "); 
        string name1 = Console.ReadLine();

        Console.WriteLine("Enter your name again: ");
        string name2 = Console.ReadLine();

        string clean1 = name1.Trim().ToLower();
        string clean2 = name2.Trim().ToLower();

        if (clean1 == clean2)
        {
            Console.WriteLine("Match");
        }
        else
        {
            Console.WriteLine("No Match");
        }
         */
        /////////////////////////
        //Task 8 - Membership Expiry Checker
        Console.WriteLine("Enter membership start date (e.g. 2026-01-10):");
        string startText = Console.ReadLine();
        
        Console.WriteLine("Enter number of valid days:");
        int days = int.Parse(Console.ReadLine());
        
        DateTime startDate = DateTime.Parse(startText);
        
        DateTime expiryDate = startDate.AddDays(days);
        
        if (expiryDate >= DateTime.Today)
        {
            Console.WriteLine("Membership Status: Active");
        }
        else
        {
            Console.WriteLine("Membership Status: Expired");
        }
        
        Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
        

    }
}