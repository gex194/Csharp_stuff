using System;

namespace KR_1
{
    public class Program
    {
        /*
         Параболла с вершиной в точке (4,8) и пересекающая ось Ох в точках (0,0) и (8,0). В точке (4,8) находится центр окружности
         радиусом r=4. Прямая проходит параллельно оси Oy пересекает ось Ox в точке (4,0)
         уравнение окружности: (x^2 - 4) + (y^2 - 8) = 4
         если меньше или равно 4 => Внутри окружности
         Больше 4 => снаружи окружности

         уравнение параболлы: y = -2x^2 + 4x
         если меньше или равно 0 => внутри
         если больше 0 => снаружи
         */
        bool IsInCircle(float x, float y)
        {
            return ((x - 4.0) * (x - 4.0) + (y - 8) * (y - 8) <= 4) ? true : false;
        }

        bool IsInParabola(float x, float y)
        {
            return ((y - 2 * x * x + 4 * x) <= 0) ? true : false;
        }

        bool IsLessThanFour(float x)
        {
            return (x <= 4) ? true : false;
        }

        public int CheckArea(float x, float y)
        {
            bool bCircle = IsInCircle(x, y);
            bool bParabola = IsInParabola(x, y);
            bool bLine = IsLessThanFour(x);

            if (bCircle == true && bParabola == true && bLine == true)
            {
                return 1;
            }
            else if (bCircle == true && bParabola == true && bLine == false)
            {
                return 2;
            }
            else if (bCircle == false && bParabola == true && bLine == true)
            {
                return 3;
            }

            else if (bCircle == false && bParabola == true && bLine == false)
            {
                return 4;
            }

            else if (bCircle == true && bParabola == false && bLine == true)
            {
                return 5;
            }
            else if (bCircle == true && bParabola == false && bLine == false)
            {
                return 6;
            }
            else if (bCircle == false && bParabola == false && bLine == true)
            {
                return 7;
            }
            else if (bCircle == false && bParabola ==false && bLine == false)
            {
                return 8;
            }
            else
            {
                throw new Exception("Вы ввели неверные данные");
            }
        }

        static void Main(string[] args)
        {
            //Считываем данные, вводимые пользователем
            Console.WriteLine("введите x");
            float x = float.Parse(Console.ReadLine());

            Console.WriteLine("введите y");
            float y = float.Parse(Console.ReadLine());
            //Инициализируем экземпляр нашей программы
            Program mathProgram = new Program();
            //Выводим результат
            var result = mathProgram.CheckArea(x, y);
            Console.Write("Ваш результат: ");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
