using CSharp.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Arrays
{
    public class Node
    {
        public int Value;

        public Node(int value)
        {
            Value = value;
        }
    }

    public class NodeHandler
    {
        private Node[] nodes;

        public void CreateNodesFromArray()
        {
            Console.WriteLine("Enter array elements separated by space:");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            nodes = new Node[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                int val = int.Parse(parts[i]);
                nodes[i] = new Node(val);
            }

            Console.WriteLine("Nodes created successfully!");
        }

        public void DisplayNodes()
        {
            if (nodes == null || nodes.Length == 0)
            {
                Console.WriteLine("No nodes to display.");
                return;
            }

            Console.WriteLine("Displaying nodes:");
            foreach (var node in nodes)
            {
                Console.WriteLine("Node Value: " + node.Value);
            }
        }
    }
}

