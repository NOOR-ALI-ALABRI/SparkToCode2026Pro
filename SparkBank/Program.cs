namespace SparkBank;

class Program
{
    
    static List<string> customerNames = new List<string>();
    static List<string> accountNumbers = new List<string>();
    static List<double> balances = new List<double>();
    
    static void AddAccount()
    {
   // TODO: implement this service (see Section 3 requirements)
    Console.Write("Enter customer name: ");
    string name =Console.ReadLine(); 
    Console.Write("Enter account number: "); 
    string inputAccount = Console.ReadLine();
    
    if (accountNumbers.Contains(inputAccount))   // Check if account number already exists  for accountNumbers
    {
        Console.WriteLine("Account number already exists.");
        return;
    }
    Console.Write("Enter initial deposit amount: ");  // Ask for initial deposit for balances
    double initialDeposit = double.Parse(Console.ReadLine());
    if (initialDeposit < 0)
    {
        Console.WriteLine("Invalid deposit amount.");
        return;
    }
    customerNames.Add(name);
    accountNumbers.Add(inputAccount);
    balances.Add(initialDeposit);
    Console.WriteLine("Account created successfully!");
    Console.WriteLine("Customer Name: " + name);
    Console.WriteLine("Account Number: " + inputAccount);
    Console.WriteLine("Balance: " + initialDeposit);
    }

    
    static void DepositMoney()
    {
    // TODO: implement this service (see Section 3 requirements)
    Console.Write("Enter account number: ");
    string accountNumber = Console.ReadLine();
    int index = accountNumbers.IndexOf(accountNumber);
    if (index ==-1)
    {
        Console.WriteLine("Account not found ");
        return;
    }
    Console.Write("Enter deposit amount: ");
    double amount = double.Parse(Console.ReadLine());
    
    if (amount <= 0) // positive number.
    {
        Console.WriteLine("Invalid deposit amount.");
        return;
    }
    balances[index] = balances[index] + amount;
    Console.WriteLine("Deposit successful.");
    Console.WriteLine("Updated balance: " + balances[index]);
    
    }

    static void WithdrawMoney()
    {
    // TODO: implement this service (see Section 3 requirements)
    Console.WriteLine("your account number ?.");
    string accountNumber2 = Console.ReadLine();
    int index = accountNumbers.IndexOf(accountNumber2);
    if (index ==-1)
    {
        Console.WriteLine("error");
        return;
    }
    Console.WriteLine("withdrawal amount ?.");
    double withdrawal = double.Parse(Console.ReadLine());
    if (withdrawal <= 0 || withdrawal > balances[index])
    {
        Console.WriteLine("Invalid withdrawal amount. ");
        return;
    }
    else 
    {
        balances[index] = balances[index] - withdrawal;    
        Console.WriteLine("Withdrawal successful.");
        Console.WriteLine("Updated balance: " + balances[index]);
    }
    
    }
    
    
    static void ShowBalance()
    {// TODO: implement this service (see Section 3 requirements)
        
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();
        int index = accountNumbers.IndexOf(accountNumber);

        if (index == -1)
        {
            Console.WriteLine("Account not found.");
            return;
        }
        Console.WriteLine("Customer Name: " + customerNames[index]);
        Console.WriteLine("Account Number: " + accountNumbers[index]);
        Console.WriteLine("Balance: " + balances[index]);
        
    }
    

    static void TransferAmount()
    {
   // TODO: implement this service (see Section 3 requirements)
   Console.Write("Enter sender account number: ");
   string senderAccount = Console.ReadLine();

   Console.Write("Enter receiver account number: ");
   string receiverAccount = Console.ReadLine();
   int senderIndex = accountNumbers.IndexOf(senderAccount);
   int receiverIndex = accountNumbers.IndexOf(receiverAccount);
   if (senderIndex == -1 || receiverIndex == -1)
   {
       Console.WriteLine("One or both accounts not found.");
       return;
   }
   
   Console.Write("Enter transfer amount: ");
   double amount = double.Parse(Console.ReadLine());
   if (amount <= 0 || amount > balances[senderIndex])
   {
       Console.WriteLine("Invalid transfer amount.");
       return;
   }
   balances[senderIndex] = balances[senderIndex] - amount;

   balances[receiverIndex] = balances[receiverIndex] + amount;
   Console.WriteLine("Transfer successful.");
   Console.WriteLine("Sender new balance: " + balances[senderIndex]);
   Console.WriteLine("Receiver new balance: " + balances[receiverIndex]);
    }
    
    
    static void ListAllAccounts()
    {
        for (int i = 0; i < accountNumbers.Count; i++)
        {
            Console.WriteLine("Name: " + customerNames[i]);
            Console.WriteLine("Account Number: " + accountNumbers[i]);
            Console.WriteLine("Balance: " + balances[i]);
        }
    }
    static void CountAccounts()
    {
        Console.WriteLine("Total accounts: " + accountNumbers.Count);
    }
    
    static void Main(string[] args)
    {
        
        bool exitApp = false;
        while (!exitApp)
        {
            Console.WriteLine("\n===== Welcome to Spark Bank =====");
            Console.WriteLine("1. Add New Account");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Show Balance");
            Console.WriteLine("5. Transfer Amount");
            Console.WriteLine("6. List All Accounts");
            Console.WriteLine("7. Count Accounts");
            Console.WriteLine("8. Exit");

            Console.Write("Choose an option: ");
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                continue;
            }

            switch (choice)
            {
                    
                case 1:
                    AddAccount();
                    break;
                case 2:
                    DepositMoney();
                    break;
                case 3:
                    WithdrawMoney();
                    break;
                case 4:
                    ShowBalance();
                    break;
                case 5:
                    TransferAmount();
                    break;
                case 6:
                    // TODO: call your first custom service function here
                    ListAllAccounts();
                    break;
                case 7:
                    // TODO: call your second custom service function here
                    CountAccounts();

                    break;
                case 8:
                    exitApp = true;
                    Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                    break;
                
                default:
                    Console.WriteLine("Invalid option, please choose between 1 and 8.");
                    break;
            }
            
    }
       
        
        
        
        
        
    }
}