using System; //similar to import in Java 

namespace MarkTime
{
	class testMarkTime
	{
		//declarations
		static double scripts; 
		static double lecturers; 
		static double scriptsPerLecturer; 
		static double questionsPerTest; 
		static double timePerTest; 
		static double totalMarkingTime; 
		static double minutesMarkingTime; 

		static double TIME_PER_QUESTION = 2; //time is measured in seconds

		static string? prompt; 
		static readonly string SEPARATOR = "----------------------------------------------"; 

		static void Main(string[]args)
		{
			Console.WriteLine("do you want to see the total time for marking the scripts?");
			prompt = Console.ReadLine(); 
			while(String.Equals(prompt, "yes"))
			{
				requestInfo(); 
				Console.WriteLine(SEPARATOR); 
				checkScriptNumber(); 

				Console.WriteLine(SEPARATOR); 
				Console.WriteLine(SEPARATOR); 
				Console.WriteLine("do you want to see the total time for marking the scripts?"); 
				prompt = Console.ReadLine(); 
			}
			Console.WriteLine("There are no scripts to mark"); 
		}

		static void requestInfo()
		{
			Console.WriteLine("enter the number of scripts that need to be marked"); 
			scripts = Convert.ToInt32(Console.ReadLine()); 
			Console.WriteLine("enter the number of lecturers available"); 
			lecturers = Convert.ToInt32(Console.ReadLine()); 
			Console.WriteLine("enter the number of questions in the test"); 
			questionsPerTest = Convert.ToInt32(Console.ReadLine()); 
		}

		static void checkScriptNumber()
		{
			if(scripts > 0 && (questionsPerTest >= 1 || questionsPerTest <= 10) && lecturers > 0)
			{
				Console.WriteLine("All the information is valid"); 

				scriptsPerLecturer = scripts / lecturers; 
				timePerTest = TIME_PER_QUESTION * questionsPerTest; 

				totalMarkingTime  =timePerTest * scriptsPerLecturer; 
				minutesMarkingTime = totalMarkingTime / 60; 

				Console.WriteLine("Scripts per lecturer: " + scriptsPerLecturer); 
				Console.WriteLine("Time for marking (in minutes): " + minutesMarkingTime); 
			}
			else 
			{
				if(scripts == 0)
				{
					Console.WriteLine("You must have at least one script to mark"); 
				}
				if(questionsPerTest < 1 || questionsPerTest > 10)
				{
					Console.WriteLine("Minimum of 1 question or maximum of 10 questions");
				}
				if(lecturers == 0)
				{
					Console.WriteLine("You need at least 1 lecturer to mark the scripts"); 
				}
			}
		}
	}
}