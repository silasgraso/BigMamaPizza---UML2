public class EnterConsole
{
    public static void ChooseConsole()
    {
        int navConsole = 0;
        bool parseOkay = false;

        while (navConsole == 0)
        {
            Console.WriteLine("1. Log ind som Admin");
            Console.WriteLine("2. Log ind som Kunde");

            Console.Write("\n Indtast venligst din handling som heltal: ");

            //checks the input since it have to be a int
            parseOkay = int.TryParse(Console.ReadLine(), out navConsole);

            if (parseOkay == false) // if the integer is not a int
            {
                Console.WriteLine(Environment.NewLine + "Du skal indtaste et tal enten 1 eller 2" + Environment.NewLine);
            }
            else if (navConsole < 0 || navConsole > 6) // if the integer is a negativ int or above 6
            {
                Console.WriteLine(Environment.NewLine + "Det indtastet tal er hverken 1 eller 2" + Environment.NewLine);
            }
            // if the statement is between 1-6 following will happen
            else if (navConsole == 1)
            {
                Console.Clear();
                Admin.EnterAdmin();
            }
            else if (navConsole == 2)
            {
                Console.Clear();
                CustomerAdmin.EnterCustomerAdmin();
            }

        }
    }
}