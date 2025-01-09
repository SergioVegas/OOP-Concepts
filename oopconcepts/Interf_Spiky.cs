using System;

public interface Spiky
{
	public int DropSpikes()
	{

		return int.Parse(Console.ReadLine());
	}
	public void DammageSurface()
	{
		Console.WriteLine("The surface was dammaged");
	}
}
