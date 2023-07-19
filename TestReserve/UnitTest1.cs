using data_structures_and_algorithms;
using System.Collections;
using System.Collections.Generic;
using static data_structures_and_algorithms.Program;

namespace TestReserve
{

    public class UnitTest1
    {
        [Fact]
        public void AddingToCatsAndDogsAndDequeueCat()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("dog", "taz"));
            shelter.Enqueue(new Animal("dog", "nody"));
            shelter.Enqueue(new Animal("cat", "olive"));
            shelter.Enqueue(new Animal("cat", "carmel"));

            Animal res = new Animal("cat", "olive");
            Assert.Equal(res.Name, shelter.Dequeue("cat").Name);
        }

        [Fact]
        public void AddingToCatsAndDogsAndDequeueDog()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("dog", "taz"));
            shelter.Enqueue(new Animal("dog", "nody"));
            shelter.Enqueue(new Animal("cat", "olive"));
            shelter.Enqueue(new Animal("cat", "carmel"));

            Animal res = new Animal("dog", "taz");
            Assert.Equal(res.Name, shelter.Dequeue("dog").Name);
        }  [Fact]
        public void DequeueReturnNull()
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Animal("dog", "taz"));
            shelter.Enqueue(new Animal("dog", "nody"));
            shelter.Enqueue(new Animal("cat", "olive"));
            shelter.Enqueue(new Animal("cat", "carmel"));

            Assert.Equal(null, shelter.Dequeue("rabbits"));
        }
    }
}










