// See https://aka.ms/new-console-template for more information


using Submarine;

string commands = File.ReadAllText(@"submarine_kata_input.txt");
var position = SubmarineService.CalculatePosition(commands);
Console.WriteLine($"Horizontal Position = {position.Horizontal}");
Console.WriteLine($"Depth Position = {position.Depth}");
Console.WriteLine($"Product = {position.Product}"); 


