using data_structures_and_algorithms;
using System.Collections;
using System.Collections.Generic;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{

    public class UnitTest1
    {
       
        public class BinarySearchTreeTests
        {
            [Fact]
            public void CanInstantiateEmptyTree()
            {
                // Arrange
                BinarySeartchTree<int> binarySearchTree = new BinarySeartchTree<int>();

                // Act & Assert
                Assert.Null(binarySearchTree.Root);
            }

            [Fact]
            public void CanInstantiateTreeWithSingleRootNode()
            {
                // Arrange
                BinarySeartchTree<int> binarySearchTree = new BinarySeartchTree<int>();
                int rootValue = 50;

                // Act
                binarySearchTree.Add(rootValue);

                // Assert
                Assert.NotNull(binarySearchTree.Root);
                Assert.Equal(rootValue, binarySearchTree.Root.Value);
                Assert.Null(binarySearchTree.Root.Left);
                Assert.Null(binarySearchTree.Root.Right);
            }

            [Fact]
            public void CanAddLeftAndRightChildToNode()
            {
                // Arrange
                BinarySeartchTree<int> binarySearchTree = new BinarySeartchTree<int>();
                int rootValue = 50;
                int leftChildValue = 30;
                int rightChildValue = 70;

                // Act
                binarySearchTree.Add(rootValue);
                binarySearchTree.Add(leftChildValue);
                binarySearchTree.Add(rightChildValue);

                // Assert
                Assert.NotNull(binarySearchTree.Root.Left);
                Assert.NotNull(binarySearchTree.Root.Right);
                Assert.Equal(leftChildValue, binarySearchTree.Root.Left.Value);
                Assert.Equal(rightChildValue, binarySearchTree.Root.Right.Value);
            }

            [Fact]
            public void CanReturnCollectionFromPreOrderTraversal()
            {
                // Arrange
                BinarySeartchTree<int> binarySearchTree = new BinarySeartchTree<int>();
                binarySearchTree.Add(50);
                binarySearchTree.Add(30);
                binarySearchTree.Add(70);
                binarySearchTree.Add(20);
                binarySearchTree.Add(40);
                binarySearchTree.Add(60);
                binarySearchTree.Add(80);

                // Act
                var result = binarySearchTree.PreOrderTravarsel();

                // Assert
                int[] expected = new int[] { 50, 30, 20, 40, 70, 60, 80 };
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CanReturnCollectionFromInOrderTraversal()
            {
                // Arrange
                BinarySeartchTree<int> binarySearchTree = new BinarySeartchTree<int>();
                binarySearchTree.Add(50);
                binarySearchTree.Add(30);
                binarySearchTree.Add(70);
                binarySearchTree.Add(20);
                binarySearchTree.Add(40);
                binarySearchTree.Add(60);
                binarySearchTree.Add(80);

                // Act
                var result = binarySearchTree.InorderTraversal();

                // Assert
                int[] expected = new int[] { 20, 30, 40, 50, 60, 70, 80 };
                Assert.Equal(expected, result);
            }

            [Fact]
            public void CanReturnCollectionFromPostOrderTraversal()
            {
                // Arrange
                BinarySeartchTree<int> binarySearchTree = new BinarySeartchTree<int>();
                binarySearchTree.Add(50);
                binarySearchTree.Add(30);
                binarySearchTree.Add(70);
                binarySearchTree.Add(20);
                binarySearchTree.Add(40);
                binarySearchTree.Add(60);
                binarySearchTree.Add(80);

                // Act
                var result = binarySearchTree.PostorderTraversal();

                // Assert
                int[] expected = new int[] { 20, 40, 30, 60, 80, 70, 50 };
                Assert.Equal(expected, result);
            }

            [Fact]
            public void ContainsReturnsTrueForExistingNodeValue()
            {
                // Arrange
                BinarySeartchTree<int> binarySearchTree = new BinarySeartchTree<int>();
                binarySearchTree.Add(50);
                binarySearchTree.Add(30);
                binarySearchTree.Add(70);
                binarySearchTree.Add(20);
                binarySearchTree.Add(40);
                binarySearchTree.Add(60);
                binarySearchTree.Add(80);

                // Act
                bool result = binarySearchTree.Contains(40);

                // Assert
                Assert.True(result);
            }

            [Fact]
            public void ContainsReturnsFalseForNonExistingNodeValue()
            {
                // Arrange
                BinarySeartchTree<int> binarySearchTree = new BinarySeartchTree<int>();
                binarySearchTree.Add(50);
                binarySearchTree.Add(30);
                binarySearchTree.Add(70);
                binarySearchTree.Add(20);
                binarySearchTree.Add(40);
                binarySearchTree.Add(60);
                binarySearchTree.Add(80);

                // Act
                bool result = binarySearchTree.Contains(90);

                // Assert
                Assert.False(result);
            }
        }
    }



}











