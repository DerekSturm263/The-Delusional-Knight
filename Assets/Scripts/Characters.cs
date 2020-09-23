using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Characters
{
    public static string path = "Assets/Derek's Stuff/";

    public static Dictionary<string, Character> allCharacters = new Dictionary<string, Character>();

    public static Character player = new Character("Dagon");
    public static Character witch = new Character("Witch");
    public static Character guard = new Character("Guard");
    public static Character king = new Character("King Peter");
    public static Character princess = new Character("Princess Victoria");

    public static Character CharacterByName(string name)
    {
        return allCharacters[name];
    }
}
