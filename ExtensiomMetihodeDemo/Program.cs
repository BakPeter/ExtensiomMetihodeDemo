// See https://aka.ms/new-console-template for more information
using ExtensiomMetihodeDemo;

Console.WriteLine("Hello, World!");

int n1 = 2;
Console.WriteLine(n1.Pow(3));
Console.WriteLine(n1.ConcatTwoNumsToToStr(4, "peter"));

string text = "some text";
Console.WriteLine(text.AddNameToStart("Peter"));

var mapEntity = new MapEntity
{
    Name = "Israel",
    X = 20,
    Y = 30
};
Console.WriteLine(mapEntity);
mapEntity.MoveDeg(2);
Console.WriteLine(mapEntity);
