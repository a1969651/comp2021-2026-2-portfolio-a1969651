using System;
using System.Collections.Generic;
using System.Linq;

public class Lists {
    static void Main(){
        List<string> students = new List<string>();
        string[] names = ["Bob", "Mark", "Tom", "Tyler", "Thomas", "Nic", "Charlie", "Tristan", "Jamal", "Frank"];

        students.Add("Bob");
        students.Add("Mark");
        students.Add("Tyler");

        students.AddRange(new List<string> 
        {
            "Jimmy",
            "Bobby",
            "Nick",
            "Timmy",
            "Tom",
            "Will",
            "Jebediah",
            "Seb",
            "John"
        });

        Console.WriteLine("Added Names");
        Console.WriteLine("Current count of students = " + students.Count);
        
        students.Remove("John");
        Console.WriteLine("Removed John");
        students.Remove("Bobby");
        Console.WriteLine("Removed Bobby");

        Console.WriteLine("Current count of students = " + students.Count);

        students.Insert(2, "Liam");
        Console.WriteLine("Added Liam at spot 2");
        Console.WriteLine("Current count of students = " + students.Count);

        Console.WriteLine("Getting index of where Nick is in the List: " + students.IndexOf("Nick"));

        Console.WriteLine("Searching for anyone that has y in there name");
        foreach (string name in students)
        {
            if (name.Contains("y"))
            {
                Console.WriteLine(name);
            }
        }

        int len = 0;
        foreach(string name in students)
        {
            len = len + name.Length;
        }
        Console.WriteLine("Calculating the length of all names = " + len);

        Console.WriteLine("Current count of students = " + students.Count);
        Console.WriteLine("Converting names array to list and adding it to students");
        List<string> nameList = names.ToList();
        students.AddRange(nameList);
        Console.WriteLine("Current count of students = " + students.Count);
    }
}
