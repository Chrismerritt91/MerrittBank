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
                    case 1: //show customers choice
                        break;
                    case 2: //show customers choice
                        break;
                    case 3: //show customers choice
                        break;
                    case 4: //show customers choice
                        break;
                    case 5: //show customers choice
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
    
}
