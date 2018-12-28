using System;
using System.Collections.Generic;
using System.Text;

namespace InorderSucessor
{
    class BinaryTree
    {
        BinaryTreeNode root;

        public void SetRoot(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode GetRoot() {
            return root;
        }

        public BinaryTreeNode Insert(BinaryTreeNode node,  int data) {
            if (node == null) {
                node = new BinaryTreeNode();
                node.SetData(data);
                return node;
            }

            if (node.GetData() < data)
            {
                node.SetRightNode(Insert(node.GetRightNode(), data));
            }
            else {
                node.SetLeftNode(Insert(node.GetLeftNode(), data));
            }

            return node;
        }

        public void PrintInorderTraversal(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }

            PrintInorderTraversal(binaryTreeNode.GetLeftNode());
            Console.Write(binaryTreeNode.GetData()+"->");
            PrintInorderTraversal(binaryTreeNode.GetRightNode());
        }

        public void PrintInorderSuccessor(BinaryTreeNode node, int data) {
            if (node == null) {
                Console.WriteLine("Tree is empty! There can be no inorder successor");
            }
            if (node.GetData() == data) {
                if (node.GetLeftNode() != null)
                {
                    while (node.GetLeftNode() != null &&
                        node.GetLeftNode().GetLeftNode() != null)
                    {
                        node = node.GetLeftNode();
                    }
                    Console.WriteLine("Inorder successor is " + node.GetData());
                }
                else if (node.GetRightNode() != null)
                {
                    node = node.GetRightNode();
                    while (node.GetLeftNode() != null &&
                        node.GetLeftNode().GetLeftNode() != null)
                    {
                        node = node.GetLeftNode();
                    }
                    Console.WriteLine("Inorder successor is " + node.GetData());
                }
                else {
                    Console.WriteLine("There is no inorder successor for the given node as it is the last node in the tree!");
                }
                return;
            }
            if (node.GetData() < data)
            {
                PrintInorderSuccessor(node.GetRightNode(), data);
            }
            else {
                PrintInorderSuccessor(node.GetLeftNode(), data);
            }
        }
    }
}
