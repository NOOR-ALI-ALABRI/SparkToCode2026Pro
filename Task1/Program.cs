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
    }
}