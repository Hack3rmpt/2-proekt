Random rn = new Random();
int userNum, randomNum;
randomNum = rn.Next(100);
int action = 1;

    while (action != 4)
    {
        Console.WriteLine("Выберете действие:");
        Console.WriteLine("1.Угадай число \n2.Таблица умножения \n3.Вывод делителей числа\n4.Выход из программы");
        action = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (action == 1)
        {
            Console.WriteLine("угадай число от 0 до 100 ");
            while (true)
            {
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum > randomNum) Console.WriteLine("Надо меньше");
                else if (userNum < randomNum) Console.WriteLine("Надо больше");
                else
                {
                    Console.WriteLine("Вы угадали число\n");
                    break;
                }
            }
        }

        else if (action == 2)
        {
            int[,] matrix = new int[9, 9];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    matrix[i - 1, j - 1] = i * j;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(matrix[i, j] + "\t");

                }
                Console.WriteLine();
            }

        }
        else if (action == 3)
        {
            int count = 0;
            Console.Write("Введите число: ");
            userNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Делители числа: ");
            while (userNum != count)
            {
                count++;
                if (userNum % count == 0)
                {
                    Console.Write(count + " ");
                }
                else continue;
            }
            Console.WriteLine();
        }

        else if (action == 4) break;
    }


  
