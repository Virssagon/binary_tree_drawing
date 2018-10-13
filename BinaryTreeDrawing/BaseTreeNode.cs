using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeDrawing
{
    abstract class BaseTreeNode
    {
        private BtreeNode leftChild;
        private BtreeNode rightChild;
        private int val;
        private bool isleaf;
        
        public bool Isleaf { get; set; }
        public BtreeNode LeftChild { get; set; }
        public BtreeNode RightChild { get; set; }
        public int Val { get; set; }
    }
}
