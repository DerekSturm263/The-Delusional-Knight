using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CutsceneManager : MonoBehaviour
{
    private DialogueManager dm;
    public GameObject flash;

    [HideInInspector] public List<GameObject> unloadableObjects = new List<GameObject>();
    private GameObject cutscene;
    
    private GameObject oldCameraTarget;
    private Camera camera;

    private void Awake()
    {
        dm = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
    }

    public void BeginCutscene(GameObject cutsceneObj)
    {
        camera = Camera.main;
        unloadableObjects = GameObject.FindGameObjectsWithTag("Unloadable").ToList();
        cutscene = cutsceneObj;

        flash.GetComponent<Animator>().speed = 1f;
        flash.SetActive(true);
        dm.WriteDialogue(AllDialogue.memory, Characters.player);

        dm.SetEndOfDialogue(() =>
        {
            flash.GetComponent<Animator>().speed = 0.25f;
            flash.SetActive(true);
            Invoke("LoadObjects", 1f);
        });
    }

    public void LoadObjects()
    {
        cutscene.SetActive(true);
        oldCameraTarget = camera.GetComponent<CameraFollow2D>().FollowTarget;
        camera.GetComponent<CameraFollow2D>().FollowTarget = cutscene;
        camera.transform.position = cutscene.transform.position;
        unloadableObjects.ForEach(x => x.SetActive(false));
    }

    public void EndCutscene()
    {
        unloadableObjects.ForEach(x => x.SetActive(true));
        camera.GetComponent<CameraFollow2D>().FollowTarget = oldCameraTarget;
        camera.transform.position = oldCameraTarget.transform.position;
        cutscene.SetActive(false);
    }
}
