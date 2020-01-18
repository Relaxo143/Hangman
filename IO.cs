using Hangman;
using System.IO;
public class Disk
{
	public static string dirPath = "C:/Users/" + Program.userName + "/AppData/Local/Hangman/";
	public static string filePath = "C:/Users/" + Program.userName + "/AppData/Local/Hangman/Streak.hmn";

	public static void SetupDataDir()
	{
		if (!Directory.Exists(dirPath))
		{
			Directory.CreateDirectory(dirPath);
			
		}
	}

	public static void WriteStreak(int streak)
	{ 

		StreamWriter kaku = new StreamWriter(filePath);
		if (kaku != null)
		{
			kaku.BaseStream.Seek(0, 0);
			kaku.WriteLine(streak);
			kaku.Flush();
			kaku.Close();
		}
	}

	public static int LoadStreak()
	{
		if (File.Exists(filePath) == false) return 0;
	    StreamReader yomu = new StreamReader(filePath);
		int streak = 0;
			
		if (yomu != null)
		{
			streak = int.Parse(yomu.ReadLine());
			yomu.Close();
		}

		return streak;
	}
}
