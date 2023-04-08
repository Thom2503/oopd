using System;

namespace Program;

public class Program
{
	public static void Main(string[] args)
	{
		Song bliss = new Song("Bliss", "Muse", 4);
		bliss.SetSongText("Everything about you is how I'd wanna be. Your freedom comes naturally. Everything about you resonates happiness .Now I won't settle for less...");

		Song sure = new Song("Sure", "Hatchie", 4);
		sure.SetSongText("Why did you do it? You couldn't just laugh and walk away? Yeah, how could you do it? Is there any power in what I say?...");

		Song sterrenstof = new Song("Sterrenstof", "De Jeugd Van Tegenwoordig", 3);
		sterrenstof.SetSongText("Nou kijk je gappie leeft zoet als een sappie. Bawlin' ookal was mama altijd wappie. Een goed begin is het halve werk. Maar een goed begin is maar de helft...");

		Song kangaroo = new Song("Kangaroo", "This Mortal Coil", 3);
		kangaroo.SetSongText("I first saw you. You had on blue jeans. Your eyes couldn't hide anything. I saw you breathing...");

		List<Song> songs = new List<Song>()
		{
			bliss, sure, sterrenstof, kangaroo
		};

		Jukebox jukebox = new Jukebox(songs);
		foreach (Song _song in songs)
		{
			Console.WriteLine(jukebox.NowPlaying());
			jukebox.Play();
			jukebox.Next();
			Console.WriteLine();
		}

		foreach (Song _song in songs)
		{
			Console.WriteLine(jukebox.NowPlaying());
			jukebox.Play();
			jukebox.Previous();
			Console.WriteLine();
		}
	}
}