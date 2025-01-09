using System;

public abstract class LivingBeing
{
	protected string? environment {  get; set; }

	public abstract void InteractWith();

	public abstract void Reproduction();

	public abstract void Nudrish();
}
