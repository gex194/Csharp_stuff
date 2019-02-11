using KR_2.ServiceInterfaces;
using KR_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_2
{
    /*
     Числа, сумма цифр которых является теругольным числом и разность между соседними цифрами равна k
     Треугольное число = n(n+1)/2
     */
    public class Interface
    {
        static void Main(string[] args)
        {
            char ch = '0';
            ISolve solve = new Solve();
            IInputOutput prog = new InputOutput(solve);

            do
            {
                Console.WriteLine("Press [N] to count the numbers\n");
                Console.WriteLine("Press [P] to print the numbers in the bound\n");
                Console.WriteLine("Press [T] to print the triangle numbers\n");
                Console.WriteLine("Press [Q] to quit the program\n");
                ch = Console.ReadKey().KeyChar;

                if ((ch == 'P') || (ch == 'p'))
                {
                    prog.PrintNumbers();
                }
                else if ((ch == 'T') ||(ch == 't'))
                {
                    prog.PrintTriangleNumbers();
                }
                else if ((ch == 'N') || (ch == 'n'))
                {
                    prog.InputNumbers();
                }
            }
            while ((ch != 'Q') && (ch != 'q'));
            Console.ReadKey();
        }
    }
}
