using data_structures_and_algorithms;
using System.Collections.Generic;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{

    public class UnitTest1
    {
        [Fact]
        public void normalAddition()
        {

            LinkedList l1 = new LinkedList();
            l1.Append(1);
            l1.Append(1);
            l1.Append(1);


            LinkedList l2 = new LinkedList();
            l2.Append(2);
            l2.Append(2);
            l2.Append(2);
            LinkedList l3 = new LinkedList();
            l3 = LinkedList.zipList(l1, l2);

            string expected = "{ 1 } -> { 2 } -> { 1 } -> { 2 } -> { 1 } -> { 2 } -> NULL";
            Assert.Equal(expected, l3.ToString());
        }
        [Fact]
        public void notTheSameSize()
        {

            LinkedList l1 = new LinkedList();
            l1.Append(1);
            l1.Append(1);
            l1.Append(1);


            LinkedList l2 = new LinkedList();
            l2.Append(2);
            l2.Append(2);
            l2.Append(2);
            l2.Append(2);
            l2.Append(2);

            LinkedList l3 = LinkedList.zipList(l1, l2);

            string expected = "{ 1 } -> { 2 } -> { 1 } -> { 2 } -> { 1 } -> { 2 } -> { 2 } -> { 2 } -> NULL";
            Assert.Equal(expected, l3.ToString());
        }
        [Fact]
        public void oneIsEmpty()
        {

            LinkedList l1 = new LinkedList();
            LinkedList l2 = new LinkedList();
            l2.Append(2);
            l2.Append(2);
            l2.Append(2);
            l2.Append(2);
            l2.Append(2);

            LinkedList l3 = LinkedList.zipList(l1, l2);

            string expected = "{ 2 } -> { 2 } -> { 2 } -> { 2 } -> { 2 } -> NULL";
            Assert.Equal(expected, l3.ToString());
        }
    }
}
    








