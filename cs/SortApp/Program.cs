using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод чисел
            int[] nums = new int[7];
            Console.WriteLine("Введите семь чисел");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{i + 1}-е число: ");
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            //Сортировка
            int temp;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            //Вывод
            Console.WriteLine("Вывод отсортированного массива");
            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
