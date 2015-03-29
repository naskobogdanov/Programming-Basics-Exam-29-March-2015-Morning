using System;

class TorrentPirate
{
    static void Main()
    {
        int downloadData = int.Parse(Console.ReadLine());
        int cinemaPrice = int.Parse(Console.ReadLine());
        int wifeSpending = int.Parse(Console.ReadLine());

        double cinemaTotal = downloadData / 1500.0 * cinemaPrice;
        double mallTotal = (downloadData / 7200.0) * wifeSpending;

        if (cinemaTotal < mallTotal)
        {
            Console.WriteLine("cinema -> {0:F2}lv", cinemaTotal);
        }
        else
        {
            Console.WriteLine("mall -> {0:f2}lv",mallTotal);
        }
    }
}