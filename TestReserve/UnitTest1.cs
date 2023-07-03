using data_structures_and_algorithms;
using System.Collections.Generic;

namespace TestReserve
{

    public class UnitTest1
    {//test units CC6
        [Fact]
        public void EmptyLinkedList()
        {
            LinkedList linkedList = new LinkedList();
            Assert.Equal(null, linkedList.Head);
        }

        [Fact]
        public void Append()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);

            Assert.Equal(5, linkedList.Head.Value);
        }

        [Fact]
        public void Head()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);
            linkedList.Append(10);
            Assert.Equal(5, linkedList.Head.Value);
        }

        [Fact]
        public void AppendMultiple()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);
            linkedList.Append(10);
            linkedList.Append(15);
            Assert.NotNull(linkedList.Tail);
            Assert.Equal(15, linkedList.Tail.Value);
        }



        [Fact]
        public void AllLinkedList()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);
            linkedList.Append(10);
            linkedList.Append(15);
            string expected = "{ 5 } -> { 10 } -> { 15 } -> NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }
        [Fact]
        public void BeforeMiddle()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);
            linkedList.Append(10);
            linkedList.Append(15);
            linkedList.InsertBefore(10, 7);
            string expected = "{ 5 } -> { 7 } -> { 10 } -> { 15 } -> NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void BeforeFirst()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);
            linkedList.Append(10);
            linkedList.InsertBefore(5, 2);
            string expected = "{ 2 } -> { 5 } -> { 10 } -> NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AfterMiddle()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);
            linkedList.Append(10);
            linkedList.Append(15);
            linkedList.InsertAfter(10, 12);
            string expected = "{ 5 } -> { 10 } -> { 12 } -> { 15 } -> NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AfterLast()
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Append(5);
            linkedList.Append(10);
            linkedList.InsertAfter(10, 13);
            string expected = "{ 5 } -> { 10 } -> { 13 } -> NULL";
            string result = linkedList.ToString();
            Assert.Equal(expected, result);
        }


        /// <summary>
        /// test code challenge 7
        /// </summary>
        [Fact]
        public void kGreaterThanLength()
        {
            LinkedList List = new LinkedList();
            List.Append(1);
            List.Append(3);
            List.Append(8);
            List.Append(2);
            int k = 10;
            string kthValue = List.KthFromEnd(k);
            string expected = "out of range";
            string result = kthValue;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void kSameAsLength()
        {
            LinkedList List = new LinkedList();
            List.Append(1);
            List.Append(3);
            List.Append(8);
            List.Append(2);
            int k = 3;
            string kthValue = List.KthFromEnd(k);
            string expected = "1";
            string result = kthValue;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void LengthIsOne()
        {
            LinkedList List = new LinkedList();
            List.Append(1);
            int k = 0;
            string kthValue = List.KthFromEnd(k);
            string expected = "1";
            string result = kthValue;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void inTheMiddle()
        {
            LinkedList List = new LinkedList();
            List.Append(1);
            List.Append(2);
            List.Append(3);
            int k = 1;
            string kthValue = List.KthFromEnd(k);
            string expected = "2";
            string result = kthValue;
            Assert.Equal(expected, result);
        }


    }
}





