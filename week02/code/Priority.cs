public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: I am going to write a test to see if it can handle simple priorty queueing
        // Expected Result: The item with highest priority will be first and the lowest priority will be last
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("orange", 3);
        priorityQueue.Enqueue("apple", 1);
        priorityQueue.Enqueue("pear", 2);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        

        // Defect(s) Found: I had to change the boundary so that it wasn't -1. this made it so it will get the item with the
        //highest priority 
        //I also had to add this: _queue.RemoveAt(highPriorityIndex); so that way it would remove the highest priority item

        Console.WriteLine("---------");

        // Test 2
        // Scenario: This test will see what happens when there is nothing left in the queue
        // Expected Result: it should display a message saying nothing is in the queue
        Console.WriteLine("Test 2");

        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: This test will show what happens when to items have the same priority number
        // Expected Result: The items with the same priority number will be handled by the item added to the queue first
        //will be the first one out of the queue. so if item 1 was enqueued and then item 2 was enqueued and they had the 
        //same priority number, then item 1 would be the first to be dequeued.
        Console.WriteLine("Test 3");

        priorityQueue.Enqueue("orange", 3);
        priorityQueue.Enqueue("apple", 1);
        priorityQueue.Enqueue("pear", 2);
        priorityQueue.Enqueue("cherry", 2);
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: I had to change the >= to > so that way it can handle items with the same priority number

        Console.WriteLine("---------");

    }
}