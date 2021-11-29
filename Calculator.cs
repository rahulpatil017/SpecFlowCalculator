// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, SpecFlow!");
/// <summary>
/// Add two numbers
/// </summary>
public class Calculator
{
    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }

    public int Add()
    {
        return FirstNumber + SecondNumber;
    }
}