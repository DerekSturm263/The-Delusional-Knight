using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.Rendering;

public class CutsceneManager : MonoBehaviour
{
    private DialogueManager dm;
    public GameObject flash;

    private List<GameObject> unloadableObjects = new List<GameObject>();
    private GameObject cutscene;
    
    private GameObject oldCameraTarget;
    private Camera cam;

    private Action afterTransitionAction;
    private Action afterCutsceneAction;

    public static bool isInCutscene = false;

    private void Awake()
    {
        dm = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
        AllCutscenes.Initialize();
    }

    public bool GetIsInCutscene()
    {
        return isInCutscene;
    }

    public void BeginCutscene(GameObject cutsceneObj, string cutsceneName, string postCutsceneName)
    {
        isInCutscene = true;
        cam = Camera.main;
        unloadableObjects = GameObject.FindGameObjectsWithTag("Unloadable").ToList();
        unloadableObjects.Add(GameObject.FindGameObjectWithTag("Player"));
        cutscene = cutsceneObj;
        afterTransitionAction = AllCutscenes.cutscenes[cutsceneName];
        afterCutsceneAction = AllCutscenes.cutscenes[postCutsceneName];

        flash.GetComponent<Animator>().speed = 1f;
        flash.SetActive(true);
        dm.WriteDialogue(AllDialogue.memory, Characters.player);

        dm.SetEndOfDialogue(() =>
        {
            flash.GetComponent<Animator>().speed = 0.25f;
            flash.SetActive(true);

            Invoke("LoadObjects", 0.66f);
        });
    }

    public void LoadObjects()
    {
        cutscene.SetActive(true);
        oldCameraTarget = cam.GetComponent<CameraFollow2D>().FollowTarget;
        cam.GetComponent<CameraFollow2D>().FollowTarget = cutscene;
        cam.transform.position = new Vector3(cutscene.transform.position.x, cutscene.transform.position.y, -10f);
        unloadableObjects.ForEach(x => x.SetActive(false));

        Invoke("AfterTransition", 0.5f);
    }

    public void AfterTransition()
    {
        afterTransitionAction.Invoke();
    }

    public void EndCutscene()
    {
        flash.GetComponent<Animator>().speed = 0.25f;
        flash.SetActive(true);

        Invoke("LoadOldObjects", 0.66f);
    }

    public void LoadOldObjects()
    {
        unloadableObjects.ForEach(x => x.SetActive(true));
        cam.GetComponent<CameraFollow2D>().FollowTarget = oldCameraTarget;
        cam.transform.position = new Vector3(oldCameraTarget.transform.position.x, oldCameraTarget.transform.position.y, -10f);
        cutscene.SetActive(false);
        isInCutscene = false;

        Invoke("AfterCutscene", 0.5f);
    }

    public void AfterCutscene()
    {
        afterCutsceneAction.Invoke();
    }
}
