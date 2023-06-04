using System;

public class Profile
{
    //fields
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    //constructor
    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
	{
        this.name = name;
        this.age = age;
        this.city = city;
        this.country = country;
        this.pronouns = pronouns;
        this.hobbies = new string[] { };
	}

    //methods
    public string ViewProfile() 
    {
        return $"Name: {this.name}\nAge: {this.age}\nCity: {this.city}\nCountry: {this.country}\nPronouns: {this.pronouns}\nHobbies: \n - {String.Join("\n - ", this.hobbies)}";   
    }

    public void SetHobbies(string[] hobbies)
    { 
        this.hobbies = hobbies;
    }
}
