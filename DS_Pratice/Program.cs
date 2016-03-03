using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Pratice
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class DNode
    {
        static int noOfLinkedList = 0;
        int data;
        DNode prevNode;
        DNode nextNode;

        public DNode (int data)
        {
            this.data = data;
            noOfLinkedList++;
        }
    }

    class SinLinkedList
    {
        public void addNode()
        {

        }
        public void deleteNode()
        {

        }

    }

    class  DoubLinkedList
    {
        static DNode root;
        static DNode temp;
        static DNode current;

        public void addNode(int data)
        {
            DNode dNode = new DNode(data);
        }
        public void deleteNode()
        {

        }
        public void insertNode()
        {

        }
    }
}
