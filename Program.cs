using System.Text;

const string FilePath = "..\\..\\..\\data\\titanic.txt";

#nullable disable

List<Category> categories = [];

using StreamReader sr = new(FilePath, Encoding.UTF8);
while (!sr.EndOfStream) categories.Add(new(sr.ReadLine()));

Console.WriteLine($"2f.: utaskategoriak szama: {categories.Count} db");

int f3 = categories.Sum(c => c.Passangers);
Console.WriteLine($"3f.: utasok szama osszesen: {f3} fo");

Console.Write("4f.: irja be a kereseshez a kulcsszot: ");
string f4str = Console.ReadLine();

bool f4 = categories.Any(c => c.Name.Contains(f4str));
Console.WriteLine(f4 ? "\tVAN találat" : "\tNINCS találat");

if (f4)
{
    var f5 = categories.Where(c => c.Name.Contains(f4str));
    Console.WriteLine("a kovetkezo kategoriak neveiben talalhato meg a kulcsszo:");
    foreach (var c in f5) Console.WriteLine($"\t{c}");
}

var f6 = categories.Where(c => c.Missing > c.Passangers * .6);
Console.WriteLine("6f.: azon kategoriak, ahol az eltuntek szama meghaladja a 60%-ot:");
foreach (var c in f6) Console.WriteLine($"\t{c.Name}");

var f7 = categories.MaxBy(c => c.Survivals);
Console.WriteLine($"7f.: a legtobb tulelo ebben a kategoriaban volt: " +
    $"\n\t{f7.Name}");