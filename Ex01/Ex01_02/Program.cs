﻿
using System.Text;

namespace Ex01_02
{
    public class Program
    {
        public static void Main()
        {
            DiamondForBeginners(5, 0);
        }

        public static void DiamondForBeginners(int i_diamondHigh, int i_currentRow)
        {
            if (i_currentRow < i_diamondHigh * 2 - 1)//musere the num of total rows
            {
                int numStarsToPrint;
                int numSpaceToPrint;

                if (i_currentRow < i_diamondHigh)//if we got to the "middle" of the rows
                {
                    numStarsToPrint = i_currentRow * 2 + 1;
                }
                else
                {
                    numStarsToPrint = (i_diamondHigh * 2 - 1 - i_currentRow) * 2 - 1;
                }

                numSpaceToPrint = (i_diamondHigh * 2 - 1 - numStarsToPrint) / 2;

                StringBuilder textToPrint = new System.Text.StringBuilder();
                string spacesToprint = new string(' ', numSpaceToPrint);
                string starsToPrint = new string('*', numStarsToPrint);

                textToPrint.Append(spacesToprint).Append(starsToPrint).Append(spacesToprint);


                System.Console.WriteLine(textToPrint.ToString());
                DiamondForBeginners(i_diamondHigh,i_currentRow + 1);
            }
        }
    }
}
