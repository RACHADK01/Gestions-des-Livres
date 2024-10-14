using TPCsharp_Roman;

internal class Program
{
    private static void Main(string[] args)
    {
        Revue revue1 = new Revue("Le Monde", "Equipe continentale", 54, 143, 2022);
        Revue revue2 = new Revue("Science et Vie", "National géography", 127, 65, 2013);
        Revue revue3 = new Revue("Terre Africaine", "Berceau humanitaire", 173, 56, 2005);

        Roman roman1 = new Roman("Plus Malin que le Diable", "Napoleon Hill", 256, "Croissance personnelle");
        Roman roman2 = new Roman("Chants d'ombres", "Léopold Sédar Senghor", 160, "Récueil de poèmes");
        Roman roman3 = new Roman("Les Misérables", "Victor Hugo", 1462, "Historique");

        List<Livre> livres = new List<Livre>();
        livres.Add(revue1);
        livres.Add(revue2);
        livres.Add(revue3);
        livres.Add(roman1);
        livres.Add(roman2);
        livres.Add(roman3);

        Console.WriteLine("Voici les détails des différents livres de la liste :");
        foreach (Livre livre in livres)
        {
            livre.AfficherDetails();
        }
            
    }
}