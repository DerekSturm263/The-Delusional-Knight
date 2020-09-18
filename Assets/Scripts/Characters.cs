using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Characters
{
    public static string path = "Assets/Derek's Stuff/";

    public static Character player = new Character("Dagon", Resources.Load(path + "placeholder_playerIcon") as Image);
    public static Character witch = new Character("Witch", Resources.Load(path + "placeholder_witchIcon") as Image);
}
