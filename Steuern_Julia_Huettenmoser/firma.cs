using System;

public class Firma
{
	double gewinn;
	public double Steuer(double gewinn)
	{
		double steuer = gewinn * 0.07;
		return steuer;
	}
}
