// See https://aka.ms/new-console-template for more information
using System.Text;

public class CodeBuilder
{
    private string nameClass;
    public CodeBuilder(string nameClass)
    {
        nameClass = nameClass;
    }
    
    private Dictionary<string, string> fields = new();

    public CodeBuilder AddField(string name, string type)
    {
        fields.Add(name, type);
        return this;
    }

    public override string ToString()
    {
        var str = new StringBuilder();
        str.AppendLine($"public class {nameClass}");
        str.AppendLine("{");
        foreach (var field in fields)
        {
            str.AppendLine($"  public {field.Value} {field.Key};");
        }
        str.AppendLine("}");
        return str.ToString();
    }
}