using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Town.Model;

namespace Town
{
    class Program
    {
        public static void TestLifeTown()
        {
            NewTown sometown = new NewTown("D-Gate", 20, 100);
            sometown.LifeOurTown();
        }
        static void Main(string[] args)
        {
            TestLifeTown();
        }
    }
}
