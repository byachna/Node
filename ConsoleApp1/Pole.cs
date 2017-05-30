using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pole : Speck
    {
        public Node A { get; set; }
        public Node B { get; set; }

        public Pole(Node owner)
        {
            A = owner;
            B = null;
            ID = System.Guid.NewGuid();
            Classification = Seed.rnd.Next(0, 5);
        }
    }
}
