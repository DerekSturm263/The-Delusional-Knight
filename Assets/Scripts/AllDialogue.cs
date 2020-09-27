using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AllDialogue
{
    public static Dictionary<int, SpeechBubble> allDialogue = new Dictionary<int, SpeechBubble>();

    // Item responses and short lines.
    public static SpeechBubble memory = new SpeechBubble(0, Characters.player, "Ah!");
    public static SpeechBubble bigDoor = new SpeechBubble(1, Characters.player, "");
    public static SpeechBubble needKey = new SpeechBubble(2, Characters.player, "It won't open. It looks like I need some sort of key...");
    public static SpeechBubble hasKey = new SpeechBubble(3, Characters.player, "It opened!");
    public static SpeechBubble sink = new SpeechBubble(4, Characters.player, "It's an empty sink.");
    public static SpeechBubble sink2 = new SpeechBubble(5, Characters.player, "It's a sink.");
    public static SpeechBubble OwO = new SpeechBubble(6, Characters.player, "Wait, what's this? A wet rag?");
    public static SpeechBubble stove = new SpeechBubble(7, Characters.player, "Smells like something's burning.");
    public static SpeechBubble needKey2 = new SpeechBubble(8, Characters.player, "It's locked.");
    public static SpeechBubble hasKey2 = new SpeechBubble(56, Characters.player, "Oh, a key. I can probably use this to get into the princess's room.");
    public static SpeechBubble needKey3 = new SpeechBubble(57, Characters.player, "Huh? I thought that would work. Was there anywhere else in the castle that was locked?");

    // Memory 1.
    public static SpeechBubble flashback1A = new SpeechBubble(9, Characters.guard, "Dagon, did you hear what the townspeople have been saying?");
    public static SpeechBubble flashback1B = new SpeechBubble(10, Characters.player, "No, what about it?");
    public static SpeechBubble flashback1C = new SpeechBubble(11, Characters.guard, "People are reporting seeing that evil witch, Ingrid, in the town, it looks like she's up to no good.");
    public static SpeechBubble flashback1D = new SpeechBubble(12, Characters.player, "What? I can't believe it! This sounds very serious indeed.");
    public static SpeechBubble flashback1E = new SpeechBubble(13, Characters.guard, "You think so? It sounds like superstition if you ask me.");
    public static SpeechBubble flashback1F = new SpeechBubble(14, Characters.player, "I think we should stay on the look out for Ingrid just in case...");
    public static SpeechBubble flashback1Over = new SpeechBubble(15, Characters.player, "Was I a guard at some point? I don't recall...");

    // Memory 2.
    public static SpeechBubble flashback2A = new SpeechBubble(16, Characters.king, "Dagon, I need you to listen to me. That witch is no good.");
    public static SpeechBubble flashback2B = new SpeechBubble(17, Characters.king, "We need to keep a special watch out for her, especially when my daughter is concerned.");
    public static SpeechBubble flashback2C = new SpeechBubble(18, Characters.king, "You're the only one that I can trust to keep my dear Victoria safe.");
    public static SpeechBubble flashback2D = new SpeechBubble(19, Characters.player, "You can count on me, Peter. I will keep Victoria safe at any cost!");
    public static SpeechBubble flashback2E = new SpeechBubble(20, Characters.player, "I swear I will protect her with my life!");
    public static SpeechBubble flashback2Over = new SpeechBubble(21, Characters.player, "Ingrid? I thought I was keeping Victoria safe from the king. What's going on?");

    // Memory 3.
    public static SpeechBubble flashback3A = new SpeechBubble(22, Characters.witch, "You're going to kidnap the princess for me so that I can use her blood for my anti-aging potion.");
    public static SpeechBubble flashback3B = new SpeechBubble(23, Characters.witch, "Hahahahahahahaha!");
    public static SpeechBubble flashback3C = new SpeechBubble(24, Characters.player, "What's so funny? You know there's no way I'd do your bidding.");
    public static SpeechBubble flashback3D = new SpeechBubble(25, Characters.witch, "We'll see about that! Take this!");
    public static SpeechBubble flashback3Over = new SpeechBubble(26, Characters.player, "What did she do to me? I need to see what this is all about!");

    // Witch conversation outside castle.
    public static SpeechBubble convoWithWitch1 = new SpeechBubble(36, Characters.player, "What should I do first?");
    public static SpeechBubble convoWithWitch2 = new SpeechBubble(37, Characters.witch, "You need to get inside the castle dum-dum.");
    public static SpeechBubble convoWithWitch3 = new SpeechBubble(38, Characters.player, "Oh, right.");

    // Guard conversation in Break Room.
    public static SpeechBubble convoInBreakRoom = new SpeechBubble(27, Characters.guard, "I would capture you but I'm on break.");
    public static SpeechBubble convoInBreakRoom2 = new SpeechBubble(28, Characters.player, new List<string> { "What's up with the princess?", "How do I sneak past guards?", "Goodbye." });
    public static SpeechBubble convoInBreakRoom3 = new SpeechBubble(29, Characters.player, "What's up with the princess? I didn't see her.");
    public static SpeechBubble convoInBreakRoom4 = new SpeechBubble(30, Characters.player, "How do I sneak past the guards in the halls?");
    public static SpeechBubble convoInBreakRoom5 = new SpeechBubble(31, Characters.player, "Goodbye.");
    public static SpeechBubble convoInBreakRoom6 = new SpeechBubble(32, Characters.guard, "The princess's room is upstairs on the second floor to the left. Why do you ask?");
    public static SpeechBubble convoInBreakRoom8 = new SpeechBubble(33, Characters.player, "No reason...");
    public static SpeechBubble convoInBreakRoom9 = new SpeechBubble(34, Characters.guard, "I can tell you one thing, it's very hard to see in these helmets. It would be even harder to see if the lights were out.");
    public static SpeechBubble convoInBreakRoom10 = new SpeechBubble(35, Characters.guard, "Wait, should I have told you that?");

    // Guard conversation in Storage Room.
    public static SpeechBubble convoInStorageRoom = new SpeechBubble(39, Characters.guard, "*Hic*, who goes there?");
    public static SpeechBubble convoInStorageRoom2 = new SpeechBubble(40, Characters.guard, "Ya tryin' ta kidnap the princess?");
    public static SpeechBubble convoInStorageRoom3 = new SpeechBubble(41, Characters.player, "Quite the opposite, actually, I'm trying to save her.");
    public static SpeechBubble convoInStorageRoom4 = new SpeechBubble(42, Characters.guard, "Ya are? Well, good for you!");
    public static SpeechBubble convoInStorageRoom5 = new SpeechBubble(43, Characters.guard, "Whadya want?");
    public static SpeechBubble convoInStorageRoom6 = new SpeechBubble(44, Characters.player, new List<string> { "Are you sitting on some rope?", "Are you drunk?", "Goodbye." });
    public static SpeechBubble convoInStorageRoom7 = new SpeechBubble(45, Characters.player, "Are you sitting on some rope? Can I have it?");
    public static SpeechBubble convoInStorageRoom8 = new SpeechBubble(46, Characters.player, "Are you drunk?");
    public static SpeechBubble convoInStorageRoom9 = new SpeechBubble(47, Characters.player, "Goodbye.");
    public static SpeechBubble convoInStorageRoom10 = new SpeechBubble(48, Characters.guard, "Why this thing? Oh ya, it makes a great seat on the floor.");
    public static SpeechBubble convoInStorageRoom11 = new SpeechBubble(49, Characters.guard, "How 'bout this. If ya answer me little riddle and bring me what I want, then sure you can have it.");
    public static SpeechBubble convoInStorageRoom12 = new SpeechBubble(50, Characters.guard, "Here is the riddle:");
    public static SpeechBubble convoInStorageRoom13 = new SpeechBubble(51, Characters.guard, "Go to the chamber where people feed the stomachs of men and retrieve the red blood that hazes the mind.");
    public static SpeechBubble convoInStorageRoom14 = new SpeechBubble(52, Characters.guard, "Do ya wanna hear it again?");
    public static SpeechBubble convoInStorageRoom15 = new SpeechBubble(53, Characters.player, new List<string> { "Yes.", "No" });

    public static SpeechBubble convoInStorageRoom16 = new SpeechBubble(54, Characters.guard, "Ah, you got me item I asked for. As promised, here's the rope.");
    public static SpeechBubble convoInStorageRoom17 = new SpeechBubble(55, Characters.guard, "Thanks for the wine!");

    public static void Initialize()
    {
        memory.SetLines();
        bigDoor.SetLines();
        needKey.SetLines();
        hasKey.SetLines();
        sink.SetLines();
        sink2.SetLines(new List<SpeechBubble> { OwO });
        OwO.SetLines();
        stove.SetLines();
        needKey2.SetLines();

        flashback1A.SetLines(new List<SpeechBubble> { flashback1B });
        flashback1B.SetLines(new List<SpeechBubble> { flashback1C });
        flashback1C.SetLines(new List<SpeechBubble> { flashback1D });
        flashback1D.SetLines(new List<SpeechBubble> { flashback1E });
        flashback1E.SetLines(new List<SpeechBubble> { flashback1F });
        flashback1F.SetLines();
        flashback1Over.SetLines();

        flashback2A.SetLines(new List<SpeechBubble> { flashback2B });
        flashback2B.SetLines(new List<SpeechBubble> { flashback2C });
        flashback2C.SetLines(new List<SpeechBubble> { flashback2D });
        flashback2D.SetLines(new List<SpeechBubble> { flashback2E });
        flashback2E.SetLines();
        flashback2Over.SetLines();

        flashback3A.SetLines(new List<SpeechBubble> { flashback3B });
        flashback3B.SetLines(new List<SpeechBubble> { flashback3C });
        flashback3C.SetLines(new List<SpeechBubble> { flashback3D });
        flashback3D.SetLines();
        flashback3Over.SetLines();

        convoWithWitch1.SetLines(new List<SpeechBubble> { convoWithWitch2 });
        convoWithWitch2.SetLines(new List<SpeechBubble> { convoWithWitch3 });
        convoWithWitch3.SetLines();

        convoInBreakRoom.SetLines(new List<SpeechBubble> { convoInBreakRoom2 });
        convoInBreakRoom2.SetLines(new List<SpeechBubble> { convoInBreakRoom3, convoInBreakRoom4, convoInBreakRoom5 });
        convoInBreakRoom3.SetLines(new List<SpeechBubble> { convoInBreakRoom6 });
        convoInBreakRoom4.SetLines(new List<SpeechBubble> { convoInBreakRoom9 });
        convoInBreakRoom5.SetLines();
        convoInBreakRoom6.SetLines(new List<SpeechBubble> { convoInBreakRoom8 });
        convoInBreakRoom8.SetLines(new List<SpeechBubble> { convoInBreakRoom2 });
        convoInBreakRoom9.SetLines(new List<SpeechBubble> { convoInBreakRoom10 });
        convoInBreakRoom10.SetLines(new List<SpeechBubble> { convoInBreakRoom2 });
    }

    public static SpeechBubble GetDialogueByID(int num)
    {
        return allDialogue[num];
    }
}
