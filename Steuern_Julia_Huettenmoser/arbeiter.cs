using System;

public class Arbeiter : Person
{
	public int Steuer()
	{
		steuer = BerechneSteuer(einkommen);

        return steuer - 2400;

	}
}
