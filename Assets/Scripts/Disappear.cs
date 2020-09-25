using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public bool startsVisible;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rooms.Add(thisRoom, this);

        if (!startsVisible)
            FadeOut();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Player entered " + gameObject.name);

        if (col.CompareTag("Player"))
            ChangeRoom();
    }

    private void ChangeRoom()
    {
        oldRoom = currentRoom;
        currentRoom = thisRoom;

        if (oldRoom == currentRoom)
            return;

        Debug.Log(oldRoom);
        Debug.Log(currentRoom);

        rooms[currentRoom].FadeIn();
        rooms[oldRoom].FadeOut();
    }

    public void FadeOut()
    {
        anim.SetBool("Exit", true);
        anim.SetBool("Enter", false);
    }

    public void FadeIn()
    {
        anim.SetBool("Enter", true);
        anim.SetBool("Exit", false);
    }
}
