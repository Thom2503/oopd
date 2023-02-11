using System;

public class Artifact
{
	public double Rarity;
	public double Condition;

	public Artifact(double dbRarity, double dbCondition)
	{
		Rarity = dbRarity;
		Condition = dbCondition;
	}

	public double GetValue()
	{
		return this.Rarity * this.Condition;
	}

	public string Appraise()
	{
		return $"Value: {GetValue()}";
	}

	public bool isEqualTo(Artifact artifact)
	{
		if (artifact == null)
			return false;
		
		if ((this.Condition != artifact.Condition) || (this.Rarity != artifact.Rarity))
			return false;

		return true;
	}
}