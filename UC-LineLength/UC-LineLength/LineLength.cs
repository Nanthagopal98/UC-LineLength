using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_LineLength
{
    public class LineLength
    {
        public void createLine()
        {
            double[] length = new double[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter value of X1");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of Y2");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of X2");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of Y2");
                int y2 = Convert.ToInt32(Console.ReadLine());
                length[i] = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine(length[i]);
            }
            if (length[0] == length[1])
            {
                Console.WriteLine("Both lines with same length is " + length[1].Equals(length[0]));
            }
            else if (length[0] < length[1])
            {
                Console.WriteLine("Length of lines 2 is longer");
            }
            else
            {
                Console.WriteLine("Length of lines 1 is longer");
            }
        }
    }
}
