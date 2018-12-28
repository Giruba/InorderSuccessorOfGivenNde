using System;
using System.Collections.Generic;
using System.Text;

namespace InorderSucessor
{
    class BinaryTreeNode
    {
        int data;
        BinaryTreeNode left;
        BinaryTreeNode right;

        public int GetData(){
            return data;
        }

        public BinaryTreeNode GetLeftNode() {
            return left;
        }

        public BinaryTreeNode GetRightNode() {
            return right;
        }

        public void SetData(int data) {
            this.data = data;
        }

        public void SetLeftNode(BinaryTreeNode leftNode) {
            left = leftNode;
        }

        public void SetRightNode(BinaryTreeNode rightNode) {
            right = rightNode;
        }
    }
}
