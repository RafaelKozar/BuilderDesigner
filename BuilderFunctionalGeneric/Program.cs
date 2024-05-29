

using System;

var person = new PersonBuilder()
    .Called("Rafa")
    .WorksAs("Programmer")
    .Build();

public class Person
{
    public string Name, Position;

}


public abstract class FunctionalBuilder<TSubject, TSelf>
    where TSelf : FunctionalBuilder<TSubject, TSelf>
    where TSubject : new()
{
    private readonly List<Func<TSubject, TSubject>> actions = new();
    public TSelf Do(Action<TSubject> action) => AddAction(action);
    public TSubject Build() => actions.Aggregate(new TSubject(), (p, f) => f(p));        

    private TSelf AddAction(Action<TSubject> action)
    {
        actions.Add(p => { action(p); return p; });
        return (TSelf)this;
    }
}

public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name)    => Do(p => p.Name = name);
}


public static class PersonBuilderExtensions
{
    public static PersonBuilder WorksAs(this PersonBuilder builder, string position) => builder.Do(p => p.Position = position);
}