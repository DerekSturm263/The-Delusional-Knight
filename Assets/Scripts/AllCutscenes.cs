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

        cutscenes.Add("opening", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.openingConvo, Characters.player, Characters.witch);
            dm.SetEndOfDialogue(new Action(() => cm.EndCutscene()));
        }));
        cutscenes.Add("openingEnding", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.openingEnding, Characters.player);
        }));



        cutscenes.Add("memory1", new Action( () =>
        {
            dm.WriteDialogue(AllDialogue.flashback1A, Characters.player, Characters.guard);
            dm.SetEndOfDialogue(new Action( () => cm.EndCutscene()));
        }));
        cutscenes.Add("memory1Ending", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.flashback1Over, Characters.player);
        }));



        cutscenes.Add("memory2", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.flashback2A, Characters.player, Characters.king);
            dm.SetEndOfDialogue(new Action(() => cm.EndCutscene()));
        }));
        cutscenes.Add("memory2Ending", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.flashback2Over, Characters.player);
        }));



        cutscenes.Add("memory3", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.flashback3A, Characters.player, Characters.witch);
            dm.SetEndOfDialogue(new Action(() => cm.EndCutscene()));
        }));
        cutscenes.Add("memory3Ending", new Action(() =>
        {
            dm.WriteDialogue(AllDialogue.flashback3Over, Characters.player);
        }));
    }
}
