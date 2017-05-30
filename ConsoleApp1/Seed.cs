using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Seed
    {
        public static Random rnd = new Random((int)DateTime.Now.Ticks);
        public static bool Debug = false;
    }
}
