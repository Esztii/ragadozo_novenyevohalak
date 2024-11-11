using ragadozo_novenyevohalak;

string[]  fajtak = ["harcsa", "keszeg", "ponty", "Compó", "Kárász", "Sügér", "Csuka", "Amur", "Csüllő", "Csík", "Szürkeharcsa"];
List<Fish> fishLake = new List<Fish>();
Fish fish = new Fish
(
    species: fajtak[Random.Shared.Next(fajtak.Length)],
    predator: Random.Shared.Next(100) < 10,
    top: Random.Shared.Next(0,400),
    depth: Random.Shared.Next(10, 400),
    weight: Random.Shared.Next(1, 80) / 2F
);
 
fish.Weight += 1;

Console.WriteLine($"Fish is {fish.Weight::0.00} kg");
Console.WriteLine($"{(fish.Predator ? "predator" : "vegie")}");

for (int i = 0; i < 100; i++)
{
    fishLake.Add(new(
        species: fajtak[Random.Shared.Next(fajtak.Length)],
        predator: Random.Shared.Next(100) < 10,
        top: Random.Shared.Next(0, 400),
        depth: Random.Shared.Next(10, 400),
        weight: Random.Shared.Next(1, 80) / 2F));
    
}
for (int i = 0;i < 100; i++)
{
    Fish x = fishLake[Random.Shared.Next(fishLake.Count)];
    Fish y = fishLake[Random.Shared.Next(fishLake.Count)];

    if (x.Top > y.Top) (x, y) = (y, x);
    Console.WriteLine("selected fish:");
    Console.WriteLine();


    if (x.Predator != y.Predator)
    {
        if (x.Top + x.Depth >= y.Top)
        {
            fishLake.Remove(y);
            if (x.Weight < 40) x.Weight *= 1.05F;

        }
        else
        {
            fishLake.Remove(x);
            if (y.Weight < 40) x.Weight *= 1.05F;
        }
    }
}
