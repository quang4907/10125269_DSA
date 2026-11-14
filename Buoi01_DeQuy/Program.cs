using System;

namespace Buoi01_DeQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Bài 1 ===");
            Bai1();
            Console.WriteLine("=== Bài 2 ===");
            Bai2();
            Console.WriteLine("=== Bài 3 ===");
            Bai3();
            Console.WriteLine("=== Bài 4 ===");
            Bai4();
            Console.WriteLine("=== Bài 5 ===");
            Bai5();
            Console.WriteLine("=== Bài 6 ===");
            Bai6();
            Console.WriteLine("=== Bài 7 ===");
            Bai7();
            Console.WriteLine("=== Bài 8 ===");
            Bai8();
        }

        static void Bai1()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"S({n}) = {DeQuy.Bai1(n)}");
        }

        static void Bai2()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"S({n}) = {DeQuy.Bai2(n)}");
        }

        static void Bai3()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"S({n}) = {DeQuy.Bai3(n)}");
        }

        static void Bai4()
        {
            Console.Write("Nhập x: ");
            double x = double.Parse(Console.ReadLine()!);
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"{x}^{n} = {DeQuy.Bai4(x, n)}");
        }

        static void Bai5()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Ước số lẻ lớn nhất của {n} là: {DeQuy.Bai5(n)}");
        }

        static void Bai6()
        {
            Console.Write("Nhập a: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Nhập b: ");
            int b = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"UCLN({a}, {b}) = {DeQuy.Bai6(a, b)}");
        }

        static void Bai7()
        {
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Số chữ số của {n} là: {DeQuy.Bai7(n)}");
        }

        static void Bai8()
        {
            Console.Write("Nhập n: ");
            double n = double.Parse(Console.ReadLine()!);
            Console.WriteLine($"Kết quả căn thức lồng nhau đến {n} là: {DeQuy.Bai8(n)}");
        }
    }

    class DeQuy
    {
        public static int Bai1(int n)
        {
            if (n == 1) return 1;
            return Bai1(n - 1) + n;
        }

        public static int Bai2(int n)
        {
            if (n == 1) return 1;
            return Bai2(n - 1) + n * n;
        }

        public static double Bai3(int n)
        {
            if (n == 1) return 1.0;
            return Bai3(n - 1) + 1.0 / n;
        }

        public static double Bai4(double x, int n)
        {
            if (n == 0) return 1;
            return Bai4(x, n - 1) * x;
        }

        public static int Bai5(int n)
        {
            if (n % 2 != 0) return n;
            return Bai5(n / 2);
        }

        public static int Bai6(int a, int b)
        {
            if (b == 0) return a;
            return Bai6(b, a % b);
        }

        public static int Bai7(int n)
        {
            if (n == 0) return 0;
            return Bai7(n / 10) + 1;
        }

        public static double Bai8(double n, int i = 1)
        {
            if (i >= (int)n) return Math.Sqrt(n);
            return Math.Sqrt(i + Bai8(n, i + 1));
        }
    }
}