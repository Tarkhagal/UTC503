using System;

public struct Point
{
    public float X { get; set; }
    public float Y { get; set; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}

public class Rectangle
{
    private float longueur; // Longueur du rectangle
    private float largeur;  // Largeur du rectangle
    private Point origine;  // Coin supérieur gauche du rectangle

    // Constructeur
    public Rectangle(float x, float y, float longueur, float largeur)
    {
        this.origine = new Point(x, y);
        this.longueur = longueur;
        this.largeur = largeur;
    }

    // Getters
    public float Longueur
    {
        get => longueur;
        set => longueur = value;
    }

    public float Largeur
    {
        get => largeur;
        set => largeur = value;
    }

    public Point Origine
    {
        get => origine;
        set => origine = value;
    }

    // Méthode pour calculer le périmètre
    public float Perimetre()
    {
        return 2 * (longueur + largeur);
    }

    // Méthode pour calculer la surface
    public float Surface()
    {
        return longueur * largeur;
    }

    // Méthode pour comparer le périmètre
    public bool APlusGrandPerimetre(Rectangle autre)
    {
        return this.Perimetre() > autre.Perimetre();
    }

    // Méthode pour comparer la surface
    public bool APlusGrandeSurface(Rectangle autre)
    {
        return this.Surface() > autre.Surface();
    }

    // Méthode pour afficher les informations
    public void Afficher()
    {
        Console.WriteLine("Rectangle:");
        Console.WriteLine($"  Origine : ({origine.X}, {origine.Y})");
        Console.WriteLine($"  Surface : {Surface()}");
        Console.WriteLine($"  Périmètre : {Perimetre()}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 5)
        {
            Console.WriteLine("Usage: ./FormBuilder <forme> <x> <y> <dimension1> <dimension2>...");
            return;
        }

        string forme = args[0].ToLower();
        if (forme == "rectangle" && args.Length == 5)
        {
            float x = float.Parse(args[1]);
            float y = float.Parse(args[2]);
            float longueur = float.Parse(args[3]);
            float largeur = float.Parse(args[4]);
            Rectangle rectangle = new Rectangle(x, y, longueur, largeur);
            rectangle.Afficher();
        }
        else
        {
            Console.WriteLine("Forme non supportée ou arguments invalides.");
        }
    }
}
