using System;

public class Plant
{
	private string colour;
	private string surface;
	private double height;

	//Setters
	public void SetColour(string colour) {  this.colour = colour; }
	public void SetSurface(string surface) { this.surface = surface; }
	public void SetHeight(double height) { this.height = height; }

	//Getters
	public string GetColour() { return this.colour; }
	public string GetSurface() { return this.surface; }
	public double GetHeight() { return this.height; }

	//Constructor
	public Plant( string colour, string surface, double height)
	{
		this.SetColour(colour);
		this.SetSurface(surface);
		this.SetHeight(height);
	}
	//Others Methods
	 public

}
