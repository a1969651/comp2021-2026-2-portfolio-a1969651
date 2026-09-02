using System.Collections.Generic;

public class LinkedList {

    static void PrintList(LinkedList<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

    static void Main(){
        var numbers = new LinkedList<int>();
        numbers.AddFirst(12);
        numbers.AddFirst(10);
        numbers.AddFirst(64);
        numbers.AddFirst(99);
        Console.WriteLine("Add four numbers to front of list");
        PrintList(numbers);

        numbers.AddLast(20);
        numbers.AddLast(5);
        numbers.AddLast(72);
        numbers.AddLast(21);
        Console.WriteLine("Add four numbers to end of list");
        PrintList(numbers);

        LinkedListNode<int> pos_10 = numbers.Find(10);
        numbers.AddBefore(pos_10, 32);
        numbers.AddAfter(pos_10, 71);
        Console.WriteLine("Add two numbers on either side of 10");
        PrintList(numbers);

        numbers.Remove(10);
        numbers.RemoveFirst();
        numbers.RemoveLast();
        Console.WriteLine("Removed 10, first and last number in list");
        PrintList(numbers);


        LinkedListNode<int> ind_5 = numbers.First;
        for (int i = 1; i < 5; i++){
            ind_5 = ind_5.Next;
        }
        numbers.Remove(ind_5);

        Console.WriteLine("Removed 5th element");
        PrintList(numbers);
    }
}