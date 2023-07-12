using data_structures_and_algorithms;
using System.Collections;
using System.Collections.Generic;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{

    public class UnitTest1
    {

        [Fact]
        public void PushStack()
        {
            Program.Stack stack = new Program.Stack();
            stack.Push(10);

            int peekValue = stack.Peek();
            Assert.Equal(10, peekValue);
        }

        [Fact]
        public void PushMultipleStack()
        {
            Program.Stack stack = new Program.Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            int peekValue = stack.Peek();
            Assert.Equal(30, peekValue);
        }

        [Fact]
        public void PopRemovesStack()
        {
            Program.Stack stack = new Program.Stack();
            stack.Push(10);
            stack.Push(20);

            int popValue = stack.Pop();
            Assert.Equal(20, popValue);

            int peekValue = stack.Peek();
            Assert.Equal(10, peekValue);
        }

        [Fact]
        public void PopMultiplePops()
        {
            Program.Stack stack = new Program.Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            stack.Pop();
            stack.Pop();
            stack.Pop();

            bool isEmpty = stack.IsEmpty();
            Assert.True(isEmpty);
        }

        [Fact]
        public void PeekStack()
        {
            Program.Stack stack = new Program.Stack();
            stack.Push(10);
            stack.Push(20);

            int peekValue = stack.Peek();
            Assert.Equal(20, peekValue);
        }

        [Fact]
        public void IsEmptyStack()
        {
            Program.Stack stack = new Program.Stack();
            bool isEmpty = stack.IsEmpty();
            Assert.True(isEmpty);
        }

        [Fact]
        public void PopThrowsException()
        {
            Program.Stack stack = new Program.Stack();
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void PeekThrowsException()
        {
            Program.Stack stack = new Program.Stack();
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }



        [Fact]
        public void EnqueueQueue()
        {
            Program.Queue queue = new Program.Queue();
            queue.Enqueue(10);

            int peekValue = queue.Peek();
            Assert.Equal(10, peekValue);
        }

        [Fact]
        public void EnqueueMultipleQueue()
        {
            Program.Queue queue = new Program.Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            int peekValue = queue.Peek();
            Assert.Equal(10, peekValue);
        }

        [Fact]
        public void DequeueQueue()
        {
            Program.Queue queue = new Program.Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);

            int dequeueValue = queue.Dequeue();
            Assert.Equal(10, dequeueValue);

            int peekValue = queue.Peek();
            Assert.Equal(20, peekValue);
        }

        [Fact]
        public void DequeueMultipleDequeues()
        {
            Program.Queue queue = new Program.Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            bool isEmpty = queue.IsEmpty();
            Assert.True(isEmpty);
        }

        [Fact]
        public void PeekQueue()
        {
            Program.Queue queue = new Program.Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);

            int peekValue = queue.Peek();
            Assert.Equal(10, peekValue);
        }

        [Fact]
        public void IsEmptyQueue()
        {
            Program.Queue queue = new Program.Queue();
            bool isEmpty = queue.IsEmpty();
            Assert.True(isEmpty);
        }

        [Fact]
        public void DequeueThrowsException()
        {
            Program.Queue queue = new Program.Queue();
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Fact]
        public void PeekThrowsExceptionQueue()
        {
            Program.Queue queue = new Program.Queue();
            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }
    }

}










