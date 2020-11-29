﻿using System;
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
            while (p != null)
            {
                Console.Write(p + " ");
                p = p.GetNext();
            }    
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
            //returns the node's length
            if (p == null)
                return 0;
            else
                return Length(p.GetNext()) + 1;
        }
        static Node<int> GetLast(Node<int> p)
        {
            //finds the last node in linked Nodes
            if (p.GetNext() == null)
                return p;
            else
                return GetLast(p.GetNext());
        }
        static bool Found (Node<int> first, int x)
        {
            //finds if x is in first
            return first.GetValue() == x;
        }
        static int Count (Node<int> first, int number)
        {
            //counts how many times the in number appears in the Linked Node List
            if (first.GetNext() == null)
                return first.GetValue() == number ? 1 : 0;
            else
                return Count(first.GetNext(), number) + first.GetValue() == number ? 1 : 0;
        }

        static Node<int> FindBefore (Node<int> top, Node<int> p)
        {
            // returns the node before p
            // top is the first
            if (top.GetNext() == p)
                return p;
            else
                return FindBefore(top.GetNext(), p);
        }
        static int Sum (Node<int> first)
        {
            // returns the sum of nodes in linked nodes
            if (first.GetNext() == null)
                return first.GetValue();
            else
                return Sum(first.GetNext()) + first.GetValue();
        }
        static double GetAverage (Node<int>first)
        {
            // returns the average of all nodes
            return Sum(first) / Length(first);
        }
        static bool IsSorted (Node<int> p)
        {
            // checks and returns wether nodes are sorted or not
            if (p.GetNext() == null)
                return true;
            else
                return p.GetValue() < p.GetNext().GetValue() && IsSorted(p.GetNext());
        }
        static Node<int> Prev (Node<int> first, Node<int> p)
        {
            if (first.GetNext() == p)
                return p;
            else
                return Prev(first.GetNext(), p);
        }
        
    
      
        static void Main(string[] args)
        {
           
            Node<int> first = Generate_Nodes(12);
            Print(first);
            Console.ReadKey();
        }
    }
}
