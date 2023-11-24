 //Задача 1.
            // Console.Clear();
            // System.Console.WriteLine("Введите число: ");
            // int i =  Convert.ToInt32(Console.ReadLine()!);
            
            // if (i%7 == 0 && i%23 == 0)
            // System.Console.WriteLine("Число верно!");
            // else
            // System.Console.WriteLine("Введите другое число");
            
            
 // Задача 2.

        // Console.Clear();

        // System.Console.WriteLine("Введите значение X : ");
        // int X =  int.Parse(Console.ReadLine()!);
            
        // System.Console.WriteLine("Введите значение Y : ");
        // int Y =  int.Parse(Console.ReadLine()!);

        // if (X > 0 && Y > 0) 
        // {
        //     System.Console.WriteLine("1 координатная четверть плоскости");
        // }

        // else if (X < 0 && Y < 0)
        // {
        //     System.Console.WriteLine("3 координатная четверть плоскости");
        // }

        // else if (X < 0 && Y > 0)
        // {
        //     System.Console.WriteLine("2 координатная четверть плоскости");
        // }

        // else if (X > 0 && Y < 0)
        // {
        //     System.Console.WriteLine("2 координатная четверть плоскости");
        // }
        // else 
        //     System.Console.WriteLine();

//Задача 3

        // Console.Clear();
        //     System.Console.WriteLine("Введите число от 10 до 99:  ");
        // int number = int.Parse(Console.ReadLine()!);
        // if (number >= 10 && number <= 99)  
        // {
        //     int firstDigit = number/10;
        //     int secondDigit = number%10;
        //     int maxDigit = Math.Max(firstDigit,secondDigit);
        
        //     System.Console.WriteLine(maxDigit);
        // }
        // else 
        // System.Console.WriteLine("Ошибка!Введите число от 10 до 99");

 // Задача 4

    Console.Clear();
    System.Console.WriteLine("Введите натуральное число: ");
    int i = int.Parse(Console.ReadLine()!);
    if(i < 10)
    {
        System.Console.WriteLine(i);
    }
    else 
    {
        while(i >= 10)
        {
            int lastDigit = i%10;
            i/=10;

            if(i > 0)
            {
                System.Console.Write(lastDigit + ",");
            }
        }

    }
        System.Console.Write(i);
        
    

    