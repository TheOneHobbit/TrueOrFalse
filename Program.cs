using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      string[] questions = {"1. Bumblebees are inherently violent.", "2. Bumblebees will live for around 4 weeks.", "3. Old bumblebees have ragged wings showing their age.", "4. Hive queens will outlive the colony and recolonize after."};
      bool[] answers = {false, true, true, true};
      bool[] responses = new bool[questions.Length];

      if (questions.Length != answers.Length) 
      {
        Console.WriteLine("The number of questions is not equal to the number of answers.");
      }

      int askingIndex = 0;

      foreach (string question in questions) {
        bool isBool;
        bool inputBool;

        Console.WriteLine(question);
        Console.Write("True or False?: ");
        string input = Console.ReadLine().ToLower();

        isBool = Boolean.TryParse(input, out inputBool);

         while (!isBool) 
         {
          Console.WriteLine("Make sure to respond with 'true' or 'false'.");
          input = Console.ReadLine().ToLower();
          isBool = Boolean.TryParse(input, out inputBool);
      }
         responses[askingIndex] = inputBool;
          askingIndex++;
    }

      int scoringIndex = 0;
      int score = 0;
      foreach (bool answer in answers) {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex + 1 + ".");
         Console.WriteLine($"Input: {response} | Answer: {answer} ");
        if (response == answer) {
          score++;
        }
        scoringIndex++;
      }
      Console.WriteLine($"You got {score} out of {questions.Length} correct!");
      if (score == questions.Length) {
        Console.WriteLine("Congrats!");
      }
    }
  }
}
