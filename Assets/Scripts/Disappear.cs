using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using System.Linq;

public class Disappear : MonoBehaviour
{
    public enum Floor
    {
        Outside, One, Two
    }
    public Floor thisFloor;

    public enum Room
    {
        Outside, Outer_Ring, Guards_Room, Kitchen, Throne_Room, Storage_Room, Kings_Room, Princess_Room, Outer_Room_2, Break_Room
    }
    public Room thisRoom;

    private static Floor currentFloor = Floor.One;

    private static Room currentRoom;
    private static Room oldRoom;

    public static Dictionary<Room, Disappear> rooms = new Dictionary<Room, Disappear>();

    private Animator anim;
    public string roomName;
    public bool startsVisible;

    public TMPro.TMP_Text roomNameGUI;

    public List<GameObject> torches;

    public List<TilemapCollider2D> colliders;
    public List<SpriteRenderer> spriteRenders;
    public List<BoxCollider2D> boxColliders;

    public GameObject floorCollider;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        ParticleSystem[] torchesPS = GetComponentsInChildren<ParticleSystem>();
        foreach (ParticleSystem ps in torchesPS)
        {
            torches.Add(ps.gameObject);
        }
        colliders = GetComponentsInChildren<TilemapCollider2D>().ToList();
        spriteRenders = GetComponentsInChildren<SpriteRenderer>().ToList();
        boxColliders = GetComponentsInChildren<BoxCollider2D>().ToList();
        boxColliders.RemoveAll(x => x.gameObject.GetComponent<ItemInteractable>());

        if (!rooms.ContainsKey(thisRoom))
            rooms.Add(thisRoom, this);
        else
            rooms[thisRoom] = this;

        if (!startsVisible)
            FadeOut();
        else
            currentRoom = thisRoom;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
            ChangeRoom(col);
    }

    private void ChangeRoom(Collider2D col)
    {
        if (thisFloor != currentFloor && col.gameObject.transform.position.y < 38f)
            return;

        currentFloor = thisFloor;

        oldRoom = currentRoom;
        currentRoom = thisRoom;

        if (oldRoom == currentRoom)
            return;

        Debug.Log("Player went from " + oldRoom + " to " + currentRoom + ".");

        roomNameGUI.gameObject.SetActive(true);
        roomNameGUI.text = rooms[currentRoom].roomName;

        if (floorCollider != null && rooms[oldRoom].floorCollider != null)
        {
            floorCollider.SetActive(true);
            rooms[oldRoom].floorCollider.SetActive(false);
        }

        rooms[currentRoom].FadeIn();
        rooms[oldRoom].FadeOut();
    }

    public void FadeOut()
    {
        anim.SetBool("Exit", true);
        anim.SetBool("Enter", false);

        torches.ForEach(x => x.SetActive(false));
        torches.ForEach(x => x.GetComponent<ParticleSystem>().Play());
        spriteRenders.ForEach(x => { try { x.enabled = false;  } catch { } });
        boxColliders.ForEach(x => { try { x.enabled = false; } catch { } });
    }

    public void FadeIn()
    {
        anim.SetBool("Enter", true);
        anim.SetBool("Exit", false);

        torches.ForEach(x => x.SetActive(true));
        torches.ForEach(x => x.GetComponent<ParticleSystem>().Stop());
        spriteRenders.ForEach(x => { try { x.enabled = true; } catch { } });
        boxColliders.ForEach(x => { try { x.enabled = true; } catch { } });
    }
}
