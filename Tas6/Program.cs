namespace Tas6;


public class BankAccount
{
    public int AccountNumber; // Properties
    public string HolderName;

    public double Balance;

    //Method
    public void Deposit(double amount) // Deposit()
    {
        Balance += amount; //Balance = Balance + amount;
        SendEmail();
    }

    public void Withdraw(double amount) // Withdraw()
    {
        if (Balance >= amount)
            Balance -= amount;
        else
        {
            Console.WriteLine("Not enough balance");
        }

        SendEmail();
    }

    public double CheckBalance()
    { Console.WriteLine("Account Holder: " + HolderName + " Balance: " + Balance);
        return Balance;
    }

private void SendEmail()
    {
        Console.WriteLine("Email notification sent");
    }
}

public class Student{
    public int Grade;
    public string Name;
    public string Address;

    private string email;
    int age;
    
    public void Register(string Email)
    {
        email = Email;
         SendEmail();
    }
    
    private void SendEmail()
    {
        Console.WriteLine("Registration email sent");
    }
}


public class Product
{
    public string ProductName;
    public double Price;
    public int StockQuantity;
    
    public void Sell(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
            LogTransaction();
        }
        else
        {
            Console.WriteLine("Not enough stock");
            LogTransaction();
        }
    }

   
    public void Restock(int quantity)
    {
        StockQuantity += quantity;
        LogTransaction();
    }

   
    public double GetInventoryValue()
    {
        PrintDetails();
        return Price * StockQuantity;
    }

    // Private method
    private void PrintDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Stock Quantity: " + StockQuantity);
    }
    
    private void LogTransaction()
    {
        Console.WriteLine("Transaction logged");
    }
}

public class Program
{
    //
    static BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "karim", Balance = 120 };
    static BankAccount account2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };

    static Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
    static Student student2 = new Student { Name = "Ahmed", Address = "Muscat", Grade = 70 };

    static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
    static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

    static void Main(string[] args)
    {


        bool exitApp = false;
        while (exitApp == false)
        {

            Console.WriteLine("===== Menu =====");
            Console.WriteLine("1. View Account Details");
            Console.WriteLine("2. Update Student Address");
            Console.WriteLine("3. Make a Deposit");
            Console.WriteLine("4. Make a Withdrawal");
            Console.WriteLine("5. View Product Details");
            Console.WriteLine("6. Register a Student");
            Console.WriteLine("7. Compare Two Account Balances");
            Console.WriteLine("8. Restock Product & Stock Level Check");
            Console.WriteLine("9. Transfer Between Accounts");
            Console.WriteLine("10. Update Student Grade");
            Console.WriteLine("11. Student Report Card");
            Console.WriteLine("12. Account Health Status");
            Console.WriteLine("13. Bulk Sale With Revenue Calculation");
            Console.WriteLine("14. Scholarship Eligibility Check");
            Console.WriteLine("15. Full Balance Top-Up Flow");
            Console.WriteLine("16. Quick Account Opening");
            Console.WriteLine("17. Total Students Counter");
            Console.WriteLine("18. Overdrawn Account Check");
            Console.WriteLine("19. Set Student Security PIN");
            Console.WriteLine("20. Exit");


            int choice;
            try
            { 
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("invalid input ");
                continue;
            }

            switch (choice)
            {
                case 1:
                    ViewAccountDetails();
                    break;

                case 2:
                    UpdateStudentAddress();
                    break;

                case 3:
                    MakeDeposit();
                    break;

                case 4:
                    Withdrawal();
                    break;

                case 5:
                    ViewProductDetails();
                    break;
                case 6:
                    RegisterStudent();
                    break;
                case 7:
                    CompareAccountBalances();
                    break;
                case 8:
                    RestockProduct();
                    break;
            
                  case 9:
                    TransferBetweenAccounts();
                    break;

                case 10:
                    UpdateStudentGrade();
                    break;

                case 11:
                    StudentReportCard();
                    break;

                case 12:
                    AccountHealthStatus();
                    break;

                case 13:
                    BulkSale();
                    break;



                }



        }
        
        }




    //help
    static BankAccount ChooseAccount()
    {
        Console.WriteLine("Choose account 1 or 2 :");
        Console.WriteLine("1. Karim");
        Console.WriteLine("2. Ali");

        string input = Console.ReadLine();

        if (input == "1")
        {
            return account1;
        }
        else if (input == "2")
        {
            return account2;
        }
        else
        {
            Console.WriteLine("Invalid choice");
            return null;
        }
    }

    //for student 
    static Student ChooseStudent()
    {
        Console.WriteLine("Choose Student 1 or 2:");
        Console.WriteLine("1. Ali");
        Console.WriteLine("2. Ahmed");

        string inputstudent = Console.ReadLine();

        if (inputstudent == "1")
        {
            return student1;
        }
        else if (inputstudent == "2")
        {
            return student2;
        }
        else
        {
            Console.WriteLine("Invalid choice");
            return null;
        }
    }
    
    //for product
    static Product ChooseProduct()
    {
        Console.WriteLine("Choose Product 1 or 2:");
        Console.WriteLine("1. Wireless Mouse");
        Console.WriteLine("2. Mechanical Keyboard");

        string input = Console.ReadLine();

        if(input == "1")
        {
            return product1;
        }
        else if(input == "2")
        {
            return product2;
        }
        else
        {
            Console.WriteLine("Invalid choice");
            return null;
        }
    }

    //EASY (5 Cases)//////////////////////////////////////////
    static void ViewAccountDetails()
    {
        BankAccount account = ChooseAccount();
        if (account != null)
        {
            account.CheckBalance();
        }

    }
    
    static void UpdateStudentAddress()
    {
        Student student = ChooseStudent();

        if(student != null)
        {
            Console.WriteLine("Enter new address:");
            student.Address = Console.ReadLine();

            Console.WriteLine("Address updated: " + student.Address);
        }
    }

    static void MakeDeposit()
    {
        BankAccount account = ChooseAccount();
        if (account != null)
        {
            Console.WriteLine("Enter amount:");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            
            Console.WriteLine("Holder Name: " + account.HolderName);
            Console.WriteLine("Updated Balance: " + account.Balance);
        }
    }

    static void Withdrawal()
    {
        BankAccount account = ChooseAccount();
        if(account != null)
        {
            Console.WriteLine("Enter amount:");
            double amount = double.Parse(Console.ReadLine());

            account.Withdraw(amount);

            Console.WriteLine("Updated Balance: " + account.Balance);
        }
    }
    
    static void ViewProductDetails()
    {
        Product product = ChooseProduct();

        if(product != null)
        {
            double value = product.GetInventoryValue();
            Console.WriteLine("Total Inventory Value: " + value);
        }
    }
    
    //MEDIUM (3 Cases)//////////////////////////////////////
    static void RegisterStudent()
    {
        Student student = ChooseStudent();

        if(student != null)
        {
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            student.Register(email);

            Console.WriteLine("Student registered successfully");
        }
    }
    
    static void CompareAccountBalances()
    {
        if(account1.Balance > account2.Balance)
        {
            Console.WriteLine(account1.HolderName + " has more money");
        }
        else if(account2.Balance > account1.Balance)
        {
            Console.WriteLine(account2.HolderName + " has more money");
        }
        else
        {
            Console.WriteLine("Both accounts have the same balance");
        }
    }
    static void RestockProduct()
    {
        Product product = ChooseProduct();

        if(product != null)
        {
            Console.WriteLine("Enter quantity to add:");
            int quantity = int.Parse(Console.ReadLine());

            product.Restock(quantity);

            Console.WriteLine("Updated Stock: " + product.StockQuantity);

            if(product.StockQuantity < 10)
            {
                Console.WriteLine("Stock Level: Low");
            }
            else if(product.StockQuantity >= 10 && product.StockQuantity <= 49)
            {
                Console.WriteLine("Stock Level: Moderate");
            }
            else
            {
                Console.WriteLine("Stock Level: Well Stocked");
            }
        }
    }
    
    
    //HARD (5 Cases) //////////////////////////////////////////
    static void TransferBetweenAccounts()
    {
        Console.WriteLine("Choose source account:");
        BankAccount sourceAccount = ChooseAccount();

        Console.WriteLine("Choose destination account:");
        BankAccount destinationAccount = ChooseAccount();

        if(sourceAccount != null && destinationAccount != null)
        {
            Console.WriteLine("Enter transfer amount:");

            double amount = double.Parse(Console.ReadLine());

            if(sourceAccount.Balance >= amount)
            {
                sourceAccount.Withdraw(amount);
                destinationAccount.Deposit(amount);

                Console.WriteLine("Transfer completed successfully");
                Console.WriteLine("Source Balance: " + sourceAccount.Balance);
                Console.WriteLine("Destination Balance: " + destinationAccount.Balance);
            }
            else
            {
                Console.WriteLine("Transfer failed: Not enough balance");
            }
        }
    }
    
    
    static void UpdateStudentGrade()
    {
        Student student = ChooseStudent();

        if(student != null)
        {
            Console.WriteLine("Enter new grade:");

            try
            {
                int grade = int.Parse(Console.ReadLine());

                if(grade < 0 || grade > 100)
                {
                    Console.WriteLine("Grade must be between 0 and 100.");
                }
                else
                {
                    student.Grade = grade;

                    Console.WriteLine("Grade updated successfully.");
                    Console.WriteLine("New Grade: " + student.Grade);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    static void StudentReportCard()
    {
        Student student = ChooseStudent();
        if(student != null)
        {
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Grade: " + student.Grade);

            if(student.Grade >= 60)
            {
                Console.WriteLine("Status: Pass");
            }
            else
            {
                Console.WriteLine("Status: Fail");
            }
        }
    }
    static void AccountHealthStatus()
    {
        BankAccount account = ChooseAccount();

        if(account != null)
        {
            Console.WriteLine("Account Holder: " + account.HolderName);
            Console.WriteLine("Balance: " + account.Balance);

            if(account.Balance < 50)
            {
                Console.WriteLine("Status: Low Balance");
            }
            else if(account.Balance >= 50 && account.Balance <= 1000)
            {
                Console.WriteLine("Status: Healthy");
            }
            else
            {
                Console.WriteLine("Status: Premium");
            }
        }
    }
    static void BulkSale()
    {
        Product product = ChooseProduct();

        if(product != null)
        {
            Console.WriteLine("Enter quantity to sell:");
            int quantity = int.Parse(Console.ReadLine());

            if(product.StockQuantity < quantity)
            {
                int needed = quantity - product.StockQuantity;

                Console.WriteLine("Not enough stock.");
                Console.WriteLine("Additional units needed: " + needed);
            }
            else
            {
                product.Sell(quantity);

                double revenue = quantity * product.Price;

                Console.WriteLine("Sale completed successfully");
                Console.WriteLine("Total Revenue: " + revenue);
                Console.WriteLine("Remaining Stock: " + product.StockQuantity);
            }
        }
    }