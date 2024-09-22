using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UczeSB
{
    internal class AreOfTriangle
    {

        public void code()
        {
            int width = ReadInt("Enter width: ");
            int height = ReadInt("Enter height: ");

            Console.WriteLine("The area is: " + width * height * 0.5);
            Console.ReadLine();
        }

        public int ReadInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
