using KeepCorrect.StrategyPicker;

namespace Strategies;

public interface IStringFormatter : IStrategy
{
    FormatterTypeEnum? StrategyType { get; }
    void WriteToConsole(string @string);
}

public class ToLowerCaseStringFormatter : IStringFormatter
{
    public FormatterTypeEnum? StrategyType => FormatterTypeEnum.ToLowerCase;
    public void WriteToConsole(string @string)
    {
        Console.WriteLine(@string.ToLower());
    }
}

public class ToUpperCaseStringFormatter : IStringFormatter
{
    public FormatterTypeEnum? StrategyType => FormatterTypeEnum.ToUpperCase;
    public void WriteToConsole(string @string)
    {
        Console.WriteLine(@string.ToUpper());
    }
}