// See https://aka.ms/new-console-template for more information
using adventofcode;
using System.Reflection;

Console.WriteLine("https://adventofcode.com/");

var typeToExecute =
    Assembly.GetAssembly(typeof(Program))?
    .GetTypes()
    .Where(s => typeof(IExecute).IsAssignableFrom(s) && s != typeof(IExecute))
    .OrderBy(s => s.Name)
    .FirstOrDefault();

if (typeToExecute == null)
{
    return;
}

var executeType = (IExecute)Activator.CreateInstance(typeToExecute);

Console.WriteLine(typeToExecute.Name);

executeType.Execute();








