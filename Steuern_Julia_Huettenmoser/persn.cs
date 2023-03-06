using System;

public class Person  : ISteuerzahler
{
	protected int einkommen;
	protected int steuer; 
	public int ErmittleZuVersteurendesEinkommen(int einkommen)
	{
		steuer = einkommen / 4;
		if(steuer > einkommen || steuer < 0)
		{
			Console.WriteLine("ungueltige Steuerbetrag");
		}
		return steuer;
	}

	public int BerechneSteuer()
	{
		return 1;
	}
}
