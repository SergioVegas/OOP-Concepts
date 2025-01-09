using System;

public class Plant : LivingBeing
{
    public string? colour;
    public string? surface;
    public double height;

	//Setters
	public  virtual void SetColour(string colour) {  this.colour = colour; }
	public virtual void SetSurface(string surface) { this.surface = surface; }
	public virtual void SetHeight(double height) { this.height = height; }

	//Getters
	public virtual string GetColour() { return this.colour; }
	public virtual string GetSurface() { return this.surface; }
	public virtual double GetHeight() { return this.height; }

	//Constructor
	public Plant( string colour, string surface, double height)
	{
		this.SetColour(colour);
		this.SetSurface(surface);
		this.SetHeight(height);
	}
    //Others Methods
    public virtual bool MakeChlorophyll (string surface)
	{

		return surface == "Wet" ? true : false ;
    }
    //Abstract Class
    public override void InteractWith()
    {
        Console.WriteLine("The environment");
    }
    public override void Nudrish()
    {
        Console.WriteLine("Feeding from the sun and soil");
    }
    public override void Reproduction()
    {
        Console.WriteLine("Yes");
    }

}
