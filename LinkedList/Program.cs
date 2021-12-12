
using System;
namespace DataStructure
{
    class program
    {
        static void Main(string[] arg)
        {
            
            LinkedList LinkedList = new LinkedList();
            LinkedList.AddReverse(56);
            LinkedList.AddReverse(30);
            LinkedList.AddReverse(70);
            LinkedList.Display();
            LinkedList.InsertAtParticularPosition(2, 30);
            Console.WriteLine("------");
        }
    }

}