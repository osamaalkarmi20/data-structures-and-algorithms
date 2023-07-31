using data_structures_and_algorithms;
using System.Collections;
using System.Collections.Generic;
using static data_structures_and_algorithms.Program;
using static data_structures_and_algorithms.Program.BinaryTree;

namespace TestReserve
{

    public class UnitTest1
    {
       
        public class BinarySearchTreeTests
        {
            [Fact]
            public void TestEmptyTree()
            {
                BinarySearchTree testTree = new BinarySearchTree();
                Assert.False(testTree.Contains(5));
            }
            private BinarySearchTree CreateBinarySearchTree()
            {
                BinarySearchTree testTree = new BinarySearchTree();
                testTree.Add(100);
                testTree.Add(50);
                testTree.Add(200);
                testTree.Add(25);
                testTree.Add(75);
                testTree.Add(150);
                testTree.Add(300);
                testTree.Add(60);
                testTree.Add(90);
                testTree.Add(342);
                return testTree;
            }

            [Fact]
            public void HappyPath()
            {
               
               BinarySearchTree testTree = CreateBinarySearchTree();

                int result = testTree.Max_tree();

                
                Assert.Equal(342, result);
            }

            [Fact]
            public void Max_tree_TreeIsEmpty()
            {
                
                BinarySearchTree testTree = new BinarySearchTree();

                int result = testTree.Max_tree();

              
                Assert.Equal(0, result);
            }

            [Fact]
            public void Max_tree_WhenSingleNodeTree()
            {
               
                BinarySearchTree testTree = new BinarySearchTree();
                testTree.Add(42);

                
                int result = testTree.Max_tree();

                
                Assert.Equal(42, result);
            }
        }
    }
        }
   











