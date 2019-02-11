using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_2.ServiceInterfaces
{
    public interface IInputOutput
    {
        /// <summary>
        /// Вывести список чисел
        /// </summary>
        void PrintNumbers();

        /// <summary>
        /// Вывести список треугольных чисел
        /// </summary>
        void PrintTriangleNumbers();

        /// <summary>
        /// Посчитать список чисел
        /// </summary>
        void InputNumbers();
    }
}
