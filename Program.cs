using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                int input;

                input = CollectInput();
                DisplayTable(input);

                Console.WriteLine("Do you wish to conitue?  (Y/N)");
                string answer = Console.ReadLine();

                if (answer == "Y" || answer == "yes" || answer == "y")
                {

                }

                else
                {
                    break;
                }
            }
        }

        public static int CollectInput()

        {
            Console.WriteLine("Enter an integer.");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                Console.WriteLine("Invalid input. \nTry again!");
                return CollectInput();
            }
            else
            {
                return input;
            }
        }

        public static int SquareInput(int input)
        {
            return Convert.ToInt32( Math.Pow(input, 2));
        }

        public static int CubeInput (int input)
        {
            return Convert.ToInt32(Math.Pow(input, 3));
        }

        public static void DisplayTable(int input)
        {

            Console.WriteLine("Number    Square    Cubed  \n=======   =======   =======\n");

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"{i + 1}          {SquareInput(i+1)}         {CubeInput(i+1)}");
            }
            
                   
        }

            

                
            
        
    }
}
