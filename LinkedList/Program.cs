
using System;
namespace DataStructure
{
    class program
    {
        static void Main(string[] arg)
        {
            
            LinkedList LinkedList = new LinkedList();
            LinkedList.Add(56);
            LinkedList.Add(30);
            LinkedList.Add(70);
            LinkedList.Display();
           
            //LinkedList.RemoveFirstNode();
            //Console.WriteLine("After removing is : ");
            //LinkedList.Display();
            //LinkedList.InsertAtParticularPosition(2, 30);
            LinkedList.RemoveLastNode();
            LinkedList.Display();
            Console.WriteLine("------");
        }
    }

}