using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace NodeLink
{
    class Program
    {
        // Node functions
        static void Print (Node<int>p)
        {
            throw new NotImplementedException();
        }
        static Node<int> Generate_Nodes (int count)
        {
            Random rnd = new Random();
            Node<int> first = new Node<int>(rnd.Next(30) + 1);
            Node<int> last = first;
            for (int i =1; i < count; i++)
            {
                last.SetNext(new Node<int>( rnd.Next (30) + 1));
                last = last.GetNext();
            }
            return first;
        }
        static int Length (Node<int> p)
        {
            // find how many nodes after p
            throw new NotImplementedException();
        }
        static Node<int> GetLast(Node<int> p)
        {
            //finds the last node in linked Nodes
            throw new NotImplementedException();
        }
        static bool Found (Node<int> first, int x)
        {
            //finds if x is in first
            throw new NotImplementedException();
        }
        static bool Count (Node<int> first, int number)
        {
            //counts how many times the in number appears in the Linked Node List
            throw new NotImplementedException();
        }

        public Node<int> FindBefore (Node<int> top, Node<int> p)
        {
            // returns the node before p
            //top is the first
            throw new NotImplementedException();
        }
        public int Sum (Node<int> first)
        {
            // returns the sum of nodes in linked nodes
            throw new NotImplementedException();
        }
        public double GetAverage (Node<int>first)
        {
            // returns the average of all nodes
            throw new NotImplementedException();
        }
        static bool IsSorted (Node<int> p)
        {
            // checks and returns wether nodes are sorted or not
            throw new NotImplementedException();
        }
        public static Node<int> Prev (Node<int> first, Node<int> p)
        {
            throw new NotImplementedException();
        }
        
    
      
        static void Main(string[] args)
        {
           
            Node<int> first = Generate_Nodes(12);
            Print(first);
            Console.ReadKey();
        }
    }
}
