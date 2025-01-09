using System;
using System.Drawing;

public class Cactus : Plant, Spiky
{
	private int spikes { get; set; }
    private int petals { get; set; }


	public  Cactus( int spikes, int petals) : base (colour, surface, height)
	{
		this.spikes = spikes;
		this.petals = petals;
		
	}
    public override bool MakeChlorophyll( string surface )
	{
        return surface == "Half Wet" ? true : false;
    }
    //Interface
    public void DammageSurface()
    {
        Console.WriteLine("The surface was dammaged");
    }
}
