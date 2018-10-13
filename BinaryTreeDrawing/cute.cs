using System;

namespace BinaryTreeDrawing
{
    class cute
    {
        static void Main(string[] args)
        {
            BtreeRoot testtree1 = new BtreeRoot(3,2,4,5,1);
            BtreeRoot testtree2 = new BtreeRoot(1,2,3,4,5);
            BtreeRoot testtree3 = new BtreeRoot(22,51,555,123,331,32);
            Console.WriteLine("testtree1");
            TreeFunctions.printTree(testtree1);
            Console.WriteLine("testtree2");
            TreeFunctions.printTree(testtree2);
            Console.WriteLine("testtree3");
            TreeFunctions.printTree(testtree3);
            Console.ReadLine();
        }
    }
}
