// See https://aka.ms/new-console-template for more information

using KeepCorrect.Common.Extensions;

public enum Enum1
{
    Unknown,
    First,
    Second
}

public enum Enum2
{
    Unk,
    Fir,
    Sec
}

internal class Program
{
    public static void Main(string[] args)
    {
        var result = Enum1.First.ToEnumByInt<Enum1, Enum2>();
        Console.WriteLine(result);
    }
}

