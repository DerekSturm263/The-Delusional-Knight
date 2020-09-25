using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    public enum Room
    {
        Outside, Outer_Ring, Guards_Room, Kitchen, Throne_Room, Storage_Room, Kings_Room, Princess_Room, Outer_Room_2
    }
    private static Room currentRoom;
    private static Room oldRoom;

    public static Dictionary<Room, Disappear> rooms = new Dictionary<Room, Disappear>();

    private Animator anim;
    public Room thisRoom;
    public string roomName;
    public bool startsVisible;

    public TMPro.TMP_Text roomNameGUI;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        if (!rooms.ContainsKey(thisRoom))
            rooms.Add(thisRoom, this);

        if (!startsVisible)
            FadeOut();
        else
            currentRoom = thisRoom;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
            ChangeRoom();
    }

    private void ChangeRoom()
    {
        oldRoom = currentRoom;
        currentRoom = thisRoom;

        if (oldRoom == currentRoom)
            return;

        Debug.Log("Player went from " + oldRoom + " to " + currentRoom + ".");

        roomNameGUI.gameObject.SetActive(true);
        roomNameGUI.text = rooms[currentRoom].roomName;

        rooms[currentRoom].FadeIn();
        rooms[oldRoom].FadeOut();
    }

    public void FadeOut()
    {
        anim.SetBool("Exit", true);
        anim.SetBool("Enter", false);

        foreach (ParticleSystem ps in GetComponentsInChildren<ParticleSystem>())
        {
            ps.Stop();
        }
    }

    public void FadeIn()
    {
        anim.SetBool("Enter", true);
        anim.SetBool("Exit", false);

        foreach (ParticleSystem ps in GetComponentsInChildren<ParticleSystem>())
        {
            ps.Play();
        }
    }
}
