
using System;
namespace DataStructure
{
    class program
    {
        static void Main(string[] arg)
        {
            
            LinkedList LinkedList = new LinkedList();
            LinkedList.AddReverse(70);
            LinkedList.AddReverse(30);
            LinkedList.AddReverse(56);
            LinkedList.Display();
            Console.WriteLine("------");
        }
    }

}