using MuholdApp;

List<Muhold> muholdak = new List<Muhold>();
int hibasSorokSzama = 0;
foreach (var sor in File.ReadLines("muholdak.txt").Skip(1))
{
    var adatok = sor.Split('|');
    if( sor.Count() != 4 )
    {
        hibasSorokSzama++;
        continue;
    }
    if (string.IsNullOrWhiteSpace(adatok[0]) || (adatok[0] != "M") && (adatok[0]) != "K")
    {
        hibasSorokSzama++;
        continue;
    }
    if (!int.TryParse(adatok[2], out int sulykg)|| !int.TryParse(adatok[3], out int muszerekSzama))
    {
        hibasSorokSzama++;
        continue;
    }
    if (adatok[0] == "M") muholdak.Add(new Muhold(adatok[1], sulykg));
    else muholdak.Add(new KutatasiMuhold(adatok[1], sulykg, muszerekSzama));
}
Console.WriteLine($"Sikeresen beolvasott műholdak: {muholdak.Count} db");
Console.WriteLine($"Kiszűrt hibás sorok száma {hibasSorokSzama} db");
Console.WriteLine("\n Beolvasott műholdak listája");
foreach(Muhold m in muholdak)
{
    Console.WriteLine(m);
}
Console.WriteLine("LINQ Statisztikák:");
Console.WriteLine($"Műholdak átlagos tömege: {muholdak.Average(m => m.SulyKg)} kg");
Muhold leg = muholdak.MaxBy(m => m.SulyKg);
Console.WriteLine($"Legnehezebb műjold: EXP - 307(leg.sulykg)");