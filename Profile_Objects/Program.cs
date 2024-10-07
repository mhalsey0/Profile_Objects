using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

      sam.SetHobbies(new string[] {"listening to audiobooks", "playing rec sports", "writing a spec novle", "reading advice columns"});

      Console.WriteLine(sam.ViewProfile());
      
    }
  }
}
