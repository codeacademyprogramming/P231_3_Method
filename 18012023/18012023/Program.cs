using System;

namespace _18012023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowHello();
            string text = "Salam P132";
            Show(text);

            int cem = Sum(40, 65);

            Console.WriteLine("Ad:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyad:");
            string surname = Console.ReadLine();

            var fullname = MakeFullname(name, surname);

            Console.WriteLine(fullname); //Hikmet Abbasov


            var sum = SumOfDigits(345);

            Console.WriteLine(sum);

            Console.WriteLine(HasA("Hikmet"));

            var check = IsDigit('a');

            Console.WriteLine(check);

            var result = Quvvet(2, 10);
            Console.WriteLine( result);


            int[] numbers = { 345, 23, 12, 67, 2233, 87 };



            var maxNumber = FindMax(numbers);
            Console.WriteLine(maxNumber);

            string str = "Hello World  fd f   dsfds  dfsfds";

            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 1)
                {
                    newStr += str[i];
                }
            }

            Console.WriteLine(newStr);

            Console.WriteLine(MakeStr(str));
        }

        //Verilmis yazidan yalniz cut indexlerinde duran charlardan yeni bir yazi duzelden metod

        static string MakeStr(string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]!=' ')
                    newStr += str[i];
            }

            return newStr;
        }

        //Verilmis ededler siyahisindaki en boyuk ededi tapan metod
        static int FindMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }



        //Verilmis ededi verilmis quvvete yukselden metod
        static int Quvvet(int num,int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }



        // Verilmis yazidaki verilmis carin olub olmadigini tapan metod
        static bool ChekWord(string str , char cr)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == cr)
                {
                    return true;
                }
               
            }
            return false;

        }

        //Verilmis charin reqem olub olmadigini tapan metod
        static bool IsDigit(char symbol)
        {
            //if (cr >= 48 && cr <= 57)
            //{
            //    return true;
            //}
            //else return false;

            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //string str = "0123456789";

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == symbol)
                    return true;
            }

            return false;
        }

        static int SumOfDigits(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                var digit = num % 10;
                sum += digit;
                num /= 10;
            }

            return sum;
        }

        static int Avg(int num1,int num2)
        {
            int count = 0;
            int sum = 0;
            for (int i = num1; i < num2; i++)
            {
                if (i % 21 == 0)
                {
                    sum += i;
                    count++;
                }
            }

            return sum / count;
        }

        static bool HasA(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    return true;
                }
            }
            return false;
        }

        static void ShowHello()
        {
            Console.WriteLine("Hello");
        }

        static void Show(string str)
        {
            Console.WriteLine(str);
        }

        static int Sum(int num1, int num2)
        {
            var result = num1 + num2;

            return result;
        }

        static string MakeFullname(string name,string surname)
        {
            var fn = name +" "+ surname;

            return fn;
        }









    }
}
