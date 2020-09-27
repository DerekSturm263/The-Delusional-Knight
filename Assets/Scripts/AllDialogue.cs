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
    public static SpeechBubble present = new SpeechBubble(87, Characters.player, "Oh! This is the king's present, isn't it?");

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
    public static SpeechBubble flashback3Over = new SpeechBubble(26, Characters.player, "I remember now! That evil hag put a spell on me! Oh no, what will happen to the princess and I now?");

    // Witch conversation outside castle.
    public static SpeechBubble convoWithWitch1 = new SpeechBubble(36, Characters.witch, "What do you need to know?");
    public static SpeechBubble convoWithWitch2 = new SpeechBubble(37, Characters.player, new List<string> { "What are the controls?", "What should I do first?", "Nothing." });
    public static SpeechBubble convoWithWitch3 = new SpeechBubble(38, Characters.player, "What are the controls?");
    public static SpeechBubble convoWithWitch4 = new SpeechBubble(88, Characters.player, "What should I do first?");
    public static SpeechBubble convoWithWitch5 = new SpeechBubble(89, Characters.player, "Nothing. Goodbye.");
    public static SpeechBubble convoWithWitch6 = new SpeechBubble(90, Characters.witch, "WASD or Arrow Keys to move. TAB to open your inventory. E to interact with items and people.");
    public static SpeechBubble convoWithWitch7 = new SpeechBubble(91, Characters.witch, "First you need to get inside, then you should think about sneaking past those guards...");

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
    public static SpeechBubble convoInStorageRoom12 = new SpeechBubble(50, Characters.guard, "Here is the riddle:"); // Goes back to here if you haven't given him anything yet.
    public static SpeechBubble convoInStorageRoom13 = new SpeechBubble(51, Characters.guard, "Go to the chamber where people feed the stomachs of men and retrieve the red blood that hazes the mind.");
    public static SpeechBubble convoInStorageRoom14 = new SpeechBubble(52, Characters.guard, "Do ya wanna hear it again?");
    public static SpeechBubble convoInStorageRoom15 = new SpeechBubble(53, Characters.player, new List<string> { "Yes.", "No." });
    public static SpeechBubble convoInStorageRoom18 = new SpeechBubble(58, Characters.guard, "So what if I am?");
    public static SpeechBubble convoInStorageRoom19 = new SpeechBubble(59, Characters.player, "Oh, nothing, nothing.");

    public static SpeechBubble convoInStorageRoom16 = new SpeechBubble(54, Characters.guard, "Ah, you got me item I asked for. As promised, here's the rope."); // Goes back to here if you give him the wine.
    public static SpeechBubble convoInStorageRoom17 = new SpeechBubble(55, Characters.guard, "Thanks for the wine!"); // Goes back to here after talking to him after giving him the wine.

    // Princess conversation in her room.
    public static SpeechBubble convoInPrincessRoom = new SpeechBubble(60, Characters.princess, "Oh, Sir Dagon! Why are you here at this late hour? Is something the matter?");
    public static SpeechBubble convoInPrincessRoom2 = new SpeechBubble(61, Characters.player, "I'm here to rescue you, my fair maiden.");
    public static SpeechBubble convoInPrincessRoom3 = new SpeechBubble(62, Characters.princess, "Rescue me? But I'm safe here in my room.");
    public static SpeechBubble convoInPrincessRoom4 = new SpeechBubble(63, Characters.player, "Nonsense, the king has tricked you! He will do terrible things to you and you need to come with me.");
    public static SpeechBubble convoInPrincessRoom5 = new SpeechBubble(64, Characters.princess, "My father? Nay, he is just downhearted since my dearest mother left him.");
    public static SpeechBubble convoInPrincessRoom6 = new SpeechBubble(65, Characters.player, "I plead you, let us leave this place!");
    public static SpeechBubble convoInPrincessRoom7 = new SpeechBubble(66, Characters.princess, "No! I will stay here in my room, please leave at once!");
    public static SpeechBubble convoInPrincessRoom8 = new SpeechBubble(67, Characters.player, "I need something to capture her with...");
    public static SpeechBubble convoInPrincessRoom9 = new SpeechBubble(68, Characters.princess, "What was that?");
    public static SpeechBubble convoInPrincessRoom10 = new SpeechBubble(69, Characters.player, "Nothing.");

    public static SpeechBubble convoInPrincessRoom11 = new SpeechBubble(114, Characters.princess, "Get away from me!");
    public static SpeechBubble convoInPrincessRoom12 = new SpeechBubble(115, Characters.player, "I'm sorry, your highness.");
    public static SpeechBubble convoInPrincessRoom13 = new SpeechBubble(116, Characters.princess, "Sorry for wh-");
    public static SpeechBubble convoInPrincessRoom14 = new SpeechBubble(117, Characters.player, "Okay, now that I have the princess I can finally leave the castle. Time to see Ingrid.");

    // King conversation in the Throne Room.
    public static SpeechBubble convoInThroneRoom = new SpeechBubble(70, Characters.player, "King Peter, I require your assistance.");
    public static SpeechBubble convoInThroneRoom2 = new SpeechBubble(71, Characters.player, "I need you to unlock the princess's bedroom so I may see her.");
    public static SpeechBubble convoInThroneRoom3 = new SpeechBubble(72, Characters.king, "At this late hour, what for?");
    public static SpeechBubble convoInThroneRoom4 = new SpeechBubble(73, Characters.player, "I need to see her, there's no time to explain.");
    public static SpeechBubble convoInThroneRoom5 = new SpeechBubble(74, Characters.king, "All right, but first. May I ask of you a favor?");
    public static SpeechBubble convoInThroneRoom6 = new SpeechBubble(75, Characters.player, new List<string> { "Of course.", "No." });
    public static SpeechBubble convoInThroneRoom7 = new SpeechBubble(76, Characters.player, "Of course, anything my lord.");
    public static SpeechBubble convoInThroneRoom8 = new SpeechBubble(77, Characters.player, "No.");
    public static SpeechBubble convoInThroneRoom9 = new SpeechBubble(78, Characters.king, "Why, that was rude of you. Anyways, I will still ask you to help me.");
    public static SpeechBubble convoInThroneRoom10 = new SpeechBubble(79, Characters.king, "I require some assistance. You see, tommorow is my daughter's birthday and I seem to have misplaced her present.");
    public static SpeechBubble convoInThroneRoom11 = new SpeechBubble(80, Characters.king, "As you may know, she's the only family I have left. My wife left me, and I would just hate for anything to happen to my daughter.");
    public static SpeechBubble convoInThroneRoom12 = new SpeechBubble(81, Characters.king, "Can you just look around some of the barrels to see if you can find it. I'm sure it's in one of them.");
    public static SpeechBubble convoInThroneRoom13 = new SpeechBubble(82, Characters.king, "Thank you my fair knight. Bring me the gift and I will let you into the princess's room.");

    public static SpeechBubble convoInThroneRoom14 = new SpeechBubble(83, Characters.king, "Thank you, Dagon! I was worried that I lost this forever.");
    public static SpeechBubble convoInThroneRoom15 = new SpeechBubble(84, Characters.king, "As promised, I will now open the door to my daughter's room.");
    public static SpeechBubble convoInThroneRoom18 = new SpeechBubble(118, Characters.king, "But first, please listen to my tale of woe.");
    public static SpeechBubble convoInThroneRoom19 = new SpeechBubble(119, Characters.king, "Oh, I am a sorrowful fool! I am left alone with my daughter! Oh, my daughter, my beautiful daughter where would I be without you?");
    public static SpeechBubble convoInThroneRoom20 = new SpeechBubble(120, Characters.king, "Ever since your mother has left me, you have been a strong woman. Say I wonder, where did my personal guard go to protect you?");

    public static SpeechBubble convoInThroneRoom16 = new SpeechBubble(85, Characters.king, "Remember, I want you to find my daughter's present somewhere in the castle. I'm sure it's in one of the barrels.");
    public static SpeechBubble convoInThroneRoom17 = new SpeechBubble(86, Characters.king, "Thanks again, now go to my daughter and do whatever it is you were going to do.");

    // Opening dialogue.
    public static SpeechBubble openingConvo = new SpeechBubble(92, Characters.witch, "Young knight, may I ask for your assistance?");
    public static SpeechBubble openingConvo2 = new SpeechBubble(93, Characters.player, "What is it, fair maiden?");
    public static SpeechBubble openingConvo3 = new SpeechBubble(94, Characters.witch, "It's about the princess. I want you to take her away from King Peter.");
    public static SpeechBubble openingConvo4 = new SpeechBubble(95, Characters.player, "There's no way that I'd ever do that for you!");
    public static SpeechBubble openingConvo5 = new SpeechBubble(96, Characters.witch, "You're going to kidnap the princess for me so that I can use her blood for my anti-aging potion.");
    public static SpeechBubble openingConvo6 = new SpeechBubble(97, Characters.witch, "Hahahahahahahaha!");
    public static SpeechBubble openingConvo7 = new SpeechBubble(98, Characters.player, "What's so funny? You know there's no way I'd do your bidding.");
    public static SpeechBubble openingConvo8 = new SpeechBubble(99, Characters.witch, "We'll see about that! Take this!");
    public static SpeechBubble openingConvo9 = new SpeechBubble(100, Characters.player, "Ah!");

    public static SpeechBubble openingEnding = new SpeechBubble(101, Characters.player, "Huh? What's going on?");
    public static SpeechBubble openingEnding2 = new SpeechBubble(102, Characters.player, "Where am I?");
    public static SpeechBubble openingEnding3 = new SpeechBubble(103, Characters.player, "This looks like the castle. What am I doing here?");

    public static SpeechBubble witchConvo1 = new SpeechBubble(104, Characters.player, "What am I doing here?");
    public static SpeechBubble witchConvo2 = new SpeechBubble(105, Characters.witch, "Here, my friend, have this potion to clear your mind and tidy you up.");
    public static SpeechBubble witchConvo3 = new SpeechBubble(106, Characters.player, "Thank you fair maiden.");
    public static SpeechBubble witchConvo4 = new SpeechBubble(107, Characters.player, "Why am I here?");
    public static SpeechBubble witchConvo5 = new SpeechBubble(108, Characters.witch, "You are a knight for King Peter and you must rescue the princess.");
    public static SpeechBubble witchConvo6 = new SpeechBubble(109, Characters.witch, "King Peter has turned evil and can not be trusted. You must break into the castle to steal the princess.");
    public static SpeechBubble witchConvo7 = new SpeechBubble(110, Characters.player, "Steal?");
    public static SpeechBubble witchConvo8 = new SpeechBubble(111, Characters.witch, "From King Peter. The princess doesn't know it but she's in dire need of saving.");
    public static SpeechBubble witchConvo9 = new SpeechBubble(112, Characters.player, "Really? Well, I guess I should go save her then. It's my duty as a knight to protect my people.");
    public static SpeechBubble witchConvo10 = new SpeechBubble(113, Characters.witch, "Indeed. Haha... Talk to me if you have any questions.");

    public static SpeechBubble finalConvoWithWitch = new SpeechBubble(114, Characters.witch, "Ah, my fair knight. I'm so glad you have arrived.");
    public static SpeechBubble finalConvoWithWitch2 = new SpeechBubble(115, Characters.witch, "I see that you have the princess with you. Nicely done.");
    public static SpeechBubble finalConvoWithWitch3 = new SpeechBubble(116, Characters.witch, "She's now safe from that evil-");
    public static SpeechBubble finalConvoWithWitch4 = new SpeechBubble(117, Characters.player, "No! I know who you are, I know what you did! There's no way I'm handing th princess over to you now!");
    public static SpeechBubble finalConvoWithWitch5 = new SpeechBubble(118, Characters.player, "");

    public static void Initialize()
    {
        convoInPrincessRoom.SetLines(new List<SpeechBubble> { convoInPrincessRoom2 });
        convoInPrincessRoom2.SetLines(new List<SpeechBubble> { convoInPrincessRoom3 });
        convoInPrincessRoom3.SetLines(new List<SpeechBubble> { convoInPrincessRoom4 });
        convoInPrincessRoom4.SetLines(new List<SpeechBubble> { convoInPrincessRoom5 });
        convoInPrincessRoom5.SetLines(new List<SpeechBubble> { convoInPrincessRoom6 });
        convoInPrincessRoom6.SetLines(new List<SpeechBubble> { convoInPrincessRoom7 });
        convoInPrincessRoom7.SetLines(new List<SpeechBubble> { convoInPrincessRoom8 });
        convoInPrincessRoom8.SetLines(new List<SpeechBubble> { convoInPrincessRoom9 });
        convoInPrincessRoom9.SetLines(new List<SpeechBubble> { convoInPrincessRoom10 });
        convoInPrincessRoom10.SetLines();
        convoInPrincessRoom11.SetLines();
        convoInPrincessRoom12.SetLines(new List<SpeechBubble> { convoInPrincessRoom13 });
        convoInPrincessRoom13.SetLines(new List<SpeechBubble> { convoInPrincessRoom14 });
        convoInPrincessRoom14.SetLines();

        openingConvo.SetLines(new List<SpeechBubble> { openingConvo2 });
        openingConvo2.SetLines(new List<SpeechBubble> { openingConvo3 });
        openingConvo3.SetLines(new List<SpeechBubble> { openingConvo4 });
        openingConvo4.SetLines(new List<SpeechBubble> { openingConvo5 });
        openingConvo5.SetLines(new List<SpeechBubble> { openingConvo6 });
        openingConvo6.SetLines(new List<SpeechBubble> { openingConvo7 });
        openingConvo7.SetLines(new List<SpeechBubble> { openingConvo8 });
        openingConvo8.SetLines(new List<SpeechBubble> { openingConvo9 });
        openingConvo9.SetLines();

        openingEnding.SetLines(new List<SpeechBubble> { openingEnding2 });
        openingEnding2.SetLines(new List<SpeechBubble> { openingEnding3 });
        openingEnding3.SetLines();

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
        convoWithWitch2.SetLines(new List<SpeechBubble> { convoWithWitch3, convoWithWitch4, convoWithWitch5 });
        convoWithWitch3.SetLines(new List<SpeechBubble> { convoWithWitch6 });
        convoWithWitch4.SetLines(new List<SpeechBubble> { convoWithWitch7 });
        convoWithWitch5.SetLines();
        convoWithWitch6.SetLines(new List<SpeechBubble> { convoWithWitch1 });
        convoWithWitch7.SetLines(new List<SpeechBubble> { convoWithWitch1 });

        convoInBreakRoom.SetLines(new List<SpeechBubble> { convoInBreakRoom2 });
        convoInBreakRoom2.SetLines(new List<SpeechBubble> { convoInBreakRoom3, convoInBreakRoom4, convoInBreakRoom5 });
        convoInBreakRoom3.SetLines(new List<SpeechBubble> { convoInBreakRoom6 });
        convoInBreakRoom4.SetLines(new List<SpeechBubble> { convoInBreakRoom9 });
        convoInBreakRoom5.SetLines();
        convoInBreakRoom6.SetLines(new List<SpeechBubble> { convoInBreakRoom8 });
        convoInBreakRoom8.SetLines(new List<SpeechBubble> { convoInBreakRoom2 });
        convoInBreakRoom9.SetLines(new List<SpeechBubble> { convoInBreakRoom10 });
        convoInBreakRoom10.SetLines(new List<SpeechBubble> { convoInBreakRoom2 });

        convoInStorageRoom.SetLines(new List<SpeechBubble> { convoInStorageRoom2 });
        convoInStorageRoom2.SetLines(new List<SpeechBubble> { convoInStorageRoom3 });
        convoInStorageRoom3.SetLines(new List<SpeechBubble> { convoInStorageRoom4 });
        convoInStorageRoom4.SetLines(new List<SpeechBubble> { convoInStorageRoom5 });
        convoInStorageRoom5.SetLines(new List<SpeechBubble> { convoInStorageRoom6 });
        convoInStorageRoom6.SetLines(new List<SpeechBubble> { convoInStorageRoom7, convoInStorageRoom8, convoInStorageRoom9 });
        convoInStorageRoom7.SetLines(new List<SpeechBubble> { convoInStorageRoom10 });
        convoInStorageRoom8.SetLines(new List<SpeechBubble> { convoInStorageRoom18 });
        convoInStorageRoom9.SetLines();
        convoInStorageRoom10.SetLines(new List<SpeechBubble> { convoInStorageRoom11 });
        convoInStorageRoom11.SetLines(new List<SpeechBubble> { convoInStorageRoom12 });
        convoInStorageRoom12.SetLines(new List<SpeechBubble> { convoInStorageRoom13 });
        convoInStorageRoom13.SetLines(new List<SpeechBubble> { convoInStorageRoom14 });
        convoInStorageRoom14.SetLines(new List<SpeechBubble> { convoInStorageRoom15 });
        convoInStorageRoom15.SetLines(new List<SpeechBubble> { convoInStorageRoom13, convoInStorageRoom5 });

        convoInStorageRoom16.SetLines();
        convoInStorageRoom17.SetLines();
        convoInStorageRoom18.SetLines(new List<SpeechBubble> { convoInStorageRoom19 });
        convoInStorageRoom19.SetLines(new List<SpeechBubble> { convoInStorageRoom5 });

        hasKey2.SetLines();
        needKey3.SetLines();
        present.SetLines();

        convoInThroneRoom.SetLines(new List<SpeechBubble> { convoInThroneRoom2 });
        convoInThroneRoom2.SetLines(new List<SpeechBubble> { convoInThroneRoom3 });
        convoInThroneRoom3.SetLines(new List<SpeechBubble> { convoInThroneRoom4 });
        convoInThroneRoom4.SetLines(new List<SpeechBubble> { convoInThroneRoom5 });
        convoInThroneRoom5.SetLines(new List<SpeechBubble> { convoInThroneRoom6 });
        convoInThroneRoom6.SetLines(new List<SpeechBubble> { convoInThroneRoom7, convoInThroneRoom8 });
        convoInThroneRoom7.SetLines(new List<SpeechBubble> { convoInThroneRoom10 });
        convoInThroneRoom8.SetLines(new List<SpeechBubble> { convoInThroneRoom9 });
        convoInThroneRoom9.SetLines(new List<SpeechBubble> { convoInThroneRoom10 });
        convoInThroneRoom10.SetLines(new List<SpeechBubble> { convoInThroneRoom11 });
        convoInThroneRoom11.SetLines(new List<SpeechBubble> { convoInThroneRoom12 });
        convoInThroneRoom12.SetLines(new List<SpeechBubble> { convoInThroneRoom13 });
        convoInThroneRoom13.SetLines();
        convoInThroneRoom14.SetLines(new List<SpeechBubble> { convoInThroneRoom15 });
        convoInThroneRoom15.SetLines(new List<SpeechBubble> { convoInThroneRoom18 });
        convoInThroneRoom18.SetLines(new List<SpeechBubble> { convoInThroneRoom19 });
        convoInThroneRoom19.SetLines(new List<SpeechBubble> { convoInThroneRoom20 });
        convoInThroneRoom20.SetLines();
        convoInThroneRoom16.SetLines();
        convoInThroneRoom17.SetLines();

        witchConvo1.SetLines(new List<SpeechBubble> { witchConvo2 });
        witchConvo2.SetLines(new List<SpeechBubble> { witchConvo3 });
        witchConvo3.SetLines(new List<SpeechBubble> { witchConvo4 });
        witchConvo4.SetLines(new List<SpeechBubble> { witchConvo5 });
        witchConvo5.SetLines(new List<SpeechBubble> { witchConvo6 });
        witchConvo6.SetLines(new List<SpeechBubble> { witchConvo7 });
        witchConvo7.SetLines(new List<SpeechBubble> { witchConvo8 });
        witchConvo8.SetLines(new List<SpeechBubble> { witchConvo9 });
        witchConvo9.SetLines(new List<SpeechBubble> { witchConvo10 });
        witchConvo10.SetLines();
    }

    public static SpeechBubble GetDialogueByID(int num)
    {
        return allDialogue[num];
    }
}
