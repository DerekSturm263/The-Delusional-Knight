using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class CutsceneManager
{
    private static DialogueManager dm;
    private static GameObject flash;

    public static List<GameObject> unloadableObjects = new List<GameObject>();
    public static GameObject cutsceneObject;
    
    public static GameObject oldCameraTarget;
    private static Camera camera;

    public static void Initialize()
    {
        dm = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
        flash = GameObject.FindGameObjectWithTag("FlashbackFlash");
        flash.SetActive(false);
    }

    public static void BeginCutscene(GameObject cutscene)
    {
        camera = Camera.main;
        unloadableObjects = GameObject.FindGameObjectsWithTag("Unloadable").ToList();
        cutsceneObject = cutscene;

        flash.GetComponent<Animator>().speed = 1f;
        flash.SetActive(true);
        dm.WriteDialogue(AllDialogue.memory1, Characters.player);
        dm.SetEndOfDialogue(() =>
        {
            flash.GetComponent<Animator>().speed = 0.25f;
            flash.SetActive(true);
            LoadObjects(cutscene);
        });
    }

    public static void LoadObjects(GameObject cutscene)
    {
        camera.GetComponent<CameraFollow2D>().FollowTarget = cutscene;
        camera.transform.position = cutscene.transform.position;
        unloadableObjects.ForEach(x => x.SetActive(false));
        cutsceneObject.SetActive(true);
    }

    public static void EndCutscene()
    {
        cutsceneObject.SetActive(false);
        unloadableObjects.ForEach(x => x.SetActive(true));
        camera.GetComponent<CameraFollow2D>().FollowTarget = oldCameraTarget;
        camera.transform.position = oldCameraTarget.transform.position;
    }
}
