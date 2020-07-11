using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below

      string[] questions = {"Are you alive?", "Are you above water?", "Are you awake?"};
      bool[] answers = {true, true, false};
      bool[] responses = new bool[questions.Length];
      int askingIndex = 0;
      foreach(string question in questions)
      {
        string input;
        bool isBool;
        bool inputBool;
        Console.WriteLine(question);
        Console.Write("True or False? ");
        input = Console.ReadLine();
        isBool = Boolean.TryParse(input.ToLower(), out inputBool);
        while(!isBool)
        {
          Console.WriteLine("Please respond with True or False!");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);
        }
        responses[askingIndex] = inputBool;
        askingIndex++;
      }

      /*foreach(bool response in responses)
      {
        Console.WriteLine(response);
      }*/
      
      int scoringIndex = 0;
      int score = 0;

      foreach(bool answer in answers)
      {
        bool response = responses[scoringIndex];
        Console.Write(scoringIndex + 1 + ". ");
        Console.WriteLine($"Input: {response} | Answer: {answer}");
        if (response == answer)
        {
          score++;
        }
        scoringIndex++;
      }

      Console.WriteLine($"Your score is {score}!");
      
    }
  }
}
