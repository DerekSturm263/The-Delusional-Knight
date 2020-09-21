using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class AllCutscenes
{
    public static Dictionary<string, Action> cutscenes = new Dictionary<string, Action>();
    public static DialogueManager dm;
    public static CutsceneManager cm;

    public static void Initialize()
    {
        dm = GameObject.FindGameObjectWithTag("DialogueManager").GetComponent<DialogueManager>();
        cm = GameObject.FindGameObjectWithTag("CutsceneManager").GetComponent<CutsceneManager>();

        cutscenes.Add("memory1", new Action( () =>
        {
            dm.WriteDialogue(AllDialogue.flashback1a, Characters.player, Characters.witch);
            dm.SetEndOfDialogue(new Action( () => cm.EndCutscene()));
        }));
        cutscenes.Add("memory1Ending", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.flashback1Ending, Characters.player);
        }));

        cutscenes.Add("memory2", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.flashback2a, Characters.player, Characters.witch);
            dm.SetEndOfDialogue(new Action(() => cm.EndCutscene()));
        }));
        cutscenes.Add("memory2Ending", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.flashback2Ending, Characters.player);
        }));
    }
}
