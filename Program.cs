using TPCsharp_Roman;

internal class Program
{
    private static void Main(string[] args)
    {
        Revue revue1 = new Revue("Le Monde", "Equipe continentale", 54, 143, 2022);
        Revue revue2 = new Revue("Science et Vie", "National géography", 127, 65, 2013);
        Revue revue3 = new Revue("Terre Africaine", "Berceau humanitaire", 173, 56, 2005);

        List<Livre> livres = new List<Livre>();
        livres.Add(revue1);
        livres.Add(revue2);
        livres.Add(revue3);

        Console.WriteLine("Détails des livres dans la liste :");
        foreach (Livre livre in livres)
        {
            livre.AfficherDetails();
        }
            
    }
}