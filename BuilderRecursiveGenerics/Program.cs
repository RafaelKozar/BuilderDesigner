var builder = Person.New
 .Called("Natasha")
 .WorksAsA("Doctor")
 .Born(DateTime.Now);

 var person = builder.Build();
Console.WriteLine(person.DateOfBirth);
 //.Build();


public class Person
{
    public string Name;
    public string Position;
    public DateTime DateOfBirth;

    public class Builder : PersonBirthDateBuilder<Builder>
    {
        //internal Builder() { }
    }
    public static Builder New => new Builder();
}

public abstract class PersonBuilder
{
    protected Person person = new Person();
    public Person Build()
    {
        return person;
    }
}

public class PersonInfoBuilder<S> : PersonBuilder
    where S : PersonInfoBuilder<S>
{
    public S Called(string name)
    {
        person.Name = name;
        return (S) this;
    }
}

public class PersonJobBuilder<S> : PersonInfoBuilder<PersonJobBuilder<S>>
    where S : PersonJobBuilder<S>
{
    public S WorksAsA(string position)
    {
        person.Position = position;
        return (S)this;
    }
}


public class  PersonBirthDateBuilder<S> : PersonJobBuilder<PersonBirthDateBuilder<S>> 
    where S : PersonBirthDateBuilder<S>
{
    public S Born(DateTime dateOfBirth)
    {
        person.DateOfBirth = dateOfBirth;
        return (S)this;
    }
}


