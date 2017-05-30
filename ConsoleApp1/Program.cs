using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numNodes = 0;

            Console.Write("How many nodes to create? : ");

            numNodes = int.Parse(Console.ReadLine());

            if (numNodes > 0)
            {
                // Create a master node for subsequent nodes to attach to.
                List<Node> failed = new List<Node>();

                Node masterNode = new Node();

                for (int i = 0; i < numNodes; i++)
                {
                    var count = i + 1;
                    if (Seed.Debug)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Node: " + count + " of " + numNodes);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Node: " + count + " of " + numNodes);

                    Node n = new Node();

                    if (!masterNode.Attach(n))
                    {
                        if (Seed.Debug)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NID: [" + n.ID + "] NCls: [" + n.Classification + "] Failed to Attach!");
                            Console.ResetColor();
                        }
                        failed.Add(n);
                    }
                }

                //Print out node hierarchy
                Console.WriteLine("");
                Console.WriteLine("Hierarchial Structure of Nodes");
                masterNode.printChildren("");
                Console.WriteLine("");
                Console.WriteLine("Failed Nodes: " + failed.Count);
                Console.WriteLine("Total Nodes: " + numNodes);
            }
            else
            {
                Console.WriteLine("No nodes created");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
