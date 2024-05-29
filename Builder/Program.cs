// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

///ordinary non-fluent builder
var builder = new HtmlBuilder("ul");
builder.AddChild("li", "hello");
builder.AddChild("li", "world");
Console.WriteLine(builder.ToString());

// fluent builder

builder.Clear(); // disengage builder from the object it's building, then...
builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");

var b = HtmlBuilder.Create("ul").AddChildFluent("li", "hello").AddChildFluent("li", "world");

//Console.WriteLine(b);

var r = HtmlElement.Create("hl").AddChildFluent("li", "hello").AddChildFluent("li", "world");

Console.WriteLine(r);


