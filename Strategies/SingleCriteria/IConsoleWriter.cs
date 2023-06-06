using KeepCorrect.StrategyPicker;

namespace Strategies;

public interface IConsoleWriter : IStrategy<ConsoleWriterTypeEnum>
{
    void WriteToConsole();
}

public class DigitsWriter: IConsoleWriter
{
    public void WriteToConsole()
    {
        Console.WriteLine(12345);
    }

    public ConsoleWriterTypeEnum StrategyType => ConsoleWriterTypeEnum.Digits;
}

public class LettersWriter: IConsoleWriter
{
    public void WriteToConsole()
    {
        Console.WriteLine("abcde");
    }

    public ConsoleWriterTypeEnum StrategyType => ConsoleWriterTypeEnum.Letters;
}

public enum ConsoleWriterTypeEnum
{
    Digits,
    Letters
}