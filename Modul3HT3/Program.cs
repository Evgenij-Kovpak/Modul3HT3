// See https://aka.ms/new-console-template for more information
using Modul3HT3;
public class Program
{
    public static void Main(string[] args)
    {
        var class1 = new Class1();
        var class2 = new Class2();

        class1.ShowDelegateHandler = Show;
        class1.ShowDelegateHandler(class2.Calc(class1.PowDelegateHandler, 4, 4));
    }

    public static void Show(Class2.ResultDelegate resultDelegate)
    {
        Console.WriteLine(resultDelegate(8));
    }
}