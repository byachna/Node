using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node : Speck
    {
        public List<Pole> Poles = new List<Pole>();
        public Node()
        {
            ID = System.Guid.NewGuid();
            Classification = Seed.rnd.Next(0, 5);
            
            for (int i = 0; i < 4; i++)
            {
                Poles.Add(new Pole(this));
            }
        }

        public bool Attach(Node child)
        {
            if (Seed.Debug)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("NodeID: [" + ID + "] Searching for PoleCls: [" + child.Classification + "]");
            }
            foreach (Pole p in Poles)
            {
                if (Seed.Debug)
                {
                    Console.WriteLine("PoleCls: [" + p.Classification + "]");
                }
                if (p.Classification == child.Classification && p.B == null)
                {
                    if (Seed.Debug)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Attached NodeID: [" + child.ID + "] to NodeID: [" + ID + "]");
                        Console.ResetColor();
                    }
                    p.B = child;
                    return true;
                }
                //System.Threading.Thread.Sleep(100);
            }

            foreach (Pole p in Poles)
            {
                if (p.B != null)
                {
                    if (p.B.Attach(child))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void printChildren(string prefix)
        {
            Console.WriteLine(prefix + "NID: [" + ID + "]" + " NCls: [" + Classification + "]");
            foreach (Pole p in Poles)
            {          
                if(p.B != null)
                {
                    p.B.printChildren(prefix + "-");
                }
            }
        }
    }
}
