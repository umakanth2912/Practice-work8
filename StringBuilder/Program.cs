using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] RiceItems = { "1.Plain Rice", "2.Chicken Biryani", "3.Mutton Biryani\n" };
            string[] CurryItems = { "1.Tomato Curry", "2.Chicken Curry", "3.Mutton Curry" };
            StringBuilder strbl = new StringBuilder("-*-*-*-*-*-*-*-* Menu -*-*-*-*-*-*-*-*\n\n\n");
            strbl.AppendLine("\t*****Rice Items*****");
            foreach(string items in RiceItems)
            {
                strbl.Append(items).AppendLine();
            }

            strbl.AppendLine("\t*****Curry Items*****");
            foreach (string items in CurryItems)
            {
                strbl.Append(items).AppendLine();
            }
            Console.WriteLine(strbl.ToString());
            Console.ReadLine();
            
        }
    }
}
