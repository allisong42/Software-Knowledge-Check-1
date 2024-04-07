using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }

        public void NoInt()
        {
            Console.WriteLine("One or more of the numbers is not an int");
        }

        /*public int ParseCheckInt()
        {
            var firstInput = Console.ReadLine();
            var secondInput = Console.ReadLine();

            if (int.TryParse(firstInput, out int firstOutput) && int.TryParse(secondInput, out int secondOutput))
            {
                return (firstOutput, secondOutput);
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
            }
        }*/
    }
}

