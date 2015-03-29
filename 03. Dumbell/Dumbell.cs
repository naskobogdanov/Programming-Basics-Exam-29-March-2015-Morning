using System;

class Dumbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); ;

        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', n / 2 + 1), new string('.', n));
        for (int i = 0, counter = 0; i < n - 2; i++ , counter = i <= (n /  2) - 1 ? counter + 1 : counter - 1)
        {
            string middle = i == n / 2 - 1 ? new string('=', n) : new string('.', n);
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', n / 2 - 1 - counter), new string('*', n / 2 + counter), middle);           
        }
        Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 2), new string('&', n / 2 + 1), new string('.', n));
    }
}