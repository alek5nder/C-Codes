using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UczeSB
{
    internal class ItalianChef : Chef 
    {

        public override void SpecialDish()
        {
            Console.WriteLine("The CHef makes special pasta");
        }
        public void MakePasta()
        {
            Console.WriteLine("Make pasta");
        }
    }
}
