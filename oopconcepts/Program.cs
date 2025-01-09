using oopconcepts;
using System;

public class program
{
    public static void Main()
    {
        Cactus Domestic = new Cactus( 11, 30 );
        int height = int.Parse(Console.ReadLine());

        height = ExampleStaticClass.CentimetersToMeters(height);
        Plant Flower = new Plant("red", "wet", height);
    }
}