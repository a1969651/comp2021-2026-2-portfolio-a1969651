public class Person {
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
        public double Age { get; set 
        {
            if (value <= 0.0) {
                throw new ArgumentException("Age can't be less than 0");
            } else
            {
                field = value;
            }
            }
        }

    public string FullName => $"{FirstName}, {LastName}";


    public Person(string firstName, string lastName, double age)
    {
        FirstName = firstName;
        LastName = lastName;
        if (age <= 0.0f)
        {
        throw new ArgumentException("Age should be greater than zero");
        }
        Age = age;
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }

    static void Main(){
        List<Person> people = new List<Person>();

        people.Add(new Person("Jeremy", "Brown", 54));
        people.Add(new Person("Frank", "Smtih", 22));
        people.Add(new Person("Jimmy", "Swooden", 68));
        people.Add(new Person("Nick", "Potrick", 34));
        people.Add(new Person("Thomas", "Secc", 24));
        people.Add(new Person("Cooper", "Jims", 71));
        people.Add(new Person("Buddy", "Longe", 45));
        people.Add(new Person("William", "Brown", 29));
        people.Add(new Person("George", "Dereta", 37));
        people.Add(new Person("Jebediah", "Franklin", 63));

        LinkedList<Person> linkedPeopleList = Person.ToLinkedList(people);
        Console.WriteLine("Added 10 people and converted it to linked list:");
        Console.WriteLine(Person.PrintPeople(linkedPeopleList));

        LinkedList<Person> AgeSorted = Person.SortPeople(linkedPeopleList);
        Console.WriteLine("Sorted list by age:");
        Console.WriteLine(Person.PrintPeople(AgeSorted));

    }

    public static LinkedList<Person> ToLinkedList(List<Person> people){
        LinkedList<Person> linkedPeopleList = new LinkedList<Person>();

        foreach (Person person in people)
        {
            linkedPeopleList.AddLast(person);
        }

        return linkedPeopleList;
    }

    public static string PrintPeople(LinkedList<Person> people){
        string output = "";
        foreach (Person person in people)
        {
            output += $"| {person.FirstName}, {person.LastName}, {person.Age} ";
        }
        return output;
    }

    public static LinkedList<Person> SortPeople(LinkedList<Person> people)
    {
        LinkedList<Person> AgeSorted = new LinkedList<Person>();
        foreach (Person person in people)
        {
            if (AgeSorted.Count == 0)
            {
                AgeSorted.AddFirst(person);
            }
            else
            {
                LinkedListNode<Person> current = AgeSorted.First;

                while (current != null && current.Value.Age < person.Age)
                {
                    current = current.Next;
                }
                if (current == null)
                {
                    AgeSorted.AddLast(person);
                }
                else
                {
                    AgeSorted.AddBefore(current, person);
                }
            }
        }
        return AgeSorted;
    }

    static void PrintList(LinkedList<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }

}