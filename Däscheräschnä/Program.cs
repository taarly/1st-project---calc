internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("~~~~~~~~~~~~~~Projekt Däschäräschnä~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("---------------------------------------------------------");

            //Input first number

            double number1;
            Console.WriteLine("\tEnter your first number:");
            Console.Write("\t"); string number1string = Console.ReadLine();
            bool bool1 = double.TryParse(number1string, out number1);
            if (!bool1)
            {
                Console.WriteLine("\tDepp");
                continue;
            }

            //Input second number

            double number2;
            Console.WriteLine("\tEnter your second number:");
            Console.Write("\t"); string number2string = Console.ReadLine();
            bool bool2 = double.TryParse(number2string, out number2);
            if (!bool2)
            {
                Console.WriteLine("\tDepp");
                continue;
            }

            //Input operator

            char op;
            Console.WriteLine("\tPlease enter your operator");
            Console.WriteLine("\tOptions are: + - * /");
            Console.Write("\t"); string opstring = Console.ReadLine();

            //needs work - needs to check if there is anything else but the operators - wip

            bool bool3 = char.TryParse(opstring, out op);
            if (!bool3)
            {
                Console.WriteLine("\tDepp");
                continue;
            }
            Console.WriteLine("---------------------------------------------------------");

            //Output
            //if Statement, can't divide by 0

            if (number2 == 0 && op == '/')
            {
                Console.WriteLine("Don't divide by 0 you idiot!");
                continue;
            }


            //addition
            if (op == '+')
            {
                Console.WriteLine($"\t{number1} {op} {number2} = " + (number1 + number2));
            }

            //subtraction
            else if (op == '-')
            {
                Console.WriteLine($"\t{number1} {op} {number2} = " + (number1 - number2));
            }

            //division
            else if (op == '/')
            {
                Console.WriteLine($"\t{number1} {op} {number2} = " + (number1 / number2));
            }

            //multiplication
            else if (op == '*')
            {
                Console.WriteLine($"\t{number1} {op} {number2} = " + (number1 * number2));
            }
        }
    }
}
