using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllDialogue
{
    public static Dictionary<int, SpeechBubble> allDialogue = new Dictionary<int, SpeechBubble>();

    public static SpeechBubble memory = new SpeechBubble(0, Characters.player, "Ah!");
    public static SpeechBubble npc1Dialogue = new SpeechBubble(1, Characters.guard, "What are you doing here? Scram!");
    public static SpeechBubble npc2Dialogue = new SpeechBubble(2, Characters.guard, "I'm not supposed to give you this... But here you go.");
    public static SpeechBubble npc2DialogueReturn = new SpeechBubble(3, Characters.guard, "I already gave ya what ya need, now scram!");
    public static SpeechBubble needKey = new SpeechBubble(4, Characters.player, "It won't open. It looks like I need some sort of key...");
    public static SpeechBubble hasKey = new SpeechBubble(5, Characters.player, "It opened!");

    public static void Initialize()
    {
        memory.SetLines(); // End of conversation.
        npc1Dialogue.SetLines(); // End of conversation.
        npc2Dialogue.SetLines(); // End of conversation.
        npc2DialogueReturn.SetLines(); // End of conversation.
        needKey.SetLines(); // End of conversation.
        hasKey.SetLines(); // End of conversation.
    }

    public static SpeechBubble GetDialogueByID(int num)
    {
        return allDialogue[num];
    }
}
