using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCsharp_Roman
{
    internal class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }

      
        public Revue(string titre, string auteur, int nombrePages, int numero, int annee) : base(titre, auteur, nombrePages)
        {
            Numero = numero;
            Annee = annee;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Nombre de pages: {NombrePages}, Numéro: {Numero}, Année: {Annee}");
        }
    }
}
