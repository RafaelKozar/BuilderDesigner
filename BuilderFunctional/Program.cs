

using System;

var person = new PersonBuilder()
    .Called("Rafa")
    .WorksAs("Programmer")
    .Build();

public class Person
{
    public string Name, Position;

}


public sealed class PersonBuilder
{
    private readonly List<Func<Person, Person>> actions = new();

    public PersonBuilder Called(string name) => Do(p => p.Name = name);
    public PersonBuilder Do(Action<Person> action) => AddAction(action);
    public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));
    //public Person Build()
    //{
    //    var p = new Person();
    //    actions.ForEach(a => a(p));
    //    return p;
    //}
    private PersonBuilder AddAction(Action<Person> action)
    {
        
        actions.Add(p =>
        {
            action(p);
            return p;
        });
        return this;
    }
}


public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAs(this PersonBuilder builder, string position) => builder.Do(p => p.Position = position);
}