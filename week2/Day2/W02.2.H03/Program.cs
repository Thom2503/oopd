using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		List<DNA> DNAObjs = new List<DNA>()
		{
			new DNA("ACGT"), new DNA("GCTTAC"), new DNA("CGTTAGCTT"), new DNA("TACA")
		};

		Console.WriteLine("What is the minimum sequence length?");
		int iSeqLength = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("The filtered list:");
		foreach (DNA dna in DNAObjs)
		{
			if (dna.Seq.Length >= iSeqLength)
				Console.WriteLine(dna.Seq);
		}
	}
}