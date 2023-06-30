using data_structures_and_algorithms;

namespace TestReserve
{
   
        public class UnitTest1
        {
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

    }
}


    


