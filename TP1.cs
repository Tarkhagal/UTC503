using System;
using System.Linq;



/*          TP 1 Manipulation de nombres

public class Program
{
    // I.1.1 Fonction qui calcule la somme de deux entiers
    public static int Somme(int a, int b)
    {
        return a + b;
    }

    public static void Main()
    {
        // I.1.3 Saisie de l'utilisateur pour la taille et le type de tri du tableau
        Console.Write("Entrez la taille du tableau : ");
        int taille;
        while (!int.TryParse(Console.ReadLine(), out taille) || taille <= 0)
        {
            Console.WriteLine("Veuillez entrer un entier positif.");
        }

        Console.Write("Tri croissant ou décroissant ? (c/d) : ");
        char choixTri;
        while (!char.TryParse(Console.ReadLine(), out choixTri) || (choixTri != 'c' && choixTri != 'd'))
        {
            Console.WriteLine("Veuillez entrer 'c' pour croissant ou 'd' pour décroissant.");
        }

        // Génération du tableau avec des entiers aléatoires positifs
        int[] tableau = new int[taille];
        Random random = new Random();
        for (int i = 0; i < tableau.Length; i++)
        {
            tableau[i] = random.Next(1, 100); // Génère un entier entre 1 et 99
        }

        Console.WriteLine("Tableau original :");
        AfficherTableau(tableau);

        // Tri du tableau en fonction de l'entrée utilisateur
        if (choixTri == 'c')
        {
            Array.Sort(tableau); // Tri croissant
        }
        else if (choixTri == 'd')
        {
            Array.Sort(tableau);
            Array.Reverse(tableau); // Tri décroissant
        }

        Console.WriteLine("Tableau trié :");
        AfficherTableau(tableau);

        // I.1.4 Inversion du tri
        Console.WriteLine("Tableau trié dans le sens inverse :");
        Array.Reverse(tableau);
        AfficherTableau(tableau);
    }

    // Méthode pour afficher le tableau
    public static void AfficherTableau(int[] tableau)
    {
        foreach (int valeur in tableau)
        {
            Console.Write(valeur + " ");
        }
        Console.WriteLine();
    }
}
*/




/*                  TP2 Jeu de Tennis 

public class Program
{
    public static void Main()
    {
        // Points de chaque joueur
        int pointsJoueur1 = 0;
        int pointsJoueur2 = 0;

        // Simulation d'échanges (on peut changer ces valeurs pour tester)
        pointsJoueur1 = 4; // Exemple : Joueur 1 a gagné 4 échanges
        pointsJoueur2 = 5; // Exemple : Joueur 2 a gagné 3 échanges

        // Affichage du score
        string score = ObtenirScore(pointsJoueur1, pointsJoueur2);
        Console.WriteLine(score);
    }

    // Fonction pour obtenir le score
    public static string ObtenirScore(int pointsJoueur1, int pointsJoueur2)
    {
        // Vérifie si un joueur a gagné
        if (pointsJoueur1 >= 4 && pointsJoueur1 >= pointsJoueur2 + 2)
        {
            return "Joueur 1 gagne le jeu";
        }
        else if (pointsJoueur2 >= 4 && pointsJoueur2 >= pointsJoueur1 + 2)
        {
            return "Joueur 2 gagne le jeu";
        }

        // Si les deux joueurs sont à 40
        if (pointsJoueur1 >= 3 && pointsJoueur2 >= 3)
        {
            if (pointsJoueur1 == pointsJoueur2)
            {
                return "Égalité";
            }
            else if (pointsJoueur1 == pointsJoueur2 + 1)
            {
                return "Avantage Joueur 1";
            }
            else if (pointsJoueur2 == pointsJoueur1 + 1)
            {
                return "Avantage Joueur 2";
            }
        }

        // Si les joueurs ont moins de 40
        return pointsJoueur1 + " - " + pointsJoueur2;
    }
}
*/


/*

public class Program
{
    public static void Main()
    {
        // III.1.1 : Demande du prénom et salutation
        DemanderPrenom();

        // III.1.2 : Demande du nom et prénom
        DemanderNomEtPrenom();

        // III.2.1 : Affichage d'un texte et génération d'un nombre aléatoire
        GenererNombreAleatoire();

        // III.2.2 : Deviner le nombre aléatoire
        DevinerNombreAleatoire();

        // III.2.3 : L'ordinateur devine le nombre
        OrdinateurDevineNombre();
    }

    // III.1.1 : Fonction pour demander le prénom
    private static void DemanderPrenom()
    {
        Console.Write("Veuillez entrer votre prénom : ");
        string prenom = Console.ReadLine();
        Console.WriteLine($"Bonjour, {prenom} !");
    }

    // III.1.2 : Fonction pour demander le nom et prénom
    private static void DemanderNomEtPrenom()
    {
        Console.Write("Veuillez entrer votre nom et prénom (ex: Dupont Jean) : ");
        string saisie = Console.ReadLine();

        string[] parties = saisie.Split(' ');
        if (parties.Length >= 2)
        {
            string nom = parties[0].ToUpper(); // Mettre le nom en majuscules
            string prenom = char.ToUpper(parties[1][0]) + parties[1].Substring(1).ToLower(); // Mettre la première lettre du prénom en majuscule

            Console.WriteLine($"Bonjour, {prenom} {nom} !");
        }
        else
        {
            Console.WriteLine("Veuillez entrer à la fois votre nom et votre prénom.");
        }
    }

    // III.2.1 : Fonction pour générer un nombre aléatoire et comparer avec la saisie de l'utilisateur
    private static void GenererNombreAleatoire()
    {
        Random random = new Random();
        int nombreAleatoire = random.Next(0, 1001); // Nombre aléatoire entre 0 et 1000

        Console.WriteLine("Un nombre aléatoire entre 0 et 1000 a été généré.");
        Console.Write("Veuillez saisir un nombre : ");
        int saisie = int.Parse(Console.ReadLine());

        if (saisie > nombreAleatoire)
        {
            Console.WriteLine("Votre nombre est plus grand que le nombre généré.");
        }
        else if (saisie < nombreAleatoire)
        {
            Console.WriteLine("Votre nombre est plus petit que le nombre généré.");
        }
        else
        {
            Console.WriteLine("Bravo ! Vous avez deviné le nombre !");
        }
    }

    // III.2.2 : Fonction pour permettre à l'utilisateur de deviner le nombre
    private static void DevinerNombreAleatoire()
    {
        Random random = new Random();
        int nombreAleatoire = random.Next(0, 1001); // Nombre aléatoire entre 0 et 1000
        int essais = 0;
        int saisie = -1;

        Console.WriteLine("Devinez le nombre entre 0 et 1000.");

        while (saisie != nombreAleatoire)
        {
            Console.Write("Veuillez saisir un nombre : ");
            saisie = int.Parse(Console.ReadLine());
            essais++;

            if (saisie > nombreAleatoire)
            {
                Console.WriteLine("Votre nombre est plus grand.");
            }
            else if (saisie < nombreAleatoire)
            {
                Console.WriteLine("Votre nombre est plus petit.");
            }
        }

        Console.WriteLine($"Bravo ! Vous avez deviné le nombre en {essais} essais.");
    }

    // III.2.3 : Fonction pour que l'ordinateur devine le nombre choisi par l'utilisateur
    private static void OrdinateurDevineNombre()
    {
        Console.Write("Choisissez un nombre entre 0 et 1000 (n'oubliez pas de ne pas le dire à l'ordinateur) : ");
        int nombreChoisi = int.Parse(Console.ReadLine());

        int bas = 0;
        int haut = 1000;
        int essais = 0;
        int guess;

        Console.WriteLine("L'ordinateur va essayer de deviner votre nombre.");

        while (true)
        {
            essais++;
            guess = (bas + haut) / 2; // Deviner le nombre au milieu

            Console.WriteLine($"L'ordinateur devine : {guess}");
            if (guess < nombreChoisi)
            {
                Console.WriteLine("C'est plus.");
                bas = guess + 1; // Ajuster les limites
            }
            else if (guess > nombreChoisi)
            {
                Console.WriteLine("C'est moins.");
                haut = guess - 1; // Ajuster les limites
            }
            else
            {
                Console.WriteLine($"L'ordinateur a deviné votre nombre {guess} en {essais} essais !");
                break;
            }
        }
    }
}
*/



