namespace KR_2.ServiceInterfaces
{
    public interface ISolve 
    {
        /// <summary>
        /// Вычисление суммы цифр числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns>long</returns>
        long SumDigits(long number);

        /// <summary>
        /// Проверка, является ли число треугольным
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        bool IsTriangleNumber(long number);

        /// <summary>
        /// Проверка разности между цифрами числа
        /// </summary>
        /// <param name="number"></param>
        /// <param name="k"></param>
        /// <returns>bool</returns>
        bool IsDifference(long number, int k);

        /// <summary>
        /// Проверка числа на условия
        /// </summary>
        /// <param name="number"></param>
        /// <param name="k"></param>
        /// <returns>bool</returns>
        bool CheckNumber(long number, int k);
    }
}
