// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
Console.WriteLine(cb);



