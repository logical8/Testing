// See https://aka.ms/new-console-template for more information

using KeepCorrect.StrategyPicker;
using Strategies;
using Microsoft.Extensions.DependencyInjection;

//setup our DI
var serviceProvider = new ServiceCollection()
        .AddTransient(typeof(IFactory<>), typeof(Factory<>))
        .AddTransient(typeof(IFactory<,>), typeof(Factory<,>))
        .AddTransient(typeof(IConsoleWriter), typeof(DigitsWriter))
        .AddTransient(typeof(IConsoleWriter), typeof(LettersWriter))
    .BuildServiceProvider();

var singleCriterionFactory = serviceProvider.GetRequiredService<IFactory<IConsoleWriter, ConsoleWriterTypeEnum>>();
var singleCriterionStrategy = singleCriterionFactory.GetStrategy(ConsoleWriterTypeEnum.Letters);
singleCriterionStrategy.WriteToConsole();

var multipleCriteriaFactory = serviceProvider.GetRequiredService<IFactory<IStringFormatter>>();
var multipleCriteriaStrategy = multipleCriteriaFactory.GetStrategy(new FormatterPicker(ConsoleWriterTypeEnum.Digits));
strategy.WriteToConsole();
Console.ReadLine();