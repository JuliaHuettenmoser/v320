using System;

public class Banker : Person
{
	public int Steuer()
	{
		steuer = BerechneSteuer(einkommen);

        return steuer + 1000;

	}
}
