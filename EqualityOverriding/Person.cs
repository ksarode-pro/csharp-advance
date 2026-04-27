class Person : IEquatable<Person>
{
    public int Age { get; set; }
    public string? Name { get; set; }
    public string? Email {get; set;}

    //Method part of IEquatable<T>
    public bool Equals(Person? other)
    {
        if(other is null)
            return false;

        if(other is Person)
            return this.Email == other.Email;
        
        return false;
    }

    //override ==
    public static bool operator ==(Person p1, Person p2)
    {
        //both object are same
        if (ReferenceEquals(p1, p2))
            return true;

        //null handling- Null reference exceptions prevented
        if (p1 is null || p2 is null)
            return false;

        //biz logic
        return p1.Email == p2.Email;
    }

    //if == is overriden, != must be overriden too. Else compile time error
    public static bool operator !=(Person p1, Person p2)
    {
        return p1.Email == p2.Email;
    }

    //if == is overriden, Equals() must be overriden too. Else warning!
    /*
    Many .NET APIs use Equals()
    Example: collections, LINQ, etc.
    */
    public override bool Equals(object? obj) => Equals(obj as Person);

    //if == is overriden, GetHashCode() must be overriden too. Else warning!
    /*
    Used in:
    Dictionary
    HashSet
    */
    public override int GetHashCode() => Name?.GetHashCode() ?? 0;
}