using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllDialogue
{
    public static Dictionary<int, SpeechBubble> allDialogue = new Dictionary<int, SpeechBubble>();

    public static SpeechBubble memory = new SpeechBubble(0, Characters.player, "Ah!");
    public static SpeechBubble bigDoor = new SpeechBubble(1, Characters.player, "");
    public static SpeechBubble needKey = new SpeechBubble(2, Characters.player, "It won't open. It looks like I need some sort of key...");
    public static SpeechBubble hasKey = new SpeechBubble(3, Characters.player, "It opened!");

    public static void Initialize()
    {
        memory.SetLines(); // End of conversation.
        bigDoor.SetLines(); // End of conversation.
        needKey.SetLines(); // End of conversation.
        hasKey.SetLines(); // End of conversation.
    }

    public static SpeechBubble GetDialogueByID(int num)
    {
        return allDialogue[num];
    }
}
