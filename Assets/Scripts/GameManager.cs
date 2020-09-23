using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Sprite playerHead;
    public Sprite witchHead;
    public Sprite guardHead;
    public Sprite princessHead;
    public Sprite kingHead;

    private void Start()
    {
        Characters.player.SetIcon(playerHead);
        Characters.witch.SetIcon(witchHead);
        Characters.guard.SetIcon(guardHead);
        Characters.princess.SetIcon(princessHead);
        Characters.king.SetIcon(kingHead);
    }
}
