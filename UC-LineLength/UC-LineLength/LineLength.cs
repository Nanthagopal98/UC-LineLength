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
            
                Console.WriteLine("Enter value of X1");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of Y2");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of X2");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value of Y2");
                int y2 = Convert.ToInt32(Console.ReadLine());
                double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine(length);
            
        }
    }
}
