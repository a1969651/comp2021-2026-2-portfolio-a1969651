public class Arrays {
    public string[] names = ["Bob", "Mark", "Tom", "Tyler", "Thomas", "Nic", "Charlie", "Tristan", "Jamal", "Frank"];

    public void printArray() {
        Console.WriteLine("Printing Array:");
        foreach (string name in names){
            Console.WriteLine(name);
        }
    }

    public string longestName() {
        string longest = "";
        foreach(string name in names){
            if (name.Length > longest.Length){
                longest = name;
            }
        }
        return longest;
    }

    public string shortestName() {
        string shortest = names[0];
        foreach(string name in names){
            if (name.Length < shortest.Length){
                shortest = name;
            }
        }
        return shortest;
    }

    public void sortArray() {
        Console.WriteLine("Before Sorting:");
        foreach (string name in names){
            Console.WriteLine(name);
        }
        Array.Sort(names);
        Console.WriteLine("After Sorting:");
        foreach (string name in names){
            Console.WriteLine(name);
        }
    }

    public void reverseArray(){
        Console.WriteLine("Before Reversal:");
        foreach (string name in names){
            Console.WriteLine(name);
        }
        Array.Reverse(names);
        Console.WriteLine("After Reversal:");
        foreach (string name in names){
            Console.WriteLine(name);
        }
    }

    static void Main(){
        Arrays array = new Arrays();
        array.printArray();
        Console.WriteLine("Longest name is: " + array.longestName());
        Console.WriteLine("Shortest name is: " + array.shortestName());
        array.sortArray();
        array.reverseArray();
    }
}