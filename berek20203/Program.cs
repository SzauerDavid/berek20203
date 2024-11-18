using berek20203;
using System.Text;

List<Berek> lista = [];

using StreamReader sr = new("berek2020.txt", Encoding.UTF8);
sr.ReadLine();
while (!sr.EndOfStream)
{
    lista.Add(new(sr.ReadLine()));
}

Console.WriteLine($"3. Feladat: Dolgozók száma: {lista.Count} fő");

int ossz = 0;
for (int i = 0; i < lista.Count; i++)
{
    ossz += lista[i].ber;
}
Console.WriteLine($"4. Feladat: Bérek átlaga: {ossz / lista.Count / 1000:0.0} eFt");

Console.Write($"5. Feladat: Kérem a részleg nevét: ");

string reszleg = Console.ReadLine();
bool sv = false;
int berezes = 0;
string nev = "";
string nem = "";
int belepes = 0;
for (int i = 0; i < lista.Count; i++)
{
    if (lista[i].reszleg == reszleg)
    {
        sv = true;
        if (berezes < lista[i].ber)
        {
            nev = lista[i].nev;
            nem = lista[i].neme;
            berezes = lista[i].ber;
            belepes = lista[i].belepes;
        }
    }
}
if (sv)
{
    Console.WriteLine("6. Feladat: ");
    Console.WriteLine($"\tnev:{nev}");
    Console.WriteLine($"\tNem:{nem}");
    Console.WriteLine($"\tBelepes:{belepes}");
    Console.WriteLine($"\tBer:{berezes}");
}
else Console.WriteLine("6. Feladat: A megadott részleg nem létezik a cégnél!");

var f = lista.GroupBy(darabok => darabok.reszleg);
Console.WriteLine($"7. Feladat: Statisztika");
foreach (var c in f)
{
    Console.WriteLine($"\t{(c.Key)} - {(c.Count())} fő");
}
