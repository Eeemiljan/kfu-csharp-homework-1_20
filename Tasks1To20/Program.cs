// Задание 1
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Threading;

class Program
{
    static void Main()
    {
       // Задание 1
       Console.WriteLine($"{Math.E:F1}");

       // Задание 2
       Console.WriteLine(50);
       Console.Write(10);

       // Задание 3
       Random random = new Random();

       Console.WriteLine(random.Next());
       Console.WriteLine(random.Next());
       Console.WriteLine(random.Next());
       Console.WriteLine(random.Next());

       // Задание 4
       Console.Write("Введите число: ");
       int number = int.Parse(Console.ReadLine());
       Console.WriteLine(10 + number);

       // Задание 5
       double x = double.Parse(Console.ReadLine());
       double y = Math.Cos(x);
       Console.WriteLine(y);

       // Задание 6
       Console.WriteLine("Введите значение первого основания: ");
       double a = double.Parse(Console.ReadLine());
       Console.WriteLine("Введите значение второго основания: ");
       double b = double.Parse(Console.ReadLine());
       Console.WriteLine("Введите значение высоты: ");
       double h = double.Parse(Console.ReadLine());
       double c = Math.Sqrt(Math.Pow(((a - b) / 2), 2) + Math.Pow(h, 2));
       double perimetr = a + b + 2 * c;

       Console.WriteLine(perimetr);

       // Задание 7
       Console.WriteLine("Мир Труд Май");
       Console.WriteLine("Мир\n\tТруд\n\t\tМай");
       
       // Задание 8
       Console.Write("Введите первую переменную a = ");
       int firstA = int.Parse(Console.ReadLine());
       Console.Write("Введите вторую переменную b = ");
       int firstB = int.Parse(Console.ReadLine());

       int temp = firstA;
       firstA = firstB;
       firstB = temp;

       Console.WriteLine($"a = {firstA}\nb = {firstB}");

       // Задание 9
       double newNumber = double.Parse(Console.ReadLine());
       Console.WriteLine($"Вы ввели число {newNumber}");
       
       // Задание 10
       Console.Write("Введите коэффициент a = ");
       double coefficientA = double.Parse(Console.ReadLine());
       Console.Write("Введите коэффициент b = ");
       double coefficientB = double.Parse(Console.ReadLine());
       Console.Write("Введите коэффициент c = ");
       double coefficientC = double.Parse(Console.ReadLine());

       double discriminant = Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC;

       if (discriminant > 0)
        {
            double x1 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
            double x2 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
            Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x3 = (-coefficientB) / (2 * coefficientA);
            Console.WriteLine($"x = {x3}");
        }
        else
        {
            Console.WriteLine("Действительных корней нет");
        }

        // Задание 11
        Console.Write("Введите первое целочисленное число: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Введите второе целочисленное число: ");
        int secondNum = int.Parse(Console.ReadLine());

        double average = (firstNum + secondNum) / 2.0;
        double geometric = Math.Sqrt(firstNum * secondNum);

        Console.WriteLine($"Среднее арифметичекое: {average}");
        Console.WriteLine($"Среднее геометрическое: {geometric}");

        // Задание 12
        Console.Write("Введите первую координату первой точки: ");
        double koordinataX1tochki = double.Parse(Console.ReadLine());
        Console.Write("Введите вторую координату первой точки: ");
        double koordinataY1tochki = double.Parse(Console.ReadLine());
        Console.Write("Введите первую координату второй точки: ");
        double koordinataX2tochki = double.Parse(Console.ReadLine());
        Console.Write("Введите вторую координату второй точки: ");
        double koordinataY2tochki = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(koordinataX2tochki - koordinataX1tochki, 2) + Math.Pow(koordinataY2tochki - koordinataY1tochki, 2));
        Console.WriteLine($"Расстояние между ними равно {distance}");

        // Задание 13 a)
        Console.Write("Введите переменную a = ");
        int peremenA = int.Parse(Console.ReadLine());
        Console.Write("Введите переменную b = ");
        int peremenB = int.Parse(Console.ReadLine());
        Console.Write("Введите переменную c = ");
        int peremenC = int.Parse(Console.ReadLine());

        int tempp = peremenA;
        peremenA = peremenB;
        peremenB = peremenC;
        peremenC = tempp;

        Console.WriteLine("a = " + peremenA);
        Console.WriteLine("b = " + peremenB);
        Console.WriteLine("c = " + peremenC);

        // Задание 13 б)
        Console.Write("Введите переменную a = ");
        int peremenA1 = int.Parse(Console.ReadLine());
        Console.Write("Введите переменную b = ");
        int peremenB1 = int.Parse(Console.ReadLine());
        Console.Write("Введите переменную c = ");
        int peremenC1 = int.Parse(Console.ReadLine());
        
        int temppp = peremenA1;
        peremenA1 = peremenC1;
        peremenC1 = peremenB1;
        peremenB1 = temppp;

        Console.WriteLine("a = " + peremenA1);
        Console.WriteLine("b = " + peremenB1);
        Console.WriteLine("c = " + peremenC1);

        // Задание 14 a) б) в)
        Console.Write("С начала суток прошло n секунд, n = ");
        int totalSeconds = int.Parse(Console.ReadLine());

        int hours = totalSeconds / 3600;

        int minutes = (totalSeconds % 3600) / 60;

        int seconds = totalSeconds % 60;

        
        Console.WriteLine($"С начала суток прошло {hours} полных часов");
        Console.WriteLine($"С начала очередного часа прошло {minutes} минут");
        Console.WriteLine($"С начала очередной минуты прошло {seconds} полных секунд");

        // Задание 15
        int storonaAP = 543;
        int storonaBP = 130;
        int storonaAKv = 130;

        int squareP = storonaAP * storonaBP;
        int squareKv = (int)Math.Pow(storonaAKv, 2);

        int howMuchKv = squareP / squareKv;

        Console.WriteLine($"Можно отрезать {howMuchKv} квадратов");

        // Задание 16
        Console.Write("Введите натуральное трехзначное число: ");
        int danoeNum = int.Parse(Console.ReadLine());
        int lastNum = danoeNum % 10;
        int firstTwoNum = danoeNum / 10;
        int newDanoeNum = lastNum * 100 + firstTwoNum;

        Console.WriteLine(newDanoeNum);

        // Задание 17
        Console.WriteLine("Введите натуральное число n, n > 999");
        Console.Write("n = ");
        int chislo = int.Parse(Console.ReadLine());

        int hundreds = chislo / 100;
        int thousands = chislo / 1000;
        Console.WriteLine($"Число сотен в числе {chislo} = {hundreds}\nЧисло тысяч в числе {chislo} = {thousands}");

        // Задание 18
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine(name);

        Console.Write("Введите ваше имя: ");
        string newName = Console.ReadLine();
        Console.WriteLine($"Привет, {newName}!");

        // Задание 19
        Console.Write("Пользователь: - Привет!\nКонсоль: - Как тебя зовут?\nПользователь: - Меня зовут ");
        string nameUser = Console.ReadLine();
        Console.WriteLine($"Консоль: - Привет, {nameUser}\n{nameUser}: - Ты знаешь что-то о тайной комнате?\nКонсоль: - Да\n{nameUser}: - Можешь рассказать?\nКонсоль: - Нет");

        Thread.Sleep(5000);
        Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
        Console.WriteLine("Консоль: - Но могу показать");
        Console.ResetColor();

        // Задание 20 a)
        string barcode = "";
        for (int i = 0; i < 12; i++)
        {
            int digit = random.Next(0, 10);
            barcode += digit;
        }
        Console.WriteLine(barcode);

        int sum = 0;

        for (int i = 0; i < 12; i++)
        {
            int digit = barcode[i] - '0';
           
            if (i % 2 == 0)
            {
                sum += digit;
            }
            else
            {
                sum += digit * 3;
            }
        }

        int checkDigit = (10 - sum % 10) % 10;

        string fullBarcode = barcode + checkDigit;

        Console.WriteLine($"EAN-13: {fullBarcode}");

        // Задание 20 б)
        Console.Write("Введите 12 цифр: ");
        string barcode1 = Console.ReadLine();
        int sum1 = 0;

        for (int i = 0; i < 12; i++)
        {
            int digit1 = barcode1[i] - '0';
           
            if (i % 2 == 0)
            {
                sum1 += digit1;
            }
            else
            {
                sum1 += digit1 * 3;
            }
        }
        
        int checkDigit1 = (10 - sum1 % 10) % 10;

        string fullBarcode1 = barcode1 + checkDigit1;

        Console.WriteLine($"EAN-13: {fullBarcode1}");

    }
}