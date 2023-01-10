class Program
{
    static void Main()
    {
        System.Console.WriteLine("******** Merritt Bank ********");
        System.Console.WriteLine("::Login::");

        string userName = null, password = null;

        System.Console.WriteLine("Username: ");
        userName = System.Console.ReadLine();

        System.Console.WriteLine("Password: ");
        password = System.Console.ReadLine();

        if(userName == "system" && password == "admin")
        {
            int mainMenuChoice = -1;
            do
            {
                System.Console.WriteLine("\n:: Main Menu ::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Funds Transfer");
                System.Console.WriteLine("4. Funds Transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                System.Console.WriteLine("Enter Choice:");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1: CustomersMenu(); break;
                    case 2: AccountsMenu(); break;
                    case 3: //show funds transfer choice
                        break;
                    case 4: //show funds transfer statement choice
                        break;
                    case 5: //show account statement choice
                        break;
                }
            } while (mainMenuChoice != 0);
        }
        else
        {
            System.Console.WriteLine("Invalid Username or Password");
        }

        System.Console.WriteLine("Thank you. Come Again");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        int customerMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n:::Customer Menu:::");
            System.Console.WriteLine("1.Add Customer");
            System.Console.WriteLine("2.Delete Customer");
            System.Console.WriteLine("3.Update Customer");
            System.Console.WriteLine("4.View Customer");
            System.Console.WriteLine("0.Return to Main Menu");

            System.Console.WriteLine("Enter Choice: ");
            customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (customerMenuChoice != 0);
    }

    static void AccountsMenu()
    {
        int accountMenuChoice = -1;

        do
        {
            System.Console.WriteLine("\n:::Account Menu:::");
            System.Console.WriteLine("1.Add Account");
            System.Console.WriteLine("2.Delete Account");
            System.Console.WriteLine("3.Update Account");
            System.Console.WriteLine("4.View Account");
            System.Console.WriteLine("0.Return to Main Menu");

            System.Console.WriteLine("Enter Choice: ");
            accountMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

        } while (accountMenuChoice != 0);
    }
      
}
