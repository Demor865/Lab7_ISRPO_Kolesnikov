using System;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1
            Console.WriteLine("    Задание 1.1    ");
            string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
            for (int i = days.Length - 1; i >= 0; i--)
            {
                Console.Write(days[i] + " ");
            }
            Console.WriteLine();

            // 1.2
            Console.WriteLine("\n    Задание 1.2    ");
            double[] temps = { -5.5, -2.0, 0.0, 3.5, 5.0, 2.0, -1.5 };
            foreach (double t in temps)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();

            // 2
            Console.WriteLine("\n    Задание 2    ");
            int[] prices = { 120, 45, 300, 80, 15, 210 };
            int sum = 0;
            int countOver100 = 0;
            foreach (int price in prices)
            {
                sum += price;
                if (price > 100) countOver100++;
            }
            double avg = (double)sum / prices.Length;
            Console.WriteLine($"Сумма: {sum}, средняя: {avg}, дороже 100: {countOver100}");

            // 3
            Console.WriteLine("\n    Задание 3    ");
            int min = prices[0];
            int max = prices[0];
            int maxIndex = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min) min = prices[i];
                if (prices[i] > max)
                {
                    max = prices[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Минимум: {min}, индекс самого дорогого: {maxIndex}");

            // 4
            Console.WriteLine("\n    Задание 4    ");
            int[] balance = { 100, -50, 20, -5, 0, 75 };
            for (int i = 0; i < balance.Length; i++)
            {
                if (balance[i] < 0) balance[i] = 0;
            }
            foreach (int b in balance) Console.Write(b + " ");
            Console.WriteLine();

            // 5
            Console.WriteLine("\n    Задание 5    ");
            int[] nums = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("В обратном порядке: ");
            for (int i = 4; i >= 0; i--) Console.Write(nums[i] + " ");

            int evenCount = 0;
            foreach (int n in nums)
            {
                if (n % 2 == 0) evenCount++;
            }
            Console.WriteLine($"\nЧетных чисел: {evenCount}");

            // 6
            Console.WriteLine("\n    Задание 6    ");
            string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
            Console.Write("Введите имя для поиска: ");
            string searchName = Console.ReadLine();
            int foundIndex = -1;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == searchName)
                {
                    foundIndex = i;
                    break;
                }
            }
            if (foundIndex != -1) Console.WriteLine($"Позиция: {foundIndex}");
            else Console.WriteLine("Не найдено");

            // Журнал оценок
            Console.WriteLine("\n    Журнал оценок    ");
            int[] grades = { 5, 4, 3, 2, 5, 4, 5, 4 };
            Console.Write("Оценки: ");
            foreach (int g in grades) Console.Write(g + " ");
            Console.WriteLine();

            int gradesSum = 0;
            int maxGrade = grades[0];
            int minGrade = grades[0];
            int count2 = 0;
            int count5 = 0;

            foreach (int g in grades)
            {
                gradesSum += g;
                if (g > maxGrade) maxGrade = g;
                if (g < minGrade) minGrade = g;
                if (g == 2) count2++;
                if (g == 5) count5++;
            }

            double gradesAvg = (double)gradesSum / grades.Length;
            Console.WriteLine($"Средняя: {gradesAvg}");
            Console.WriteLine($"Макс: {maxGrade}, Мин: {minGrade}");
            Console.WriteLine($"Двоек: {count2}, Пятерок: {count5}");

            if (gradesAvg >= 4.5) Console.WriteLine("Отличник");
            else if (gradesAvg >= 3.5) Console.WriteLine("Хорошист");
            else Console.WriteLine("Есть над чем поработать");

            // Допы
            Console.WriteLine("\n    Доп. задание    ");
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Console.Write("Перевернутый массив: ");
            foreach (int a in arr) Console.Write(a + " ");
            Console.WriteLine();
        }
    }
}