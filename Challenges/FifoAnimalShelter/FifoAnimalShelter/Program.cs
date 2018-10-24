using FifoAnimalShelter.Classes;
using System;

namespace FifoAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the animal shelter!");
            FIFOAnimalShelter();
        }

        public static void FIFOAnimalShelter()
        {
            //Create animal shelter
            Console.WriteLine("Preparing the shelter...\n\n");
            AnimalShelter myShelter = new AnimalShelter();

            //Add cat
            Console.WriteLine("A cat has just been placed for adoption.");
            myShelter.Enqueue(new Cat("Fluffy"));

            //Add dog
            Console.WriteLine("A dog named Rufus has just been placed for adoption.");
            myShelter.Enqueue(new Dog("Rufus"));
            Console.WriteLine("Another dog named Benji has just been placed for adoption.");
            myShelter.Enqueue(new Dog("Benji"));

            //Add "Animal"
            Console.WriteLine("A strange, other animal has been placed for adoption.");
            myShelter.Enqueue(new Animal());

            //Request dog
            Console.WriteLine("I would like to adopt a dog, please...");
            Dog myDog = (Dog)myShelter.Dequeue("dog");
            Console.WriteLine($"Here's your new dog, his name is: {myDog.Name}");
        }
    }
}
