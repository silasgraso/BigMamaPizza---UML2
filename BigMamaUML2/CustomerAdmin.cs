using System.Runtime.InteropServices;

public class CustomerAdmin
{
    
    public static void EnterCustomerAdmin()
    {
        CustomerRepository customerRepository = new CustomerRepository();
        
        string adminConsole = "notExit";
        while (adminConsole != "5")
        {
            Console.Clear();
            string actionOne = "1. Tilføje en ny bruger";
            string actionTwo = "2. Slette en bruger";
            string actionThree = "3. Opdatere en bruger";
            string actionFour = "4. Søge efter en bruger";

            string printStartActions = actionOne + Environment.NewLine +
                                        actionTwo + Environment.NewLine +
                                        actionThree + Environment.NewLine +
                                        actionFour + Environment.NewLine +
                                        "5. Exit";
            
            Console.WriteLine("Indtast venligst din handling som heltal");
            Console.WriteLine(printStartActions);
            adminConsole = Console.ReadLine();

            if (adminConsole == "1")
            {
                Console.WriteLine("Du har valgt: " + actionOne);

                string conditionvariable = "yes";
                while (conditionvariable == "yes")
                {

                    int customerID;
                    string Name;
                    string Mail;
                    string Adress;

                    //Add Customer
                    Console.Write("Giv brugeren et ID: ");
                    customerID = int.Parse(Console.ReadLine());

                    Console.Write("Giv brugeren et navn: ");
                    Name = Console.ReadLine();

                    Console.Write("Giv Mail: ");
                    Mail = Console.ReadLine();

                    Console.Write("Giv Adresse: ");
                    Adress = Console.ReadLine();


                    customerRepository.AddCustomer(new Customer(customerID, Name, Mail, Adress));

                    customerRepository.PrintCustomer();

                    Console.Write("vil du tilføje endnu en bruger (Yes/no): ");
                    conditionvariable = Console.ReadLine();


                }
            }
            else if (adminConsole == "2")
            {
                Console.WriteLine("Du har valgt: " + actionTwo);
                

                string conditionvariable = "yes";
                while (conditionvariable == "yes")
                {
                
                    string Name;

                    customerRepository.PrintCustomer();
                    Console.Write("skriv navnet på den bruger du gerne vil slette: ");

                    Name = Console.ReadLine();

                    customerRepository.DeleteCustomer(Name);

                    customerRepository.PrintCustomer();

                    Console.Write("vil du slette endnu en bruger (yes/no): ");
                    conditionvariable = Console.ReadLine();

                }
            }
            else if (adminConsole == "3")
            {
                Console.WriteLine("Du har valgt: " + actionThree);

                string conditionvariable = "yes";
                while (conditionvariable == "yes")
                {

                    int customerID;
                    string Name;
                    string Mail;
                    string Adress;

                    customerRepository.PrintCustomer();

                    //Update Customer

                    Console.Write("skriv navn på den bruger du ønsker at ændre: ");
                    Name = Console.ReadLine();


                    customerRepository.DeleteCustomer(Name);

                    Console.Write("Giv Nummer: ");
                    customerID = int.Parse(Console.ReadLine());

                    Console.Write("Giv Navn: ");
                    Name = Console.ReadLine();

                    Console.Write("Giv Mail: ");
                    Mail = Console.ReadLine();

                    Console.Write("Giv Adresse: ");
                    Adress = Console.ReadLine();


                    customerRepository.AddCustomer(new Customer(customerID, Name, Mail, Adress));

                    customerRepository.PrintCustomer();

                    Console.Write("vil du ændre endnu en bruger (yes/no): ");
                    conditionvariable = Console.ReadLine();


                }
                
            }

        }
    }
}