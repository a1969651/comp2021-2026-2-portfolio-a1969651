class Person
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Age {get; set;}

    public Person (string Firstname, string Lastname, int age)
    {
        if (string.IsNullOrWhiteSpace(Firstname))
        {
            throw new ArgumentException("First Name cannot be empty.");
        }

        if (string.IsNullOrWhiteSpace(Lastname))
        {
            throw new ArgumentException("Last Name cannot be empty.");
        }

        if (age < 0 || age > 100)
        {
            throw new ArgumentException("Age must be between 0 and 100.");
        }

        FirstName = Firstname;
        LastName = Lastname;
        Age = age; 
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }
}