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
        //Test dequeue Dog
        //Test dequeue other animal

    }
}
