# FIFO Animal Shelter

## Challenge
Implement an Animal Shelter class that can add Cats and Dogs and supports Enqueue() and Dequeue(). You can enqueue a Cat, Dog, or Animal, and 
Dequeue(pref), where pref specifies "cat", "dog", or "other."

## Approach & Efficiency
The approach involves creating an AnimalShelter class that has three different queues under the hood: Cats, Dogs, and OtherAnimals. Enqueue() adds
an animal to the appropriate queue, while Dequeue(pref) dequeues an animal from the appropriate queue or returns null if the appropriate
queue is empty.

* Dequeue()
  Time Complexity = O(1)
  Space Complexity = O(1)
* Enqueue()
  Time Complexity = O(1): enqueueing an element to a queue is O(1)
  Space Complexity = O(1)
 

## Solution
![whiteboard-image](../../assets/fifo_animal_shelter.jpg)

