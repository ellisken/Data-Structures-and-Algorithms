using System;
using FifoAnimalShelter.Classes;
using Xunit;

namespace TestAnimalShelter
{
    public class UnitTest1
    {
        //Test enqueue otherAnimal
        [Fact]
        public void EnqueueAnimal()
        {
            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(new Animal());
            Assert.True(myShelter.OtherAnimals.Front.Value is Animal);
        }

        //Test enqueue Cat
        [Fact]
        public void EnqueueCat()
        {
            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(new Cat("Fluffy"));
            Assert.True(myShelter.Cats.Front.Value is Cat);
        }

        //Test enqueue Dog
        [Fact]
        public void EnqueueDog()
        {
            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(new Dog("Rex"));
            Assert.True(myShelter.Dogs.Front.Value is Dog);
        }


        //Test dequeue Cat
        [Fact]
        public void DequeueCat()
        {
            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(new Cat("Fluffy"));
            myShelter.Enqueue(new Cat("Felix"));
            Assert.Equal("Fluffy", myShelter.Dequeue("cat").Name);
        }

        //Test dequeue Dog
        [Fact]
        public void DequeueDog()
        {
            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(new Dog("Rex"));
            myShelter.Enqueue(new Dog("Rufus"));
            Assert.Equal("Rex", myShelter.Dequeue("dog").Name);
        }

        //Test dequeue other animal
        [Fact]
        public void DequeueAnimal()
        {
            AnimalShelter myShelter = new AnimalShelter();
            myShelter.Enqueue(new Animal());
            Assert.True(myShelter.Dequeue("other") is Animal);
        }

    }
}
