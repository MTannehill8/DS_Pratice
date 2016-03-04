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
            Program menu = new Program();
            int ans;
            ans = menu.displayMenu();
           
        }
        public int displayMenu()
        {
            int userMenuSelection;

            string menuText = "****************Main Menu******************" + Environment.NewLine +
                          "Select which data structure you want to use    " + Environment.NewLine +
                          "1) Double Linked List                          " + Environment.NewLine +
                          "Q) Quit                                        ";


            Console.WriteLine(menuText);
            userMenuSelection = Console.Read();
            return userMenuSelection;
        }
    }
    public class Menu
    {
        
    }
   
    //hello to all my mac friends
    public class DNode
    {
 
        int data_;
        DNode prevNode;
        DNode nextNode;

        public DNode ()
        {

            int num;
        }
    }



    class  DoubLinkedList
    {
        static DNode root;
        static DNode temp;
        static DNode current;

        public void addNode(int data)
        {
            
        }
        public void deleteNode()
        {

        }
        public void insertNodePrev()
        {

        }

        public void insertNodeNext()
        {

        }
       
    }
}
