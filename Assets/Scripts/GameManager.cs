using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private CutsceneManager cm;

    public Sprite playerHead;
    public Sprite witchHead;
    public Sprite guardHead;
    public Sprite princessHead;
    public Sprite kingHead;

    public GameObject cutsceneLoc;
    public static bool canViewFinalCutscene;

    private void Start()
    {
        Characters.player.SetIcon(playerHead);
        Characters.witch.SetIcon(witchHead);
        Characters.guard.SetIcon(guardHead);
        Characters.princess.SetIcon(princessHead);
        Characters.king.SetIcon(kingHead);

        cm = GameObject.FindGameObjectWithTag("CutsceneManager").GetComponent<CutsceneManager>();
        cm.BeginCutscene(cutsceneLoc, "opening", "openingEnding", true);
    }
}
