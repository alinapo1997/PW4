using System;
using System.Threading;

namespace PW4
{
    internal class Program
    {
        /// <summary>
        /// Случайная матрица
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region RandomMatrix [Случайная матрица]

            Console.WriteLine("Давайте выведем случайную матрицу.\nВведите количество строк: ");
            int stringCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int columnCount = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[,] matrix = new int[stringCount, columnCount];
            int sumMatrixNumbers = 0;
            for (int i = 0; i < stringCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    int randomValue = random.Next(0, 100);
                    matrix[i, j] = randomValue;
                    sumMatrixNumbers += randomValue;
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine($"Сумма всех чисел в матрице = {sumMatrixNumbers}" +
                $"\nНажмите любую клавишу, чтобы перейти к другому приложению...");
            Console.ReadKey();
            #endregion

            #region SmallestSequenceElement [Наименьший элемент в последовательности]
            Console.WriteLine("\n__________________________Наименьший элемент в последовательности__________________________\n");
            Console.WriteLine("Введите длину последовательности: ");
            int length = int.Parse(Console.ReadLine());
            int[] mArray = new int[length];
            Console.WriteLine("Введите целые числа, разделяя их с помощью Enter: ");
            for (int i = 0; i < length; i++)
            {
                mArray[i] = int.Parse(Console.ReadLine());
            }
            int minValue = int.MaxValue;
            foreach (var i in mArray)
            {
                minValue = i < minValue ? i : minValue;
            }
            Console.WriteLine($"\nНаименьший элемент последовательности: {minValue}");
            Console.WriteLine($"\nНажмите любую клавишу, чтобы перейти к другому приложению...");
            Console.ReadKey();
            #endregion
            
            #region GuessNumber [Игра «Угадай число»]
            Console.WriteLine("\n__________________________Игра «Угадай число»__________________________\n");

            Console.WriteLine(".Привет! Давайте сыграем в угадай-ку! Если надоест играть, просто нажмите Enter. \nВведите любое целое число: ");
            int maxValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Загадываем число...");
            int randomNumber = new Random().Next(0, maxValue);
            Thread.Sleep(800);
            
            while (true)
            {
                Console.WriteLine($"Угадайте, какое число было загадано от 0 до {maxValue}");
                string inputValue = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputValue.Trim()))
                {
                    Console.WriteLine($"Выход из игры. Загаданное число - {randomNumber}");
                    break; }
                int userNumber = int.Parse(inputValue);
                if (userNumber > randomNumber)
                {
                    Console.WriteLine($"Число {userNumber} больше загаданного");
                }
                else if (userNumber < randomNumber)
                {
                    Console.WriteLine($"Число {userNumber} меньше загаданного");
                }
                else
                {
                    Console.WriteLine($"Поздравляем, вы угадали загаданное число - {randomNumber}");
                    Console.ReadKey();
                }

            }
            Console.WriteLine($"\nНажмите любую клавишу, чтобы завершить...");
            Console.ReadKey();
            #endregion
        }
    }
}
