using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Characters
{
    public static string path = "Assets/Derek's Stuff/";

    public static Dictionary<string, Character> allCharacters = new Dictionary<string, Character>();

    public static Character player = new Character("Dagon", Resources.Load(path + "Main Character Head") as Image);
    public static Character witch = new Character("Witch", Resources.Load(path + "placeholder_witchIcon") as Image);
    public static Character guard = new Character("Guard", Resources.Load(path + "Main Character Head") as Image);
    public static Character king = new Character("King Peter", Resources.Load(path + "Main Character Head") as Image);
    public static Character princess = new Character("Princess Victoria", Resources.Load(path + "Main Character Head") as Image);

    public static Character CharacterByName(string name)
    {
        return allCharacters[name];
    }
}
