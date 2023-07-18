using data_structures_and_algorithms;
using System.Collections;
using System.Collections.Generic;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{

    public class UnitTest1
    {
        [Fact]
        public void EnqueueDequeueQueue()
        {
            Program.Queue queue = new Program.Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            int dequeueValue = queue.Dequeue();
            Assert.Equal(1, dequeueValue);

        }
        [Fact]
        public void DequeueThrowsException()
        {
            Program.Queue queue = new Program.Queue();
            
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

    }

}










