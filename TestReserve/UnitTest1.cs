using data_structures_and_algorithms;

namespace TestReserve
{
  
        public class UnitTest1
        {

            [Fact]
            public void EmptyLinkedList()
            {
                LinkedList linkedList = new LinkedList();
                Assert.Equal(null,linkedList.Head);
            }

            [Fact]
            public void Insert()
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Insert(5);
       
                Assert.Equal(5, linkedList.Head.Value);
            }

            [Fact]
            public void Head()
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Insert(5);
                linkedList.Insert(10);
                Assert.Equal(5, linkedList.Head.Value);
            }

            [Fact]
            public void InsertMultiple()
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Insert(5);
                linkedList.Insert(10);
                linkedList.Insert(15);
                Assert.NotNull(linkedList.Tail);
                Assert.Equal(15, linkedList.Tail.Value);
            }

            [Fact]
            public void IncludeTrue()
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Insert(5);
                linkedList.Insert(10);
                linkedList.Insert(15);
                bool exists = linkedList.Includes(10);
                Assert.Equal(true,exists);
            }

            [Fact]
            public void IncludeFalse()
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Insert(5);
                linkedList.Insert(10);
                linkedList.Insert(15);
                bool exists = linkedList.Includes(20);
                Assert.Equal(false,exists);
            }

            [Fact]
            public void AllLinkedList()
            {
                LinkedList linkedList = new LinkedList();
                linkedList.Insert(5);
                linkedList.Insert(10);
                linkedList.Insert(15);
                string expected = "{ 5 } -> { 10 } -> { 15 } -> NULL";
                string result = linkedList.ToString();
                Assert.Equal(expected, result);
            }
        }
    }


