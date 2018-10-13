using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeDrawing
{
    class BtreeRoot : BaseTreeNode
    {

        private int height = 0;
        public BtreeRoot(params int[] initValues)
        {
            if(initValues.Length > 0)
            {
                this.Isleaf = false;
            }
            for (int i = 0; i < initValues.Length; i++)
            {
                this.addElement(initValues[i]);
            }
        }
        public void addElement(int value)
        {
            BaseTreeNode currNode = this;
            while(true)
            {
                if(currNode.Val == 0)
                {
                    currNode.Val = value;
                    return;
                }
                if(value < currNode.Val)
                {
                    if(currNode.LeftChild == null){
                        currNode.LeftChild = new BtreeNode { Val = value, Isleaf = true };
                        currNode.Isleaf = false;
                        return;
                        //height++; Nur ein mal hoch zählen, sonst doppelte height
                    }
                    else
                    {
                        currNode = currNode.LeftChild;
                        continue;
                    }
                }
                else if (value > currNode.Val)
                {
                    if(currNode.RightChild == null)
                    {
                        currNode.RightChild = new BtreeNode { Val = value, Isleaf = true };
                        currNode.Isleaf = false;
                        return;
                        //height++; Nur ein mal hoch zählen, sonst doppelte height
                    }
                    else
                    {
                        currNode = currNode.RightChild;
                        continue;
                    }
                } else
                {
                    System.Console.Write("Error: no duplicated Values allowed");
                    return;
                }
            }
        }

        
        public BtreeRoot reBuild()
        {
            //Baut den Tree neu und ausgeglichen
            return new BtreeRoot();
        }
    }
}
