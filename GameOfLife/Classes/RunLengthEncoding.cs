using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Classes
{
    public static class RunLengthEncoding
    {
        public static string Decrypt(bool[] map)
        {
            int counter = 0;
            bool prevValue = map[0];
            string result = "";

            for (int i = 0; i < map.Length; i++)
            {
                if (prevValue == map[i])
                {
                    counter++;
                }
                else
                {
                    if (counter > 1)
                    {
                        result += counter.ToString();
                    }

                    result += prevValue ? 'A' : 'B';
                    prevValue = map[i];
                    counter = 0;
                    i--;
                }
            }

            if (counter > 1)
            {
                result += counter.ToString();
            }

            result += prevValue ? 'A' : 'B';

            return result;
        }
        public static bool[] Encrypt(string decryptedMap)
        {
            bool[] map = new bool[Board.Size * Board.Size];
            int number = 0;
            int index = 0;
            for (int i = 0; i < decryptedMap.Length; i++)
            {
                if (decryptedMap[i] >= '0' && decryptedMap[i] <= '9')
                {
                    number *= 10;
                    number += (int)(decryptedMap[i] - '0');
                }
                else
                {
                    if (number == 0)
                    {
                        number = 1;
                    }

                    for (int j = 0; j < number; j++)
                    {
                        map[index] = decryptedMap[i] == 'A';
                        index++;
                    }

                    number = 0;
                }
            }

            return map;
        }
    }
}
