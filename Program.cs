using System.Text;

const string FilePath = "..\\..\\..\\data\\titanic.txt";

#nullable disable

List<Category> categories = [];

using StreamReader sr = new(FilePath, Encoding.UTF8);
while (!sr.EndOfStream) categories.Add(new(sr.ReadLine()));

Console.WriteLine($"2f.: utaskategoriak szama: {categories.Count} db");

var f3 = categories.Sum(c => c.Passangers);
Console.WriteLine($"3f.: utasok szama osszesen: {f3} fo");

