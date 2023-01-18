using System;

namespace Lesson
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ShowGroupNo();
            //ShowStudentCount();

            ShowGroupInfo();

            var result = Sum(num2:55,num3:10,num1:5);
            Console.WriteLine(result);

            Show("A",str3:"C");

            Show("salam");
        }

        static void ShowGroupNo()
        {
            Console.WriteLine("P231");
        }

        static void ShowStudentCount()
        {
            Console.WriteLine(17);
            return;
            Console.WriteLine(14);
            Console.WriteLine(15);
        }

        static void ShowGroupInfo()
        {
            ShowGroupNo();
            ShowStudentCount();
        }
        static void Show(string str1, string str2 = "_", string str3 = "_")
        {
            Console.WriteLine(str1 + str2 + str3);
        }
        static void Show(string str)
        {
            Console.WriteLine(str);
        }

        static void Show(int num)
        {
            Console.WriteLine(num);
        }

        static void Show(char cr)
        {
            Console.WriteLine(cr);
        }

        static int Sum(int num1,int num2=100)
        {
            return num1 + num2;
        }

        static int Sum(int num1, int num2,int num3)
        {
            return num1 + num2+num3;
        }

        static double Sum(double num1,double num2)
        {
            return num1 + num2;
        }

        



    }
}
