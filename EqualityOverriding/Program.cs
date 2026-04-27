Person kiran = new Person
{
    Age = 36,
    Name = "Kiran Sarode",
    Email = "ksarode@gmail.com"
};

Person pradnya = new Person
{
    Age = 30,
    Name = "Pradnya Sarode",
    Email = "ksarode@gmail.com"
};

if(kiran.Equals(pradnya))
{
    System.Console.WriteLine("Match!");
}


pradnya.Email = "pradnya@gmail.com";

if(kiran.Equals(pradnya))
{
    System.Console.WriteLine("Match!");
}
else
{
    System.Console.WriteLine("No Match!");
}

pradnya.Email = "ksarode@gmail.com";
if(kiran == pradnya)
{
    System.Console.WriteLine("Match!");
}
else
{
    System.Console.WriteLine("No Match!");
}

