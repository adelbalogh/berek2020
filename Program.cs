using berek2020;
using System.Text;

List<Berek> berek = [];

using StreamReader sr = new("..\\..\\..\\src\\berek2020.txt", Encoding.UTF8);
while (!sr.EndOfStream) berek.Add(new(sr.ReadLine()));

Console.WriteLine($"3. Feladat: Dolgozók száma: {berek.Count}");

var f4 = berek.Average(e => e.ber/1000);
Console.WriteLine($"4. Feladat: Bérek átlaga: {f4:0.0} eFt");

Console.Write("5. Feladat: Kérem a részleg nevét: ");
string ker=Console.ReadLine();
var f5 = berek.Where(b => b.reszleg==ker);
var f6 = berek.Where(b => b.reszleg==ker).MaxBy(b => b.ber);

Console.WriteLine($"6. Feladat: {f6}");


var f7 = berek.GroupBy(e => e.reszleg).OrderBy(g => g.Key);
Console.WriteLine("7. Feladat: Statisztika");
foreach (var grp in f7)
{
    Console.WriteLine($"\t{grp.Key,8} - {grp.Count(),2} fő");
}