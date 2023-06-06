using System.Linq.Expressions;


var result = Test(()=>Console.WriteLine("It is Action"));
Console.WriteLine(result);
Console.ReadLine();

string Test(Action expression)
{
    expression();
    return "Has no name";
}