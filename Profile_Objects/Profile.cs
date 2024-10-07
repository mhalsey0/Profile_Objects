using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    //constructor

    public Profile(string name, int age, string city, string country, string pronouns = "they/them", string[] hobbies = null)
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = hobbies ?? new string[] {"none provided"};
    }

    public Profile(string name, int age) : this(name, age, "no city provided", "no country provided")
    {
      this.name = name;
      this.age = age;
    }

    //methods

    public string ViewProfile()
    {
      string profile = $"name: {name}; \nage: {age}; \ncity and country: {city}, {country}; \npronouns: {pronouns};\nhobbies:";

      foreach (string hobby in hobbies)
      {
        hobby.ToString();
        profile += $"\n{hobby}";
      }

      return profile;
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }

  }
}
