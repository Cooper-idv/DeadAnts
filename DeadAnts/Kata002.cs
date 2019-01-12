using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts
{
    public class Kata002
    {
        public static int getDeadAntsCount(string str)
        {
            int[] arrBlockCount = new int[] { 0,0,0 };
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            string deadString = str.Replace("ant", "");
            foreach (char block in deadString)
            {
                switch (block)
                {
                    case 'a':
                        arrBlockCount[0]++;
                        break;
                    case 'n':
                        arrBlockCount[1]++;
                        break;
                    case 't':
                        arrBlockCount[2]++;
                        break;
                }
            }
            int maxBlockCount = arrBlockCount[0] > arrBlockCount[1] ? arrBlockCount[0] : arrBlockCount[1];
            maxBlockCount = maxBlockCount > arrBlockCount[2] ? maxBlockCount : arrBlockCount[2];
            //Array.Sort(arrBlockCount);
            //int maxBlockCount = arrBlockCount[arrBlockCount.Length - 1];
            return maxBlockCount;
        }
    }
}
