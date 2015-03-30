using System;
using System.Collections.Generic;

class GameOfBits
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        string binaryNum = "00" + Convert.ToString(num, 2);
        string input = null;
        List<long> binaryNumList = new List<long>();
        List<long> tempNumList = new List<long>();
        List<long> newNums = new List<long>();
        int counter = 0;

        for (int i = binaryNum.Length - 1; i >= 0; i--)
        {
            binaryNumList.Add(binaryNum[i]);
        }        
        
        tempNumList = binaryNumList;

        for (int j = 0; j < 30; j++)
        {
            input = Console.ReadLine();

            if (input == "Odd")
            {
                for (int i = tempNumList.Count - 1; i >= 0; i--)
                {
                    if (i % 2 == 0 || i == 0)
                    {
                        newNums.Add(tempNumList[i]);
                    }
                }
                tempNumList = new List<long>();
                tempNumList = newNums;
                newNums = new List<long>();
            }
            else if (input == "Even")
            {
                for (int i = tempNumList.Count - 1; i >= 0; i--)
                {
                    if (i % 2 == 1 || i == 1)
                    {
                        newNums.Add(tempNumList[i]);
                    }
                }
                tempNumList = new List<long>();
                tempNumList = newNums;
                newNums = new List<long>();
            }
            else 
            {    
                for (int i = tempNumList.Count - 1; i >= 0; i--)
                {
                    if (tempNumList[i] == '1')
                    {
                        counter++;
                    }
                    if (i == 0)
                    {
                        break;
                    }
                }
               break;
            }            
            tempNumList.Reverse();
        }

        for (int i = 0; i < tempNumList.Count; i++)
        {
            tempNumList[i] = tempNumList[i] - 48;
        }
        tempNumList.Reverse();
        tempNumList.ToString();
        string finalNum = String.Join("", tempNumList);
        long l = Convert.ToInt64(finalNum, 2);

        Console.WriteLine("{0} -> {1}", l, counter);
    }
}