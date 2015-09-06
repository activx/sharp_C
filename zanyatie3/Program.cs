using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zanyatie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел в массиве: ");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите число " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());

            }

            QuickSort(array, 0, size - 1);
            // Отпечатаем массив
            for (int i = 0; i < size; i++) Console.WriteLine("Элемент " + (i) + ":" + array[i]);
        }
        /**
         * Делитель массива на части
         **/
        static int Partition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }


        /// <summary>
        /// Быстрая сортировка (ОСТОРОЖНО РАБОТАЕТ В РЕКУРСИИ)
        /// </summary>
        /// <param name="array">Массив для перебора</param>
        /// <param name="start">Начальный элемент сортировки </param>
        /// <param name="end">Конечный элемент сортировки</param>
        static void QuickSort(int[] array, int start, int end)
        {

            if (start >= end)
            {
                return;
            }

            int marker = Partition(array, start, end); // Делим массив на части
            QuickSort(array, start, marker - 1); // Сортируем до маркера
            QuickSort(array, marker + 1, end); // Сортируем после маркера
        }
    }
}
 
