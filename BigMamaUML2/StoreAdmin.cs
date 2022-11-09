using System.Runtime.InteropServices;

public class Admin
{
    
    public static void EnterAdmin()
    {
        PizzaRepository pizzaRepository = new PizzaRepository();
        
        int adminConsole = 0;
        while (adminConsole != 6)
        {
            bool parseOkay;
            
            string actionOne = "1. Tilføje en ny pizza til pizzamenuen";
            string actionTwo = "2. Slette en pizza fra pizzamenuen";
            string actionThree = "3. Opdatere en pizza";
            string actionFour = "4. Søge efter en pizza";
            string actionFive = "5. Vise pizzamenuen";

            string printStartActions = actionOne + Environment.NewLine +
                                        actionTwo + Environment.NewLine +
                                        actionThree + Environment.NewLine +
                                        actionFour + Environment.NewLine +
                                        actionFive + Environment.NewLine + Environment.NewLine +
                                        "6. Exit";
            

            Console.WriteLine(printStartActions);

            Console.Write("Indtast venligst din handling som heltal: ");

            //checks the input since it have to be a int
            parseOkay = int.TryParse(Console.ReadLine(), out adminConsole);
            
            if (parseOkay == false) // if the integer is not a int
            {
                Console.WriteLine(Environment.NewLine + "Du skal indtaste et tal mellem 1-6" + Environment.NewLine);
            }
            else if (adminConsole < 0 || adminConsole > 6) // if the integer is a negativ int or above 6
            {
                Console.WriteLine(Environment.NewLine + "Det indtastet tal er ikke mellem 1-6" + Environment.NewLine);
            }
            // if the statement is between 1-6 following will happen
            else if (adminConsole == 1)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt: \n" + actionOne);

                string conditionvariable = "yes";
                while (conditionvariable == "yes")
                {

                    int pizzaID;
                    string pizzaName;
                    double pizzaPrice;
                    string pizzaDescription;

                    //Add Pizza
                    Console.Write("Giv pizza et number: \n");
                    parseOkay = int.TryParse(Console.ReadLine(), out pizzaID);
                    while (parseOkay == false)
                    {
                        Console.Write("Giv pizza et number, den indtastet værdi er ikke et tal: ");
                        parseOkay = int.TryParse(Console.ReadLine(), out pizzaID);
                    }

                    Console.Write("Giv pizza et navn: ");
                    pizzaName = Console.ReadLine();

                    Console.Write("Giv pizza en pris: ");
                    parseOkay = double.TryParse(Console.ReadLine(), out pizzaPrice);
                    
                    while (parseOkay == false)
                    {
                        Console.Write("Giv pizza en pris, den indtastet værdi er ikke et tal: ");
                        parseOkay = int.TryParse(Console.ReadLine(), out pizzaID);
                    }

                    Console.Write("Giv pizza en beskrivelse: ");
                    pizzaDescription = Console.ReadLine();


                    pizzaRepository.AddPizza(new Pizza(pizzaID, pizzaName, pizzaPrice, pizzaDescription));

                    pizzaRepository.PrintMenu();

                    Console.Write("vil du tilføje endnu en pizza (Yes/no): ");
                    conditionvariable = Console.ReadLine();
                    Console.Clear();


                }
            }
            else if (adminConsole == 2 && pizzaRepository.pizzaMenuExist() == true)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt: \n" + actionTwo);
                

                string conditionvariable = "yes";
                while (conditionvariable == "yes")
                {
                
                    string pizzaName;

                    pizzaRepository.PrintMenu();
                    Console.Write("skriv navnet på den pizza du gerne vil slette: ");

                    pizzaName = Console.ReadLine();

                    pizzaRepository.DeletePizza(pizzaName);

                    pizzaRepository.PrintMenu();

                    Console.Write("vil du slette endnu en pizza (yes/no): ");
                    conditionvariable = Console.ReadLine();
                    Console.Clear();

                }
            }
            else if (adminConsole == 3)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt: \n" + actionThree);

                string conditionvariable = "yes";
                while (conditionvariable == "yes")
                {

                    int pizzaID;
                    string pizzaName;
                    double pizzaPrice;
                    string pizzaDescription;

                    pizzaRepository.PrintMenu();

                    //Update Pizza

                    Console.Write("skriv navn på den pizza du ønsker at ændre: ");
                    pizzaName = Console.ReadLine();


                    pizzaRepository.DeletePizza(pizzaName);

                    Console.Write("Giv pizza et number: ");
                    pizzaID = int.Parse(Console.ReadLine());

                    Console.Write("Giv pizza et navn: ");
                    pizzaName = Console.ReadLine();

                    Console.Write("Giv pizza en pris: ");
                    pizzaPrice = double.Parse(Console.ReadLine());

                    Console.Write("Giv pizza en beskrivelse: ");
                    pizzaDescription = Console.ReadLine();


                    pizzaRepository.AddPizza(new Pizza(pizzaID, pizzaName, pizzaPrice, pizzaDescription));

                    pizzaRepository.PrintMenu();

                    Console.Write("vil du ændre endnu en pizza (yes/no): ");
                    conditionvariable = Console.ReadLine();
                    Console.Clear();
                }
            }
            else if (adminConsole == 4)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt: \n" + actionFour);

                string conditionvariable = "no";
                while (conditionvariable == "no")
                {
                    if (pizzaRepository.pizzaMenuExist() == false)
                    {
                        Console.WriteLine("Der eksisterer ingen pizzaer endnu");
                    }
                    else
                        pizzaRepository.PrintMenu();

                    Console.Write("skriv pizzanavn på pizzaen du ønsker at søge frem: ");
                    Pizza pizzaName = pizzaRepository.ReadPizzaName(Console.ReadLine());

                    Console.Write("Er du færdig med at søge efter en pizza (yes/no): ");
                    conditionvariable = Console.ReadLine();
                    Console.Clear();

                }
            }
            else if (adminConsole == 5)
            {
                Console.Clear();
                Console.WriteLine("Du har valgt: \n" + actionFive);

                string conditionvariable = "no";
                while (conditionvariable == "no")
                {
                    if (pizzaRepository.pizzaMenuExist() == false)
                    {
                        Console.WriteLine("Der eksisterer ingen pizzaer endnu");
                    }
                    else
                        pizzaRepository.PrintMenu();

                    Console.Write("Er du færdig med at se menuen skriv (yes): ");
                    conditionvariable = Console.ReadLine();
                    Console.Clear();

                }
            }

        }
    }
}