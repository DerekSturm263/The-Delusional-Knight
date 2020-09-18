using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public static class CutsceneManager
{
    public static List<GameObject> unloadedObjects = new List<GameObject>();
    public static List<GameObject> newObjects = new List<GameObject>();

    public static GameObject fade;

    public static void Initialize()
    {
        unloadedObjects = GameObject.FindGameObjectsWithTag("UnloadOnCutscene").ToList();
        fade = GameObject.FindGameObjectWithTag("Fade");
        fade.SetActive(false);
    }

    public static void BeginCutscene(List<GameObject> cutsceneObjects, List<Action> commands)
    {
        fade.SetActive(true);

        Debug.Log("Cutscene began.");

        // Unloads the current GameObjects.
        // Loads in new GameObjects.
        // Starts the list of Actions.

        unloadedObjects.ForEach(x => x.SetActive(false));
        newObjects = cutsceneObjects;
        newObjects.ForEach(x => x.SetActive(true));

        foreach (Action action in commands)
        {
            action.Invoke();
        }
    }

    public static void EndCutscene()
    {
        fade.SetActive(true);

        Debug.Log("Cutscene ended.");

        // Unloads the current GameObjects.
        // Loads the unloaded GameObjects.

        unloadedObjects.ForEach(x => x.SetActive(true));
        newObjects.ForEach(x => x.SetActive(false));
    }
}
