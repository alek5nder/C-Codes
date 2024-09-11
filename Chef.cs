using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UczeSB
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The CHef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The CHef makes salad");
        }
        public void MakeSoup()
        {
            Console.WriteLine("The CHef makes soup");
        }

        public virtual void SpecialDish()
        {
            Console.WriteLine("The CHef makes special dish");
        }
    }
}
