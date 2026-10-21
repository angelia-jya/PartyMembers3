string[] party = { "Warrior", "Mage", "Archer", "Healer" };

for (int i = 0; i < party.Length; i++)
{
    Console.WriteLine($"Member {i}: {party[i]}");
}
party[2] = "Rogue";

Console.WriteLine($"\nUpdated Member 2: {party[2]}");