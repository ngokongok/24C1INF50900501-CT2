using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //baitap_1; 
        //baitap_2; 
        //baitap_3; 
        //baitap_4; 
        //baitap_5; 
        //baitap_6; 
        //baitap_7; 
        //baitap_8; 
        //baitap_9; 
        //baitap_10; 
        baitap_11; 
    }
    static void baitap_1()
    {
        Console.WriteLine("Nhap 1 so n:");
        int n = int.Parse("0" + Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} là so chan");
        }
        else
            Console.WriteLine($"{n} là so le");
    }
    static void baitap_2()
    {
        int a, b, c, largest;
        Console.WriteLine("Nhap a:");
        a = int.Parse("0" + Console.ReadLine());
        Console.WriteLine("Nhap b:");
        b = int.Parse("0" + Console.ReadLine());
        Console.WriteLine("Nhap c:");
        c = int.Parse("0" + Console.ReadLine());

        if (a > b && a > c)
        {
            largest = a;
        }
        else if (b > a && b > c)
        {
            largest = b;
        }
        else
        {
            largest = c;
        }
        Console.WriteLine("S0 lon nhat la:" + largest);
    }
    static void baitap_3()
    {
        Console.WriteLine("Nhap toa do x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhap toa do y:");
        double y = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("Diem nam o goc phan tu thu I");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Diem nam o goc phan tu thu II");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Diem nam o goc phan tu thu III");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Diem nam o goc phan tu thu IV");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("Diem nam tai goc toa đo");
        }
        else if (x == 0)
        {
            Console.WriteLine("Diem nam tren truc Oy");
        }
        else
        {
            Console.WriteLine("Diem nam tren truc Ox");
        }
    }
    static void baitap_4()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập độ dài 3 cạnh của tam giác:");

        Console.Write("Cạnh a = ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cạnh b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cạnh c = ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Không phải là một tam giác");
        }
        else
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giác đều");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Tam giác cân");
            }
            else
            {
                Console.WriteLine("Tam giác thường");
            }
        }
    }
    static void baitap_5()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int sum = 0;
        int num;

        Console.WriteLine("Nhập 10 số :");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Số thứ {0}: ", i);
            num = int.Parse("0" + Console.ReadLine());
            sum += num;
        }

        double avg = (double)sum / 10;

        Console.WriteLine("Tổng của 10 số là: " + sum);
        Console.WriteLine("Trung bình cộng của 10 số là: " + avg);
    }
    static void baitap_6()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        Console.WriteLine("Nhập số nguyên n: ");
        n = int.Parse("0" + Console.ReadLine());

        Console.WriteLine("Bảng cửu chương của " + n);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }

    }
    static void baitap_7()
{
    Console.OutputEncoding = Encoding.UTF8;
    int number = 1;
    int h1;
    Console.WriteLine("Nhập h1");
    h1 = int.Parse("0" + Console.ReadLine());
    for (int i = 1; i <= h1; i++)
    {
        for (int j = 1; j <= i; j--)
        {
            Console.Write(number++);

        }
        Console.WriteLine(" ");
    }
}
    static void baitap_8()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int number = 1;
        int h3;
        Console.WriteLine("Nhập h3");
        h3 = int.Parse("0" + Console.ReadLine());
        for (int i = 1; i <= h3; i++)
        {
            
            int num = 1;
            for (int j = h3 - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number++ + " ");
            }
            Console.WriteLine();
        }

    }
    static void baitap_9()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n;
        Console.WriteLine("Nhập số lượng số hạng n :");
        n = int.Parse("0" + Console.ReadLine());

        double sum = 0;
        Console.WriteLine("Các số hạng của chuỗi điều hòa:");
        for (int i = 1; i <= n; i++)
        {
            double soHang = 1.0 / i;
            Console.Write("Số thứ {0}: ", i);
            Console.WriteLine(soHang);
            sum += soHang;

        }
        Console.WriteLine($"Tổng của {n} số là " + sum);

    }
    static void baitap_10()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập giới hạn dưới: ");
        int lowerBound = int.Parse("0" + Console.ReadLine());

        Console.Write("Nhập giới hạn trên: ");
        int upperBound = int.Parse("0" + Console.ReadLine());

        Console.WriteLine("Các số hoàn hảo trong khoảng đã cho:");

        for (int number = lowerBound; number <= upperBound; number++)
        {
            int divisorSum = 0;

            for (int divisor = 1; divisor < number; divisor++)
            {
                if (number % divisor == 0)
                {
                    divisorSum += divisor;
                }
            }

            if (divisorSum == number)
            {
                Console.WriteLine(number);
            }
        }
    }

    static void baitap_11()
    {
        Console.OutputEncoding = Encoding.UTF8;
        int number;
        Console.WriteLine("Nhập 1 số nguyên:");
        number = int.Parse("0" + Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("Số không phải là số nguyên tố");
        }
        else
        {
            bool isPrime = true;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Số là số nguyên tố");
            }
            else
            {
                Console.WriteLine("Số không phải là số nguyên tố");
            }
        }
    }
}
