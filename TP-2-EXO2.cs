using System;
using System.Collections.Generic;

// Structure for a point
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

// Circle class
public class Cercle
{
    private Point centre; // Center point
    private int diametre; // Diameter

    public Cercle(Point centre, int diametre)
    {
        this.centre = centre;
        this.diametre = diametre;
    }

    public Point Centre
    {
        get => centre;
        set => centre = value;
    }

    public int Diametre
    {
        get => diametre;
        set => diametre = value;
    }

    // Method to calculate the perimeter
    public float Perimetre()
    {
        return (float)(Math.PI * diametre);
    }

    // Method to calculate the area
    public float Surface()
    {
        float rayon = diametre / 2f;
        return (float)(Math.PI * rayon * rayon);
    }

    // Check if a point is on the circle
    public bool EstSurCercle(Point p)
    {
        float rayon = diametre / 2f;
        float distance = (float)Math.Sqrt(Math.Pow(p.X - centre.X, 2) + Math.Pow(p.Y - centre.Y, 2));
        return distance == rayon;
    }

    // Check if a point is inside the circle
    public bool EstDansCercle(Point p)
    {
        float rayon = diametre / 2f;
        float distance = (float)Math.Sqrt(Math.Pow(p.X - centre.X, 2) + Math.Pow(p.Y - centre.Y, 2));
        return distance < rayon;
    }

    // Method to display circle info
    public void Afficher()
    {
        Console.WriteLine($"Cercle:");
        Console.WriteLine($"  Centre: ({centre.X}, {centre.Y})");
        Console.WriteLine($"  Diamètre: {diametre}");
        Console.WriteLine($"  Périmètre: {Perimetre()}");
        Console.WriteLine($"  Surface: {Surface()}");
    }
}

// Drawing class to manage shapes
public class Dessin
{
    private List<object> formes; // List to hold shapes

    public Dessin()
    {
        formes = new List<object>();
    }

    // Add a shape to the drawing
    public void AjouterForme(object forme)
    {
        formes.Add(forme);
    }

    // Remove a shape from the drawing
    public void RetirerForme(object forme)
    {
        formes.Remove(forme);
    }

    // Display all shapes in the drawing
    public void AfficherFormes()
    {
        foreach (var forme in formes)
        {
            if (forme is Cercle cercle)
            {
                cercle.Afficher();
            }
            // Add more shape types (e.g., Rectangle) here as needed
        }
    }
}

// Example usage
public class Program
{
    public static void Main(string[] args)
    {
        // Create a drawing
        Dessin dessin = new Dessin();

        // Create a circle and add it to the drawing
        Cercle cercle = new Cercle(new Point(0, 0), 10);
        dessin.AjouterForme(cercle);

        // Display shapes in the drawing
        dessin.AfficherFormes();

        // Check if a point is on or inside the circle
        Point testPoint = new Point(5, 5);
        Console.WriteLine($"Le point ({testPoint.X}, {testPoint.Y}) est sur le cercle: {cercle.EstSurCercle(testPoint)}");
        Console.WriteLine($"Le point ({testPoint.X}, {testPoint.Y}) est dans le cercle: {cercle.EstDansCercle(testPoint)}");
    }
}
