using System;

namespace BinaryTreeDrawing
{
    class TreeFunctions
    {
        static public void printTree(BaseTreeNode node) //in order print
        {
            if (node == null)
            {
                return;
            }
            printTree(node.LeftChild);

            Console.WriteLine(node.Val + " ");

            printTree(node.RightChild);
        }
    }
    
}