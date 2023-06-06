using KeepCorrect.StrategyPicker;

namespace Strategies;

public class FormatterPicker : IStrategyPicker<IStringFormatter>
{
    public FormatterPicker(FormatterTypeEnum formatterType)
    {
        FormatterType = formatterType;
    }

    private FormatterTypeEnum? FormatterType { get; }
    
    public Func<IStringFormatter, bool> GetConditionsPredicate()
    {
        return f => f.StrategyType == FormatterType;
    }
}

public enum FormatterTypeEnum
{
    ToUpperCase,
    ToLowerCase
}