using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that will output the sum of 
               2 integer args provided by the command line.If
               the wrong number of arguments is supplied by the 
               user then output a friendly description of what the 
               user did wrong and what they were supposed to do.Let’s
               assume this is a program for children learning basic addition.
               sure the program gracefully recognises non - integer numbers but 
               outputs a message saying something like “we’re not ready for that yet!”*/
            if (args.Length == 2)
            {
                try
                {
                    int n1 = Convert.ToInt32(args[0]);
                    int n2 = Convert.ToInt32(args[1]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(n1 + n2);
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    help("SORRY I CAN'T ADD THOSE NUMBERS, LETS TRY SOME SMALLER NUMBERS");
                }
                catch (FormatException)
                {        
                    try
                    {
                        Convert.ToSingle(args[0]);
                        Convert.ToSingle(args[1]);
                      help("HEY THATS NOT RIGHT, THOSE ARE NOT 2 WHOLE NUMBERS");
                    }
                    catch
                    { 
                    help("HEY THATS NOT RIGHT, THOSE ARE NOT NUMBERS");
                    }
                }
            }
            else if (args.Length > 2)
            {
                help("HEY WERE NOT READY FOR THAT YET");
            }
            else if (args.Length < 2)
            {
                help(" HEY YOU DIDNT ENTER 2 NUMBERS TO ADD :(");
            }
           
            void help(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR: ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(message);
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("THIS PROGRAM IS DESGINED TO DO A SUM OF TWO NUMBERS");
                Console.WriteLine("PLEASE ENTER TWO NUMBERS YOU WOULD LIKE TO ADD ;)");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("LETS TRY AGAIN");
                Console.WriteLine("GOOD LUCK");
                Console.ResetColor();
            }
        }
    }
}
