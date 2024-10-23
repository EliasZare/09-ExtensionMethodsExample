// See https://aka.ms/new-console-template for more information
using _09_ExtensionMethodsExample;

Console.WriteLine("Hello, World!");
BaseClass baseClass = new BaseClass();
baseClass.GetYear(1110);

baseClass.Nullable = null;
baseClass.Name = "Elias";
Console.WriteLine(baseClass.Name);
baseClass.Name = 110;
Console.WriteLine(baseClass.Name);
if (baseClass.Nullable is null)
{
    Console.WriteLine("is Null");
}
