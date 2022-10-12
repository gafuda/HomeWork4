// Задача 1

// int[] array = Enumerable.Range(0, 8).Select(i => i % 2 == 0 ? 0 : 1).ToArray();
// foreach (var item in array) {
//             Console.WriteLine(item);
//         }


// Задача 2

// int[] array = Enumerable.Range(0, 9).ToArray();
// foreach (var item in array) {
//             Console.WriteLine(item);
//         }
// int sum = array.Sum();
//     Console.WriteLine(sum);

// Задача 3
// С решением помог старшекурсник, решение разобрала 
// Console.WriteLine("Введите размер массива:  ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("массив: ");
// PrintArray(numbers);
// int count1 = 0;
// int count2 = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count1++;

// for (int y = 0; y < numbers.Length; y++)
// if (numbers[y] % 2 == 1)
// count2++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count1} из них чётные и {count2} из них нечётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 4
// int[] array = Enumerable.Range(1, 123).ToArray();
// int count=0;
// for(var i=0; i<array.Length;i++)
// {
//    if(i > 10 && i < 99)
//      count++;
// }
// foreach (var item in array) {
//             Console.WriteLine(item);
//         }
// Console.WriteLine("Всего " + count + " элементов");