// int n = 100;
// int i = 1;

// while (i <= n)
// {
//    // Console.WriteLine(i);
//     Console.Write(i);
//     Console.Write(' ');
//     i = i + 1;
// }


// int a;
// int b;

// a = 13;
// b = 32;

//   if (a > b){
//   Console.WriteLine($"первое число больше");
//   }
//   if (a == b){
//     Console.WriteLine($"числа равны");
//   }
//   if (a < b){
//   Console.WriteLine($"второе число больше");
//   }



    {
        Console.WriteLine("Введите три числа:");

        // Ввод трех чисел с клавиатуры
        Console.Write("Первое число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Второе число: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Третье число: ");
        int number3 = int.Parse(Console.ReadLine());

        // Нахождение максимального числа
        int maxNumber = FindMax(number1, number2, number3);

        // Вывод результата
        Console.WriteLine($"Максимальное число: {maxNumber}");

        Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
    }

    static int FindMax(int a, int b, int c)
    {
        // Используем встроенную функцию Math.Max для нахождения максимального числа
        return Math.Max(Math.Max(a, b), c);
    }
