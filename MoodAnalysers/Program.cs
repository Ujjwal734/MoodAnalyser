using MoodAnalysers;

Console.WriteLine("Hello, Welcome to mood Analyser!");
Console.WriteLine("Enter your Mood...");
string moods = Console.ReadLine();
MoodAnalysis mood = new MoodAnalysis(moods);
//MoodAnalysis.AnalyseMood("happy");

