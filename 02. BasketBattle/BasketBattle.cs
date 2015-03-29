using System;

class BasketBattle
{
    static void Main()
    {
        string firstPlayerName = Console.ReadLine();
        string secondPlayerName = null;
        if (firstPlayerName == "Simeon")
        {
            secondPlayerName = "Nakov";
        }
        else if (firstPlayerName == "Nakov")
        {
            secondPlayerName = "Simeon";
        }
        int numberOfRounds = int.Parse(Console.ReadLine());
        int tryedPointsFirstPlayer = 0;
        string resultFirstPlayer;
        int tryedPointsSecondPlayer = 0;
        string resultSecondPlayer;
        int pointsFirstPLayer = 0;
        int pointsSecondPLayer = 0;

        for (int i = 0; i < numberOfRounds; i++)
        {                     
            if ((i % 2 == 1 || i == 1) && i > 0)
            {
                tryedPointsSecondPlayer = int.Parse(Console.ReadLine());
                resultSecondPlayer = Console.ReadLine();
                tryedPointsFirstPlayer = int.Parse(Console.ReadLine());
                resultFirstPlayer = Console.ReadLine();                
            }
            else
            {
                tryedPointsFirstPlayer = int.Parse(Console.ReadLine());
                resultFirstPlayer = Console.ReadLine();
                tryedPointsSecondPlayer = int.Parse(Console.ReadLine());
                resultSecondPlayer = Console.ReadLine();
            }

            if (resultFirstPlayer == "success")
            {
                pointsFirstPLayer += tryedPointsFirstPlayer;
            }
            if (resultSecondPlayer == "success")
            {
                pointsSecondPLayer += tryedPointsSecondPlayer;
            }
            if (pointsFirstPLayer > 500)
            {
                pointsFirstPLayer = pointsFirstPLayer - tryedPointsFirstPlayer;
            }
            if (pointsSecondPLayer > 500)
            {
                pointsSecondPLayer = pointsSecondPLayer - tryedPointsSecondPlayer;
            }
            if (pointsFirstPLayer == 500 && pointsSecondPLayer < 500)
            {                
                Console.WriteLine(firstPlayerName);
                Console.WriteLine(i + 1);
                Console.WriteLine(pointsSecondPLayer);
                break;
            }
            else if (pointsSecondPLayer == 500 && pointsFirstPLayer < 500)
            {
                Console.WriteLine(secondPlayerName);
                Console.WriteLine(i + 1);
                Console.WriteLine(pointsFirstPLayer);
                break;
            }
            else if (pointsFirstPLayer == pointsSecondPLayer && i == numberOfRounds - 1)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(pointsSecondPLayer);
                break;
            }
            else if (pointsFirstPLayer < 500 && pointsSecondPLayer < 500 && pointsFirstPLayer != pointsSecondPLayer && i == numberOfRounds - 1)
            {
                if (pointsFirstPLayer > pointsSecondPLayer)
                {
                    Console.WriteLine(firstPlayerName);
                }
                else
                {
                    Console.WriteLine(firstPlayerName);
                }
                Console.WriteLine(Math.Abs(pointsFirstPLayer - pointsSecondPLayer));
            }
        }
    }
}