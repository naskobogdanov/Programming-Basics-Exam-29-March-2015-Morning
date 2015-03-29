using System;
using System.Collections.Generic;
using System.Linq;

class EncryptedMatrix
{
    static void Main()
    {
        string message = Console.ReadLine();
        string direction = Console.ReadLine();
        List<double> encriptedNums = new List<double>();
        List<double> reversed = new List<double>();

        char[] charMessage = message.ToCharArray();
        int[] intMessage = new int[charMessage.Length];

        for (int i = 0; i < charMessage.Length; i++)
        {
            intMessage[i] = charMessage[i] % 10;
        }

        for (int i = 0; i < intMessage.Length; i++)
		{
            if (intMessage.Length == 1)
            {
                if (intMessage[i] == 0 || intMessage[i] % 2 == 0)
                {
                    int doubledNum = intMessage[i] * intMessage[i];
                    if (doubledNum >= 10)
                    {
                        encriptedNums.Add(doubledNum / 10);
                        encriptedNums.Add(doubledNum % 10);
                    }
                    else
                    {
                        encriptedNums.Add(doubledNum);
                    } 
                }
                else
                {
                    int summedNum = intMessage[i];
                    if (summedNum >= 10)
                    {
                        encriptedNums.Add(summedNum / 10);
                        encriptedNums.Add(summedNum % 10);
                    }
                    else
                    {
                        encriptedNums.Add(summedNum);
                    }                    
                }
            }
            else
            {
                if (i == 0)
                {
                    if (intMessage[i] == 0 || intMessage[i] % 2 == 0)
                    {
                        int doubledNum = intMessage[i] * intMessage[i];
                        if (doubledNum >= 10)
                        {
                            encriptedNums.Add(doubledNum / 10);
                            encriptedNums.Add(doubledNum % 10);
                        }
                        else
                        {
                            encriptedNums.Add(doubledNum);
                        }
                    }
                    else
                    {
                        int summedNum = intMessage[i] + intMessage[i + 1];
                        if (summedNum >= 10)
                        {
                            encriptedNums.Add(summedNum / 10);
                            encriptedNums.Add(summedNum % 10);
                        }
                        else
                        {
                            encriptedNums.Add(summedNum);
                        } 
                    }
                }
                else if (i == intMessage.Length - 1)
                {
                    if (intMessage[i] == 0 || intMessage[i] % 2 == 0)
                    {
                        int doubledNum = intMessage[i] * intMessage[i];
                        if (doubledNum >= 10)
                        {
                            encriptedNums.Add(doubledNum / 10);
                            encriptedNums.Add(doubledNum % 10);
                        }
                        else
                        {
                            encriptedNums.Add(doubledNum);
                        }
                    }
                    else
                    {
                        int summedNum = intMessage[i] + intMessage[i - 1];
                        if (summedNum >= 10)
                        {
                            encriptedNums.Add(summedNum / 10);
                            encriptedNums.Add(summedNum % 10);
                        }
                        else
                        {
                            encriptedNums.Add(summedNum);
                        }                         
                    }
                }
                else
                {
                    if (intMessage[i] == 0 || intMessage[i] % 2 == 0)
                    {
                        int doubledNum = intMessage[i] * intMessage[i];
                        if (doubledNum >= 10)
                        {
                            encriptedNums.Add(doubledNum / 10);
                            encriptedNums.Add(doubledNum % 10);
                        }
                        else
                        {
                            encriptedNums.Add(doubledNum);
                        }
                    }
                    else
                    {
                        int summedNum = intMessage[i] + intMessage[i + 1] + intMessage[i - 1];
                        if (summedNum >= 10)
                        {
                            encriptedNums.Add(summedNum / 10);
                            encriptedNums.Add(summedNum % 10);
                        }
                        else
                        {
                            encriptedNums.Add(summedNum);
                        }                         
                    }
                }
            }            
		}

        if (direction == "/")
        {
            for (int i = 0, counter = encriptedNums.Count - 1; i < encriptedNums.Count; i++)
            {
                for (int j = 0; j < encriptedNums.Count; j++)
                {
                    if (i + j == encriptedNums.Count - 1)
                    {
                        Console.Write("{0} ", encriptedNums[counter]);
                    }
                    else
                    {
                        Console.Write("{0} ", 0);
                    }
                }
                counter--;
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = 0; i < encriptedNums.Count; i++)
            {
                for (int j = 0; j < encriptedNums.Count; j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0} ", encriptedNums[i]);
                    }
                    else
                    {
                        Console.Write("{0} ", 0);
                    }
                }               
                Console.WriteLine();
            }
        }
     }
}