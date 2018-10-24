using System;
using StackAndQueue.Classes;
using System.Text;

namespace FifoAnimalShelter.Classes
{
    public class AnimalShelter
    {
        //Create a queue for each animal type
        public Queue Cats = new Queue(null);
        public Queue Dogs = new Queue(null);
        public Queue OtherAnimals = new Queue(null);

        /// <summary>
        /// Adds a new Cat, Dog, or other animal to the Shelter's appropriate "kennel"
        /// </summary>
        /// <param name="animal">Animal to be added to the shelter</param>
        public void Enqueue(Animal animal)
        {
            if (animal is Cat) Cats.Enqueue(new Node(animal));
            else if (animal is Dog) Dogs.Enqueue(new Node(animal));
            else OtherAnimals.Enqueue(new Node(animal));
        }


        /// <summary>
        /// Returns earliest Cat or Dog (depending on pref) in the queue.
        /// </summary>
        /// <param name="pref">Cat or Dog</param>
        /// <returns>Earliest Cat or Dog in the queue. If preferred animal is not available, returns
        /// null, else tries to return another type of animal.</returns>
        public Animal Dequeue(string pref)
        {
            if(pref.ToLower() == "cat")
            {
                if (Cats.Peek() == null) return null;
                return (Cat)Cats.Dequeue().Value;
            }
            else if(pref.ToLower() == "dog")
            {
                if (Dogs.Peek() == null) return null;
                return (Dog)Dogs.Dequeue().Value;
            }
            else
            {
                if (OtherAnimals.Peek() == null) return null;
                else return (Animal)OtherAnimals.Dequeue().Value;
            }
        }
    }
}
