using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Characters
{
    public static Character player = new Character("Dagon", Resources.Load("Dagon") as Image);
    public static Character witch = new Character("Witch", Resources.Load("Witch") as Image);
}
