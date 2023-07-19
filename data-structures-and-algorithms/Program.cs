﻿
using System.Collections.Generic;

namespace data_structures_and_algorithms
{


    public class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter shelter = new AnimalShelter();

            shelter.Enqueue(new Animal("dog", "taz"));
            shelter.Enqueue(new Animal("dog", "nody"));
            shelter.Enqueue(new Animal("cat", "olive"));
            shelter.Enqueue(new Animal("cat", "carmel"));

            Animal dequed1=shelter.Dequeue("cat");
            Console.WriteLine($" Species: {dequed1.Species}, Name: {dequed1.Name}");
            Animal dequed2 = shelter.Dequeue("dog");
            Console.WriteLine($" Species: {dequed2.Species}, Name: {dequed2.Name}");
                   Animal dequed3 = shelter.Dequeue("cat");
            Console.WriteLine($" Species: {dequed3.Species}, Name: {dequed3.Name}");
            Animal dequed4 = shelter.Dequeue("dog");
            Console.WriteLine($" Species: {dequed4.Species}, Name: {dequed4.Name}");

        }
        public class Queue<T>
        {
            private class Node
            {
                public T Data { get; set; }
                public Node Next { get; set; }

                public Node(T data)
                {
                    Data = data;
                    Next = null;
                }
            }

            private Node front;
            private Node rear;

            public Queue()
            {
                front = null;
                rear = null;
            }

            public void Enqueue(T item)
            {
                var newNode = new Node(item);
                if (rear == null)
                {
                    front = rear = newNode;
                    return;
                }

                rear.Next = newNode;
                rear = newNode;
            }

            public T Dequeue()
            {
                if (front == null)
                {
                    throw new InvalidOperationException("Queue is empty.");
                }

                T data = front.Data;
                front = front.Next;

                if (front == null)
                {
                    rear = null;
                }

                return data;
            }

            public bool IsEmpty()
            {
                return front == null;
            }
        }

        public class AnimalShelter
        {
            private Queue<Animal> dogs;
            private Queue<Animal> cats;

            public AnimalShelter()
            {
                dogs = new Queue<Animal>();
                cats = new Queue<Animal>();
            }

            public void Enqueue(Animal animal)
            {
                if (animal.Species == "cat")
                {
                    cats.Enqueue(animal);
                }
                else if (animal.Species == "dog")
                {
                    dogs.Enqueue(animal);
                }

            }

            public Animal Dequeue(string pref)
            {
                if (pref == "dog")
                {
                    return dogs.Dequeue();
                }
                else if (pref == "cat")
                {
                    return cats.Dequeue();
                }
                return null;
            }
        }

        public class Animal
        {
            public string Species { get; set; }
            public string Name { get; set; }

            public Animal(string species, string name)
            {
                Species = species;
                Name = name;
            }
        }


    }

 

}










