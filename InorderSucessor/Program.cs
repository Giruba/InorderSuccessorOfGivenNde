using System;

namespace InorderSucessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inorder Successor!");
            Console.WriteLine("------------------");
            try
            {
                BinaryTree binaryTree = ConstructTreeFromInput();
                binaryTree.PrintInorderTraversal(binaryTree.GetRoot());
                Console.WriteLine();
                Console.WriteLine("Enter the element whose inorder successor has to be found!");
                int element = int.Parse(Console.ReadLine());
                binaryTree.PrintInorderSuccessor(binaryTree.GetRoot(),element);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown Exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static BinaryTree ConstructTreeFromInput()
        {
            BinaryTree binaryTree = null;
            Console.WriteLine("Enter the number of elements in the tree");
            try {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                binaryTree = new BinaryTree();
                for (int i = 0; i < noElements; i++) {
                    binaryTree.SetRoot(binaryTree.Insert(binaryTree.GetRoot(), 
                        int.Parse(elements[i])));
                }
            } catch(Exception exception)
            {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return binaryTree;
        }
    }
}
