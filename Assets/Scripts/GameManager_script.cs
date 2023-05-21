using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

//------------------------------------------------------------------------------------------------------------
//  Global Declarations
//------------------------------------------------------------------------------------------------------------
public enum State { State1, State2, State3, State4, State5, State6, State7, State8, State9, State10, State11, State12, State13, State14, State15, State16, State1b, State2b, State3b, State4b, State5b, State6b, State7b, State8b, State9b, State10b, State11b, State12b, State13b, State14b, State15b, State16b }



//------------------------------------------------------------------------------------------------------------
public class GameManager_script : MonoBehaviour
{
    //------------------------------------------------------------------------------------------------------------
    //      Declarations
    //------------------------------------------------------------------------------------------------------------
    [SerializeField] TextMeshProUGUI storyText;
    [SerializeField] TextMeshProUGUI textChoiceA;
    [SerializeField] TextMeshProUGUI textChoiceB;
    [SerializeField] TextMeshProUGUI textChoiceC;
    [SerializeField] GameObject dropDownMenu;
    [SerializeField] GameObject walkthroughText;
    [SerializeField] GameObject buttonChoiceA;
    [SerializeField] GameObject buttonChoiceB;
    [SerializeField] GameObject buttonChoiceC;
    [SerializeField] GameObject imgageState1;
    [SerializeField] GameObject imgageState2;
    [SerializeField] GameObject imgageState3;
    [SerializeField] GameObject imgageState4;
    [SerializeField] GameObject imgageState5;
    [SerializeField] GameObject imgageState6;
    [SerializeField] GameObject imgageState7;
    [SerializeField] GameObject imgageState8;
    [SerializeField] GameObject imgageState9;
    [SerializeField] GameObject imgageState10;
    [SerializeField] GameObject imgageState11;
    [SerializeField] GameObject imgageState12;
    [SerializeField] GameObject imgageState13;
    [SerializeField] GameObject imgageState14;
    [SerializeField] GameObject imgageState15;
    [SerializeField] GameObject imgageState16;
    [SerializeField] GameObject imgageState1b;
    [SerializeField] GameObject imgageState2b;
    [SerializeField] GameObject imgageState3b;
    [SerializeField] GameObject imgageState4b;
    [SerializeField] GameObject imgageState5b;
    [SerializeField] GameObject imgageState6b;
    [SerializeField] GameObject imgageState7b;
    [SerializeField] GameObject imgageState8b;
    [SerializeField] GameObject imgageState9b;
    [SerializeField] GameObject imgageState10b;
    [SerializeField] GameObject imgageState11b;
    [SerializeField] GameObject imgageState12b;
    [SerializeField] GameObject imgageState13b;
    [SerializeField] GameObject imgageState14b;
    [SerializeField] GameObject imgageState15b;
    [SerializeField] GameObject imgageState16b;

    State currentState;
    //State previousState;

    bool hasTeddy = false;
    bool hasBread = false;
    bool hasPeach = false;
    // bool objectGlue = false;
    int lastChoice = 1;
    int counterMinecraft = 0;

    bool dropDownMenuActive = false;
    bool walkthroughActive = false;

    public AudioSource _AudioSource;
    [SerializeField] AudioClip _AudioClip1;
    [SerializeField] AudioClip _AudioClip2;
    [SerializeField] AudioClip _AudioClip3;




    // has no Element
    //------------------------------------------------------------------------------------------------------------
    //      Methods
    //------------------------------------------------------------------------------------------------------------
    public void OnClickButtonChoiseA() 
    {

        SelectChoice(1); 
    }

    //------------------------------------------------------------------------------------------------------------
    public void OnClickButtonChoiseB() 
    {

        SelectChoice(2); 
    }

    //------------------------------------------------------------------------------------------------------------
    public void OnClickButtonChoiseC() 
    {

        SelectChoice(3); 
    }

    //------------------------------------------------------------------------------------------------------------
    public void OnClickButtonMenu()
    {             
        if (dropDownMenuActive)
        {
            dropDownMenu.SetActive(false);
            dropDownMenuActive = false;
            walkthroughText.SetActive(false);
            walkthroughActive = false;
        }
        else
        {
            dropDownMenu.SetActive(true);
            dropDownMenuActive = true;
        }
    }



    //------------------------------------------------------------------------------------------------------------
    public void OnClickButtonGoToTitle()
    {
        // to be continued ...
        //Debug.Log("ButtonGoToTitle");
        SceneManager.LoadScene(0);
    }

    //------------------------------------------------------------------------------------------------------------
    public void OnClickButtonWalkthrough()
    {                
        if (walkthroughActive)
        {
            walkthroughText.SetActive(false);
            walkthroughActive = false;
        }
        else
        {
            walkthroughText.SetActive(true);
            walkthroughActive = true;
        }
    }

    //------------------------------------------------------------------------------------------------------------
    public void ActivateButtons(int caseButton) 
    {
        switch(caseButton)
        {
            case 0:
                buttonChoiceA.SetActive(false);
                buttonChoiceB.SetActive(false);
                buttonChoiceC.SetActive(false);
                break;
            case 1:
                buttonChoiceA.SetActive(true);  //
                buttonChoiceB.SetActive(false);                
                buttonChoiceC.SetActive(false);
                break;
            /*
            case 2:
                buttonChoiceA.SetActive(false);
                buttonChoiceB.SetActive(true);  //
                buttonChoiceC.SetActive(false);
                break;
            case 3:
                buttonChoiceA.SetActive(false);
                buttonChoiceB.SetActive(false);
                buttonChoiceC.SetActive(true);  //
                break;
            */
            case 4:
                buttonChoiceA.SetActive(true);
                buttonChoiceB.SetActive(true);
                buttonChoiceC.SetActive(false);  //
                break;
            /*
                case 5:
                buttonChoiceA.SetActive(false);
                buttonChoiceB.SetActive(false);
                buttonChoiceC.SetActive(true);  //
                break;
            case 6:
                buttonChoiceA.SetActive(false);
                buttonChoiceB.SetActive(false);
                buttonChoiceC.SetActive(true);  //
                break;
            */            
            case 9:
                buttonChoiceA.SetActive(true);
                buttonChoiceB.SetActive(true);
                buttonChoiceC.SetActive(true);
                break;

        }        
    }

    //------------------------------------------------------------------------------------------------------------
    public void DeactivateAllBackgrounds()
    {
        //---------------------------------
        imgageState1.SetActive(false);
        imgageState2.SetActive(false);
        imgageState3.SetActive(false);
        imgageState4.SetActive(false);
        imgageState5.SetActive(false);
        imgageState6.SetActive(false);
        imgageState7.SetActive(false);
        imgageState8.SetActive(false);
        imgageState9.SetActive(false);
        imgageState10.SetActive(false);
        imgageState11.SetActive(false);
        imgageState12.SetActive(false);
        imgageState13.SetActive(false);
        imgageState14.SetActive(false);
        imgageState15.SetActive(false);
        imgageState16.SetActive(false);
        //---------------------------------
        imgageState1b.SetActive(false);
        imgageState2b.SetActive(false);
        imgageState3b.SetActive(false);
        imgageState4b.SetActive(false);
        imgageState5b.SetActive(false);
        imgageState6b.SetActive(false);
        imgageState7b.SetActive(false);
        imgageState8b.SetActive(false);
        imgageState9b.SetActive(false);
        imgageState10b.SetActive(false);
        imgageState11b.SetActive(false);
        imgageState12b.SetActive(false);
        imgageState13b.SetActive(false);
        imgageState14b.SetActive(false);
        imgageState15b.SetActive(false);
        imgageState16b.SetActive(false);
        //---------------------------------
    }

    //------------------------------------------------------------------------------------------------------------
    public void DisplayState(int choice2=0)
    {
        string stringWeiter = "Next";
        DeactivateAllBackgrounds();

        switch(currentState)
        {
            //-----------------------------------------
            case State.State1:      // Büro 1
                ActivateButtons(4);     
                storyText.text = "You're standing in your office, in front of you Bob the Minion, sniffling in despair. He has lost his beloved Teddy - his best friend! When you ask him where he saw him last, he starts to fumble around. It is complicated. You only understand half of his confused explanations. But somehow he seems to have been dragged into the old floppy disk drive of your PC. You didn't even know you still had one. But what you know for sure: You have to go after him! Why not. Because of the upcoming university exams, procrastination is on your schedule today anyway. Are you going to follow Teddy into the game?";
                textChoiceA.text = "1) Yes!";
                textChoiceB.text = "2) No";
                //textChoiceC.text = "choiceCText State1";      
                imgageState1.SetActive(true);
                break;
            case State.State2:      // Büro 2
                ActivateButtons(9);
                storyText.text = "Bob sniffles. But someone has to save his teddy!";    // storyText State2
                textChoiceA.text = "1) Let's do it";             // choiceAText State2
                textChoiceB.text = "2) Distraction";           // choiceBText State2
                textChoiceC.text = "3) Logic"; // choiceCText State2                
                imgageState2.SetActive(true);
                break;
            case State.State3:      // Büro 3
                ActivateButtons(4);
                storyText.text = "Bob sniffles. But someone has to save his Teddy!";
                textChoiceA.text = "Let's do it";
                textChoiceB.text = "Logic";
                //textChoiceC.text = "choiceCText State3";
                imgageState3.SetActive(true);
                break;
            case State.State4:      // Pong (1972)
                ActivateButtons(4);
                storyText.text = "You find yourself in a very simple scenery. On your right you see a bar. On the left, too. But there is no teddy in sight, and Bob seems to have stayed behind in the third dimension. Intuitively you take the beam and hold it like a baseball bat.After standing around for a while, a circle appears.What are you going to do?";
                textChoiceA.text = "Violence";
                textChoiceB.text = "Play";                
                //textChoiceC.text = "choiceCText State4";
                imgageState4.SetActive(true);
                break;
            case State.State5:      // Space Invaders (1978) 
                ActivateButtons(4);
                storyText.text = "In the darkness, you can see a whole armada of alien spaceships above you. Slowly they come closer and closer and the shields don't look like they will last forever. You notice some kind of tank not far from you. \nWhat are you going to do?";
                textChoiceA.text = "Save humanity!";
                textChoiceB.text = "Light beam?";
                //textChoiceC.text = "choiceCText State5";
                imgageState5.SetActive(true);
                break;
            case State.State6:      // Pac Man (1980)
                ActivateButtons(4);
                storyText.text = "You find yourself in a kind of maze, in front of you a juicy cherry. You can't hold back and eat it. Lost in thought, you stroll through the maze and eat everything that comes your way. You didn't know you were so hungry. Is this stuff even edible? You put the peach that is now in front of you into your pocket for the time being.\nSuddenly you find yourself face to face with a ghost. This is bad. 'Stop,'' you shout, 'violence isn't the answer either!' Oddly enough, your tactics seem to work and the ghost is inclined to listen to you.";
                textChoiceA.text = "Discussing away";
                textChoiceB.text = "Talking";
                //textChoiceC.text = "choiceCText State6";
                imgageState6.SetActive(true);
                break;
            case State.State7:      // Super Mario Bros. (1983)
                ActivateButtons(4);
                storyText.text = "You see yourself surrounded by many shelves. The word 'platform' pops into your head. As you continue to look around, you notice a figure. Is it some kind of turtle? Whatever it is, it seems to be addicted to punk or he is a macho man looking for a construction worker, a cowboy.... Before you can finish the thought, the creature roars at you, 'Peach is mine and we will rule the Mushroom Kingdom together!'You're confused. What does this guy want from you?";
                textChoiceA.text = "Hand over Peach (if Peach is with you).";
                textChoiceB.text = "Escape!";
                if (hasPeach)
                    buttonChoiceA.SetActive(true);
                else
                    buttonChoiceA.SetActive(false);
                //textChoiceC.text = "choiceCText State7";
                imgageState7.SetActive(true);
                break;
            case State.State8:      // Moorhuhn (1999)
                ActivateButtons(4);
                storyText.text = "Chickens are flying everywhere! Chickens with especially big eyes. You are slightly confused. There don't seem to be any other birds and they are behaving extremely strangely. Some fly around, others peek out from behind trees, and others scare you by jumping into your field of vision from below. \nYou think about your next step ...";
                textChoiceA.text = "Throw stones";
                textChoiceB.text = "Throw bread (if bread taken with you)";
                if (hasBread)
                    buttonChoiceB.SetActive(true);
                else
                    buttonChoiceB.SetActive(false);
                //textChoiceC.text = "choiceCText State8";
                imgageState8.SetActive(true);
                break;
            case State.State9:      // WoW (2004)
                ActivateButtons(4);
                storyText.text = "Your eyes catch sight of a bustling, medieval-looking city. All around you scurry a wide variety of creatures: Dwarves, pandas, humans, gnomes, night elves, werewolves and blue aliens. You plunge into the colorful hustle and lose all sense of time. Suddenly, a strangely familiar figure appears in front of you. 'Mother ? ', you say, confused. The being with the appearance of your mother begins to tell you something about 'real life' and that you should go out again.\nHow do you react?";
                textChoiceA.text = "Scold";
                textChoiceB.text = "Search for a portal (if Teddy is there)";
                if (hasTeddy)
                    buttonChoiceB.SetActive(true);
                else
                    buttonChoiceB.SetActive(false);
                //textChoiceC.text = "choiceCText State9";
                imgageState9.SetActive(true);
                break;
            case State.State10:     // Elder Scrolls |V: Oblivion (2006)
                ActivateButtons(4);
                storyText.text = "'Stop right there, criminal scum!' Not exactly the friendliest greeting you've heard today. There's a guard standing in front of you, glaring nastily at you.\nHow do you respond to this obscenity ?";
                textChoiceA.text = "Fight";
                textChoiceB.text = "Bribe";
                //textChoiceC.text = "choiceCText State10";
                imgageState10.SetActive(true);                
                break;
            case State.State11:     // Minecraft (2011) 1
                ActivateButtons(4);
                storyText.text = "Wherever you've landed again now, it feels peaceful. To soft piano sounds you look around. You're standing in front of a small hut, everything around you is green, albeit quite angular. You could stay here forever, but you have a mission! You quickly notice a workbench and after a short time you have figured out how to make a teddy. You've done it! Now all you need is a way home. Maybe you can build a portal. You'll manage that after a while, too. Through the purple mist you can already see your office.";
                textChoiceA.text = "Go home!";
                textChoiceB.text = "Stay";
                //textChoiceC.text = "choiceCText State11";
                imgageState11.SetActive(true);
                break;
            case State.State12:     // Steve 1  /  Minecraft (2011) 2
                ActivateButtons(4);
                storyText.text = "You feel really refreshed after the exertions of the last few days? Level? Agein the portal catches your sight. The teddy bear in your hand, you think about whether it's finally time to go home.";
                textChoiceA.text = "Go home!";
                textChoiceB.text = "Stay";
                //textChoiceC.text = "choiceCText State12";
                imgageState12.SetActive(true);
                break;
            case State.State13:     // Steve 2
                ActivateButtons(0);
                storyText.text = "Congratulations, you are now stuck in a computer game! You have decided to spend eternity in a virtual world. What is this Real Life supposed to be anyway? Your name is Steve from now on.";
                //textChoiceA.text = "choiceAText State13";
                //textChoiceB.text = "choiceBText State13";
                //textChoiceC.text = "choiceCText State13";
                imgageState13.SetActive(true);
                break;
            case State.State14:     // Let's Play
                ActivateButtons(0);
                storyText.text = "You don't feel like understanding the game mechanics & decide to watch a Let's Play first to get to your goal as quickly as possible. You don't find a single one. Not even a post on a dusty forum. That's weird. You start to wonder when the last time you slept was. You don't. As you lay down in bed, you fall right into a deep sleep. After only 23 hours of dreamless sleep, you no longer see little yellow men looking for stuffed animals.";
                //textChoiceA.text = "choiceAText State14";
                //textChoiceB.text = "choiceBText State14";
                //textChoiceC.text = "choiceCText State14";
                imgageState14.SetActive(true);
                break;
            case State.State15:     // Skyrim-Karren
                ActivateButtons(0);
                storyText.text = "This was a bad idea. You could have thought of that sooner. After just one swipe of the sword pommel, the world around you goes black. \n'Hey, you. You're finally awake.' You awake in a horse cart with other men. You are tied up. Crap, you think, while being grilled by a dragon.";
                //textChoiceA.text = "choiceAText State15";
                //textChoiceB.text = "choiceBText State15";
                //textChoiceC.text = "choiceCText State15";
                imgageState15.SetActive(true);
                break;
            case State.State16:     // Büro 4
                ActivateButtons(0);
                storyText.text = "You have made it! You are finally back in your office. You were afraid that you would be stuck in your computer forever. Bob is still there and looks at you expectantly. Triumphantly, you hold the teddy bear out to him and his eyes sparkle with joy. You hand Bob the stuffed animal and make him swear that he will never lose it again in some absurd parallel reality. He promises and you live happily ever after.";
                //textChoiceA.text = "choiceAText State16";
                //textChoiceB.text = "choiceBText State16";
                //textChoiceC.text = "choiceCText State16";
                imgageState16.SetActive(true);
                break;
            //--------------------------------------------------------------
            case State.State1b:      // Büro 1
                ActivateButtons(1);
                if (choice2==1)
                    storyText.text = "1) Yes! \nWithout much hesitation, you jam your finger into the disk drive. After all, you were never the brightest candle on the cake. But at least helpful! You feel a slight tingling sensation, as if a dimension is being amputated from you, and find yourself in a two-tone room.";
                else        // choice2 = 2
                    storyText.text = "2) \nNo How is that supposed to work anyway? You won't get involved in that nonsense! Even if you'd rather do anything than finish your task. THAT is going too far. The teddy will surely be lying around somewhere again, but not in a computer.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "Nope.";
                //textChoiceC.text = "choiceCText State1";
                imgageState1b.SetActive(true);
                break;
            case State.State2b:      // Büro 2
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Let’s do it. \nWith a deep sigh you agree and stick your finger into the floppy drive. To your great astonishment, a strong force pulls you into the computer and you find yourself in a strange 2 - dimensional and - colored world.";
                else if(choice2==2) // choice2 = 2
                    storyText.text = "2) Distraction! \nLooking for a distraction, you look around your office.It's chaotic. The first thing that catches your eye is a slice of dry toast. What are you going to do with it? You haven't thought that far ahead and put it in your pants, lost in thought.";
                else               // choice2 = 3
                    storyText.text = "3) Logic \nYou feel sorry for Bob, but think that he just wants some company and maybe to play with you.You convince Bob that it makes more sense to look for Teddy from in front of the screen.Bob tells you the title of the game.You have never heard of it, but to your amazement you find a matching file on your computer.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "Spielen";           // choiceBText State2
                //textChoiceC.text = "Kleben (falls Kleber dabei)"; // choiceCText State2
                imgageState2b.SetActive(true);
                break;
            case State.State3b:      // Büro 3
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Let’s do it. \nWith a deep sigh you agree and stick your finger into the floppy drive. To your great astonishment, a strong force pulls you into the computer and you find yourself in a strange 2 - dimensional and - colored world.";
                else        // choice2 = 2
                    storyText.text = "2) Logic \nYou feel sorry for Bob, but think he just wants some company and maybe to play games with you.You convince Bob that it makes more sense to look for Teddy from in front of the screen.Bob tells you the title of the game.You have never heard of it, but to your amazement you find a matching file on your computer.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "Lichtstrahl?";
                //textChoiceC.text = "choiceCText State3";
                imgageState3b.SetActive(true);
                break;
            case State.State4b:      // Pong (1972)
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Violence \nToday is not a good day for this crap! First some little yellow bastard sends you into the matrix and now a two - dimensional ball is bothering you too.Enough! You flail at the circle with the beam.\n \nAfter you have vented your aggression on the uninvolved geometric object, it dissolves into pixels and disappears.In the same place there is now a door, through which you rush.You wish you could slam it behind you.";
                else        // choice2 = 2
                    storyText.text = "2) Play \nYou may not be a jock, but you have a rough idea of how this game works. In the spirit of procrastination, you play until you finally win.The ball dissolves into pixels and a door appears in its place. You're a little disappointed that you can't continue playing, but that's when you remember why you're here in the first place.Curious about what follows, you walk through the door.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "Reden";
                //textChoiceC.text = "choiceCText State4";
                imgageState4b.SetActive(true);
                break;
            case State.State5b:      // Space Invaders (1978) 
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Save humanity! \nYou are sure: Only you can save them! You jump into the tank and start wiping out the approaching aliens one by one until there are none left.When you get out of the vehicle, you see a door and go through it.";
                else        // choice2 = 2
                    storyText.text = "2) Light beam? \nJust as you're thinking about what your next move should be, you notice a cone of light on the ground - some kind of tractor beam? As you approach, a man falls down. You can hardly believe your eyes: he is holding a teddy bear in his arms! Staggering, the man gets up and disappears into the darkness, leaving the stuffed animal behind. Before anyone can see it, you take the bear. Now you just have to find a way back! In search of a portal, you too now wander off through the darkness.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "Flucht";
                //textChoiceC.text = "choiceCText State5";
                imgageState5b.SetActive(true);
                break;
            case State.State6b:      // Pac Man (1980)
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Argue away \nThis is the opportunity. You gallantly put all your oratory skills together and show the ghost very conclusively and absolutely irrefutably that he should not exist at all. The argument is so good that not even the narrator can reproduce it and the ghost dissolves. What a luck.Nonchalantly, you stroll out of the screen.";
                else        // choice2 = 2
                    storyText.text = "2) Talk \nYou are amazed! Finally you can talk to a being from the afterlife. You have so many questions, so many things you've always wanted to know.... Unfortunately, you can't think of a single thing now.Forced to make a move, you mutter, 'So what's your favorite animal?' The ghost links arms with you. As you walk between realities, he explains to you that only chickens - especially grouse - are the only true life form. You wonder if the ghost might have once been a chicken himself, but before you can get to that, he leads you through a door, saying 'Here, see for yourself!' and disappears.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "Brotzeit (wenn Brot dabei)";
                //textChoiceC.text = "choiceCText State6";
                imgageState6b.SetActive(true);
                break;
            case State.State7b:      // Super Mario Bros. (1983)
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Hand over peach (if in inventory). \nHe's yelling something about a Peach? You have a peach ... Since the guy doesn't seem to be very bright, you plausibly explain to him that your peach is the Peach he's looking for and the key to ruling the galaxy. It seems to work and he lets you pass.";
                else        // choice2 = 2
                    storyText.text = "2) Escape! \nThis guy definitely looks too dangerous for you.True to the saying 'He who loses and runs away can win another time!', you make a run for it and run out of the left edge of the screen.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "Portal suchen";
                //textChoiceC.text = "choiceCText State7";
                imgageState7b.SetActive(true);
                break;
            case State.State8b:      // Moorhuhn (1999)
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Throw stones \nThese grouse look like fantastic targets!You quickly pick up some stones and start aiming at the birds flying by.Your reprehensible action seems to make the gods of the game world benevolent, and after you've brought enough chickens down from the sky, they reward you with a door. You walk through it with a proud chest.";
                else        // choice2 = 2
                    storyText.text = "2) Throw bread (if you have bread) \nYou remember to pack a piece of toast at home and offer the hungry-looking birds some crumbs.They gratefully share the meal with you and you strike up a conversation.They promise to answer a question that has been bothering you for a while.Where do game characters go when they leave the screen? The chickens show you the way.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "Bestechen";
                //textChoiceC.text = "choiceCText State8";
                imgageState8b.SetActive(true);
                break;
            case State.State9b:      // WoW (2004)
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Scold \nWhat does this woman think she is doing ? Does she even know how many quests you have to do here? Besides, the Darkmoon Fair ends tomorrow... You start cursing and swearing at your counterpart. Congratulations, you've grounded yourself for a week. At least now you have enough time to game. Casually you stroll through the next door.";
                else        // choice2 = 2
                    storyText.text = "2) Search for the portal (if Teddy is with you) \nYou agree with her. You really forgot your real task. You look at the teddy in your hand and remember that some people in town have talked about a tower in the Mage Quarter where there are supposed to be portals to all sorts of worlds.Maybe one of these portals will take you back home. You decide to try your luck and jump into the nearest portal.";
                textChoiceA.text = stringWeiter; ;
                //textChoiceB.text = "Bleiben ";
                //textChoiceC.text = "choiceCText State9";
                imgageState9b.SetActive(true);
                break;
            case State.State10b:     // Elder Scrolls |V: Oblivion (2006)
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Fight! \nWhy is he looking at you so stupidly? And what did he just call you? You decide to give him a good beating.";
                else        // choice2 = 2
                    storyText.text = "2) Bribe \nThe good man looks like he could use some sugar-glazed pastries.Luckily, you're someone who always carries change around in his pockets. He certainly won't notice that these are 10 cent pieces, after all they look like gold.You hand the man your change and his mine loosens. He lets you pass.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "choiceBText State10";
                //textChoiceC.text = "choiceCText State10";
                imgageState10b.SetActive(true);
                break;
            case State.State11b:     // Minecraft (2011) 1
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Go home! \nThe sight awakens a certain longing in you to finally leave all this madness behind. You take a deep breath, grab the teddy a little tighter and step through the portal.";
                else        // choice2 = 2
                    storyText.text = "2) Stay \nYou decide to enjoy this quiet little paradise for a while longer.After all, no one seems to live in the hut, so you settle in.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "choiceBText State11";
                //textChoiceC.text = "choiceCText State11";
                imgageState11b.SetActive(true);
                break;
            case State.State12b:     // Steve 1      /  Minecraft (2011) 2
                ActivateButtons(1);
                if (choice2 == 1)
                    storyText.text = "1) Go home! \nThe sight awakens a certain longing in you to finally leave all this madness behind. You take a deep breath, grab the teddy a little tighter and step through the portal.";
                else        // choice2 = 2
                    storyText.text = "2) Stay \nAt home only the little yellow wretch is waiting, who has caused you all this stress! And you have grown fond of the teddy yourself in the meantime. You decide to stay a while longer.";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "choiceBText State12";
                //textChoiceC.text = "choiceCText State12";
                imgageState12b.SetActive(true);
                break;
            /*
            case State.State13b:     // Steve 2
                if (choice2 == 1)
                    storyText.text = "Weiter";
                else        // choice2 = 2
                    storyText.text = "Weiter";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "choiceBText State13";
                //textChoiceC.text = "choiceCText State13";
                imgageState13b.SetActive(true);
                break;
            case State.State14b:     // Let's Play
                if (choice2 == 1)
                    storyText.text = "Weiter";
                else        // choice2 = 2
                    storyText.text = "Weiter";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "choiceBText State14";
                //textChoiceC.text = "choiceCText State14";
                imgageState14b.SetActive(true);
                break;
            case State.State15b:     // Skyrim-Karren
                if (choice2 == 1)
                    storyText.text = "Weiter";
                else        // choice2 = 2
                    storyText.text = "Weiter";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "choiceBText State15";
                //textChoiceC.text = "choiceCText State15";
                imgageState15b.SetActive(true);
                break;
            case State.State16b:     // Büro 4
                if (choice2 == 1)
                    storyText.text = "Weiter";
                else        // choice2 = 2
                    storyText.text = "Weiter";
                textChoiceA.text = stringWeiter;
                //textChoiceB.text = "choiceBText State16";
                //textChoiceC.text = "choiceCText State16";
                imgageState16b.SetActive(true);
                break;
            */
            //-----------------------------------------
            default:
                break;
            //-----------------------------------------
        }

        //choiceBText.gameObject.SetActive(choiceBText.text != "");
        //choiceCText.gameObject.SetActive(choiceCText.text != "");
    }

    //------------------------------------------------------------------------------------------------------------
    public void SelectChoice(int choice)
    {                
        //previousState = currentState;

        switch (currentState)
        {
            // Hier stehen die ganzen Bedingungen um von einem State zu einem anderen zu kommen
            // es gelten immer 2 Bedingungen: 1.in welchem State befinde ich mich gerade und 2. welcher Button gedrückt wurde
            //---------------------------------------------------------------------------------------------------
            case State.State1:  // Büro 1
                currentState = State.State1b;       // von State 1 mit Wahl 1 nach State 2
                break;
            case State.State2:  // Büro 2
                currentState = State.State2b;       // von State 1 mit Wahl 1 nach State 2                
                break;
            case State.State3:  // Büro 3
                currentState = State.State3b;       // von State 1 mit Wahl 1 nach State 2                
                break;
            case State.State4:  // Pong (1972)
                currentState = State.State4b;       // von State 1 mit Wahl 1 nach State 2
                break;
            case State.State5:  // Space Invaders (1978) 
                currentState = State.State5b;       // von State 1 mit Wahl 1 nach State 2
                break;
            case State.State6:  // Pac Man (1980)
                currentState = State.State6b;       // von State 1 mit Wahl 1 nach State 2
                break;
            case State.State7:  // Super Mario Bros. (1983)
                currentState = State.State7b;       // von State 1 mit Wahl 1 nach State 2
                break;
            case State.State8:  // Moorhuhn (1999)
                currentState = State.State8b;       // von State 1 mit Wahl 1 nach State 2
                break;
            case State.State9:  // WoW (2004)
                currentState = State.State9b;       // von State 1 mit Wahl 1 nach State 2
                break;
            case State.State10: // Elder Scrolls |V: Oblivion (2006)
                currentState = State.State10b;       // von State 1 mit Wahl 1 nach State 2
                break;
            case State.State11: // Minecraft (2011) 1
                currentState = State.State11b;       // von State 1 mit Wahl 1 nach State 2
                hasTeddy = true;
                Debug.Log("has Teddy!");
                break;
            case State.State12: // Steve 1      /  Minecraft (2011) 2
                currentState = State.State12b;       // von State 1 mit Wahl 1 nach State 2
                break;
            /*
            case State.State13: // Steve 2
                currentState = State.State13b;       // von State 1 mit Wahl 1 nach State 2
                if (choice == 1) currentState = State.State14;       // von State 1 mit Wahl 1 nach State 1
                else if (choice == 2) currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                else if (choice == 3) currentState = State.State4;  // von State 1 mit Wahl 3 nach State 4
                break;
            case State.State14: // Let's Play
                currentState = State.State14b;       // von State 1 mit Wahl 1 nach State 2
                if (choice == 1) currentState = State.State15;       // von State 1 mit Wahl 1 nach State 1
                else if (choice == 2) currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                else if (choice == 3) currentState = State.State4;  // von State 1 mit Wahl 3 nach State 4
                break;
            case State.State15: // Skyrim-Karren
                currentState = State.State15b;       // von State 1 mit Wahl 1 nach State 2
                if (choice == 1) currentState = State.State1;       // von State 1 mit Wahl 1 nach State 1
                else if (choice == 2) currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                else if (choice == 3) currentState = State.State4;  // von State 1 mit Wahl 3 nach State 4
                break;
            case State.State16: // Büro 4
                currentState = State.State16b;       // von State 1 mit Wahl 1 nach State 2
                if (choice == 1) currentState = State.State1;       // von State 1 mit Wahl 1 nach State 1
                else if (choice == 2) currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                else if (choice == 3) currentState = State.State4;  // von State 1 mit Wahl 3 nach State 4
                break;
            */
            //---------------------------------------------------------------------------------------------------
            case State.State1b:  // Büro 1
                if (lastChoice == 1) currentState = State.State4;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2) currentState = State.State2;  // von State 1 mit Wahl 2 nach State 3                
                break;
            case State.State2b:  // Büro 2
                if (lastChoice == 1) currentState = State.State4;       // von State 2 mit Wahl 1 nach State 3
                else if (lastChoice == 2)
                {
                    currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                    hasBread = true;
                    Debug.Log("has Bread!");
                }
                else if (lastChoice == 3) currentState = State.State14;  // von State 1 mit Wahl 3 nach State 4
                break;
            case State.State3b:  // Büro 3
                if (lastChoice == 1) currentState = State.State4;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2) currentState = State.State14;  // von State 1 mit Wahl 2 nach State 3                
                break;
            case State.State4b:  // Pong (1972)
                if (lastChoice == 1) currentState = State.State10;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2) currentState = State.State5;  // von State 1 mit Wahl 2 nach State 3                
                break;
            case State.State5b:  // Space Invaders (1978) 
                if (lastChoice == 1) currentState = State.State6;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2)
                { 
                    currentState = State.State9;  // von State 1 mit Wahl 2 nach State 3
                    hasTeddy = true;
                    Debug.Log("has Teddy!");
                }
                break;
            case State.State6b:  // Pac Man (1980)
                if (lastChoice == 1)
                {
                    currentState = State.State7;       // von State 1 mit Wahl 1 nach State 2
                    hasPeach = true;
                    Debug.Log("has Peach!");
                }
                else if (lastChoice == 2) currentState = State.State8;  // von State 1 mit Wahl 2 nach State 3                
                break;
            case State.State7b:  // Super Mario Bros. (1983)
                if (lastChoice == 1 && hasPeach) currentState = State.State8;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2) currentState = State.State6;  // von State 1 mit Wahl 2 nach State 3                
                else currentState = State.State7;
                break;                
            case State.State8b:  // Moorhuhn (1999)
                if (lastChoice == 1) currentState = State.State9;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2 && hasBread) currentState = State.State11;  // von State 1 mit Wahl 2 nach State 3                
                else currentState = State.State8;
                break;
            case State.State9b:  // WoW (2004)
                if (lastChoice == 1) currentState = State.State10;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2 && hasTeddy) currentState = State.State16;  // von State 1 mit Wahl 2 nach State 3                
                else currentState = State.State9;
                break;
            case State.State10b: // Elder Scrolls |V: Oblivion (2006)
                if (lastChoice == 1) currentState = State.State15;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2) currentState = State.State11;  // von State 1 mit Wahl 2 nach State 3                
                break;
            case State.State11b: // Minecraft (2011) 1
                if (lastChoice == 1) currentState = State.State16;       // von State 1 mit Wahl 1 nach State 2
                else if (lastChoice == 2) currentState = State.State12;  // von State 1 mit Wahl 2 nach State 3                
                break;
            case State.State12b: // Steve 1      /  Minecraft (2011) 2
                if (lastChoice == 1)
                {
                    counterMinecraft=0;
                    currentState = State.State16;       // von State 1 mit Wahl 1 nach State 2
                }
                else if (lastChoice == 2)
                {
                    counterMinecraft++;
                    if (counterMinecraft >= 3) currentState = State.State13;  // von State 1 mit Wahl 2 nach State 3
                    else if (lastChoice == 2 && counterMinecraft < 3) currentState = State.State12;  // von State 1 mit Wahl 2 nach State 3                
                }                    
                break;
            /*
            case State.State13b: // Steve 2
                if (choice == 1) currentState = State.State14;       // von State 1 mit Wahl 1 nach State 1
                else if (choice == 2) currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                else if (choice == 3) currentState = State.State4;  // von State 1 mit Wahl 3 nach State 4
                break;
            case State.State14b: // Let's Play
                if (choice == 1) currentState = State.State15;       // von State 1 mit Wahl 1 nach State 1
                else if (choice == 2) currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                else if (choice == 3) currentState = State.State4;  // von State 1 mit Wahl 3 nach State 4
                break;
            case State.State15b: // Skyrim-Karren
                if (choice == 1) currentState = State.State1;       // von State 1 mit Wahl 1 nach State 1
                else if (choice == 2) currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                else if (choice == 3) currentState = State.State4;  // von State 1 mit Wahl 3 nach State 4
                break;
            case State.State16b: // Büro 4
                if (choice == 1) currentState = State.State1;       // von State 1 mit Wahl 1 nach State 1
                else if (choice == 2) currentState = State.State3;  // von State 1 mit Wahl 2 nach State 3
                else if (choice == 3) currentState = State.State4;  // von State 1 mit Wahl 3 nach State 4
                break;
            */
                //---------------------------------------------------------------------------------------------------                
        }

        DisplayState(choice);
        lastChoice = choice;
    }

    //------------------------------------------------------------------------------------------------------------
    // Start is called before the first frame update
    void Start()
    {
        currentState = State.State1;
        //previousState = State.State1;

        dropDownMenu.SetActive(false);
        dropDownMenuActive = false;

        walkthroughActive = false;
        walkthroughText.SetActive(false);

        hasBread = false;
        hasPeach = false;
        hasTeddy = false;

        DisplayState();
    }

    //------------------------------------------------------------------------------------------------------------
    // Update is called once per frame
    /*
    void Update()
    {       
        // Empty
    }
    */
    //------------------------------------------------------------------------------------------------------------
}
