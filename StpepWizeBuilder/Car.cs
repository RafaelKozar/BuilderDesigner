// See https://aka.ms/new-console-template for more information


public class Car
{
    public CarType Type;
    public int WheelSize;

    public override string ToString()
    {
        return $"Car type: {Type}, wheel size: {WheelSize}";
    }
}
