using KeepCorrect.StrategyPicker;

namespace Strategies;

public class FormatterPicker : IStrategyPicker<IStringFormatter>
{
    public FormatterPicker(ConsoleWriterTypeEnum consoleWriterType)
    {
        ConsoleWriterType = consoleWriterType;
    }

    private ConsoleWriterTypeEnum? ConsoleWriterType { get; }
    
    public Func<IStringFormatter, bool> GetConditionsPredicate()
    {
        return f => f.StrategyType == ConsoleWriterType;
    }
}