using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackTower
{
    class Program
    {
        static string command;
        static string heroName;
        static int causeOfDeath;
        static string room;
        static int chance;
        static int critchance;
        static public int herolife = 15;
        static public int moblife;
        static int herodmg;
        static int critherodmg;
        static int mobdmg;
        static int critmobdmg;
        static int escapechance;
        static int evadechance;
        static int blockchance;
        static int extramobdmg;
        static bool won;
        static bool northdoor = false;
        static bool westdoor = false;

        static bool sword = false;
        static bool hammer = false;
        static bool map = false;
        static bool healVial = false;
        static bool torch = false;
        static bool shield = false;
        static bool planks = false;

        static int vials = 0;
        static bool foundFirstVial = false;
        static bool foundSecondVial = false;

        static void Main()
        {
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("|      THE BLACK TOWER       |");
            Console.WriteLine("+----------------------------+");
            Console.WriteLine();
            Console.WriteLine("By Drizak!");
            Console.WriteLine();
            Console.WriteLine("Press the given keys to access to commands");
            AskAgain:
            Console.WriteLine();
            Console.WriteLine("1. Start New Game");
            Console.WriteLine("2. Exit Game");

            KeyAsk();

            switch(command)
            {
                case "1":
                    Console.WriteLine("Starting the game...");
                    Console.WriteLine();
                    GameStart();
                    break;
                case "2":
                    GameEnd();
                    Console.WriteLine("Closing game session.");
                    break;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain;
            }

        }

        public static void KeyAsk()
        {
            Console.WriteLine();
            Console.WriteLine("Enter a command and press ENTER");
            Console.Write("Enter your command: ");
            command = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine();
        }

        public static void GameStart()
        {
            //Introduction to the King.
            Console.WriteLine("Tahgrazk: I am the King of Shavia, ruler of the Great City of the West. You are here because you won the tournament, thus gaining the privilege to wipe out the demons from the Black Tower.");
            Console.WriteLine();
            Console.WriteLine("Tahgrazk: But please, tell me your name");
            Console.WriteLine();
            Console.Write("Hero: My name is ");
            heroName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Tahzgrazk: Very well, "+heroName+", follow the mossy road to get to the Black Tower, but beware of the fierce demons that haunt the place.. good luck, everything you need is in your transport wagon.");
            Console.WriteLine();
            Console.WriteLine("Tahzgrazk: May the Gods be with you.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadLine();
            
            //On the Wagon
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("|     The same day, some hours later...     |");
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine();
            Console.WriteLine("Driver: We are getting close to the Black Tower, be careful.");
            Console.WriteLine();
            Console.WriteLine(heroName+": I am, keep your eyes on the road.");
            Console.WriteLine();
            Console.WriteLine("Driver: Something is coming after us!");
            Console.WriteLine();
            Console.WriteLine("Driver: We better get quickly to the Tower!");
            Console.WriteLine();
            Console.WriteLine(heroName + ": What? I can hardly see beyond this mist.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadLine(); 
            Console.WriteLine();
            Console.WriteLine("Driver: Is's by our side!!");
            Console.WriteLine();
            Console.WriteLine("Driver: AAAAAARRRRGHHHHHH!!");
            Console.WriteLine();
            Console.WriteLine(heroName + ": Damn! The Driver is dead!");
            Console.WriteLine();
            Console.WriteLine(heroName + ": Come to me if you dare, filthy Hell Spawn!.");
            Console.WriteLine();
            Console.WriteLine("*CRACK* *CRUCH* *HRRSSS*");
            Console.WriteLine();
            Console.WriteLine(heroName + ": Damn them, they are breaking the whells, if I stay in the Wagon, i will die aswell!.");
            Console.WriteLine();

            //Select to Jump or Stay

            AskAgain2:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Jump off the Wagon!");
            Console.WriteLine("2. Stay in the Wagon.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine("I better jump!");
                    Console.WriteLine();
                    goto Go1;
                case "2":
                    Console.WriteLine("I will stay in this wagon, no demon will be stronger than my faith.");
                    Console.WriteLine();
                    causeOfDeath = 1;
                    Death();
                    break;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain2;
            }

        Go1:
            Console.WriteLine(heroName + ": I jumped off the wagon, the demons did not see me doing so, they just attacked the Wagon, ultimately destroying it and throwing it into the cliff.");
            Console.WriteLine();
            Console.WriteLine(heroName + ": All the equipment that was in the wagon is lost, but i swore an oath to King Tahgrazk, i must get to the Black Tower.");
            Console.WriteLine();
            Console.WriteLine(heroName + ": I better start walking...");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadLine();
            Console.WriteLine();
            //At the Black Tower Entrance
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("|     Some days after...     |");
            Console.WriteLine("+----------------------------+");
            Console.WriteLine();
            Console.WriteLine(heroName + ": Finally! I got to the Black Tower, but i have no sword, no armor, no anything!");
            Console.WriteLine();
            Console.WriteLine(heroName + ": Anyways, if I slay the demons and purify the Black Tower from all evil, there will be songs about me.");

        AskAgain3:
            Console.WriteLine("Finally in the gates of the Black Tower, what should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Enter the Black Tower.");
            Console.WriteLine("2. Walk around the Black Tower.");
            Console.WriteLine("L. Look.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine(heroName + ": Let's slay some demons!");
                    Console.WriteLine();
                    BlackTowerF1();
                    break;
                case "2":
                    Console.WriteLine(heroName + ": Took a while to explore the surroundings of the Black Tower, nothing interesting though.");
                    goto AskAgain3;
                case "L":
                    Console.WriteLine(heroName + ": The surroundings are of pure forest, i cant see a thing behind the trees.");
                    Console.WriteLine();
                    Console.WriteLine(heroName + ": The Black Tower... now i understand why all the Champions are scared about it, a 3-story building covered in black mossy bricks, haunted by demons inside, maybe ghosts from the Wars.");
                    Console.WriteLine();
                    Console.WriteLine(heroName + ": All the windows have been blocked from inside, the story tells a Dead King had come to the Tower, haunting the halls, then taking the Guards souls and enslaving them into eternal service, now im here to give them they rest.");
                    Console.WriteLine();
                    goto AskAgain3;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain3;
            }

        }

        static void BlackTowerF1()
        {
            //First room of the Black Tower 
            RoomB1BB:
            room = "RoomB1BB";
            Console.WriteLine(heroName + ": I am in the first floor of the tower, on the North side.");
            Console.WriteLine();
            Console.WriteLine(heroName + ": I can hardly see with this darkness, but i can tell there are 3 doors.");
            Console.WriteLine();
            AskAgain4:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go South.");
            Console.WriteLine("2. Go East.");
            Console.WriteLine("3. Go West.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    if (torch == true){
                    Console.WriteLine(heroName + ": The path is blocked, I can't step through there.");
                    Console.WriteLine();
                    }
                    else{
                    Console.WriteLine(heroName + ": I don't see a thing, it's too risky to go that way without light.");
                    Console.WriteLine();
                    }
                    goto AskAgain4;
                case "2":
                    if (torch == true)
                    {
                        Console.WriteLine(heroName + ": This path leads to the First Floor Storage Room.");
                        Console.WriteLine();
                        goto RoomB1BC;
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": I see some light emanating from the room, it should be the First Floor Storage.");
                        Console.WriteLine();
                        goto RoomB1BC;
                    }
                case "3":
                    if (torch == true)
                    {
                        Console.WriteLine(heroName + ": A corridor, let's go into it.");
                        Console.WriteLine();
                        goto RoomB1BA;
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": I don't see a thing, it's too risky to go that way without light.");
                        Console.WriteLine();
                        goto AskAgain4;
                    }
                case "L":
                    if (torch == true)
                    {
                        Console.WriteLine(heroName + ": There are 3 doors, leading to South, West and East.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": I can barely see 3 doors, the corridors behind the South and West doors are really dark, its too dangerous to walk into.");
                        Console.WriteLine();
                        Console.WriteLine(heroName + ": The East corridor looks a bit more lit up, maybe i can find a lamp or something.");
                        Console.WriteLine();
                    }
                    goto AskAgain4;
                case "I":
                    OpenInv();
                    goto AskAgain4;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain4;
            }

            //First Floor Storage Room
            RoomB1BC:
            room = "RoomB1BC";
            Console.WriteLine(heroName + ": I am in the first Floor Storage Room.");
            Console.WriteLine();
            Console.WriteLine(heroName + ": There is some light, there must be a torch around here.");
            Console.WriteLine();
            AskAgain5:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go South.");
            Console.WriteLine("2. Go West.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine(heroName + ": The path is blocked, I can't step through there.");
                    Console.WriteLine();
                    goto AskAgain5;
                case "2":
                    if (torch == true)
                    {
                        Console.WriteLine(heroName + ": The entrance to the Black Tower.");
                        Console.WriteLine();
                        goto RoomB1BB;
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": I will not leave until i find the torch, it will prove useful in the hunt for evil.");
                        Console.WriteLine();
                        goto AskAgain5;
                    }
                case "L":
                    if (torch == true)
                    {
                        Console.WriteLine(heroName + ": Nothing more of interest here, there is a door on the West, leading to the Black Tower entrance, and a blocked door to the South.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": There are some torches on the wall, there is a door on the West, leading to the Black Tower entrance, and a blocked door to the South.");
                        Console.WriteLine();
                        Console.WriteLine(heroName + ": I will take a torch.");
                        Console.WriteLine();
                        Console.WriteLine("Now you have a torch, press I in the command selection screen to check your inventory!");
                        torch = true;
                    }
                    goto AskAgain5;
                case "I":
                    OpenInv();
                    goto AskAgain5;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain5;
            }

            //Room B1BA, Mob 10%, 5 hp
            RoomB1BA:
            room = "RoomB1BA";
            Console.WriteLine(heroName + ": A corridor, the tower has lots of it, the air in this corridor is heavier.");
            Console.WriteLine();
            Console.WriteLine(heroName + ": I can feel a presence in this corridor.");
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadLine();
            
            Random random = new Random();
            chance = random.Next(0, 10);
            if (chance <= 0)
            {
                moblife = 5;
                extramobdmg = 0;
                BattleMob(moblife, room, extramobdmg);
            }
            else
            {
                Console.WriteLine(heroName + ": It was nothing, lets keep moving.");
            }
            Console.WriteLine();

        AskAgain6:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go South.");
            Console.WriteLine("2. Go East.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine(heroName + ": This way leads to the Armory.");
                    Console.WriteLine();
                    goto RoomB2BA;
                case "2":
                    Console.WriteLine(heroName + ": The entrance to the Black Tower.");
                    Console.WriteLine();
                    goto RoomB1BB;
                case "L":
                    Console.WriteLine(heroName + ": I feel a dark presence standing at my side, i prefer to walk out of this corridor as soon as possible.");
                    Console.WriteLine();
                    goto AskAgain6;
                case "I":
                     OpenInv();
                    goto AskAgain6;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain6;
            }

            //Room B2BA, Armory
            RoomB2BA:
            room = "RoomB2BA";
            Console.WriteLine(heroName + ": This is the Armory, maybe i can find some good weapons or something.");
            Console.WriteLine();

             AskAgain7:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go North.");
            Console.WriteLine("2. Go East.");
            Console.WriteLine("3. Go South.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine(heroName + ": This door leads to a corridor.");
                    Console.WriteLine();
                    goto RoomB1BA;
                case "2":
                    Console.WriteLine(heroName + ": This door leads to the central room of the Tower.");
                    Console.WriteLine();
                    goto RoomB2BB;
                case "3":
                    Console.WriteLine(heroName + ": The path is blocked, I can't step through there");
                    Console.WriteLine();
                    goto AskAgain7;
                case "L":
                    if (sword == false)
                    {
                        Console.WriteLine(heroName + ": Inside a chest i found a rusty old sword.");
                        Console.WriteLine();
                        Console.WriteLine(heroName + ": There are another chests, i should take a look.");
                        Console.WriteLine();
                        Console.WriteLine("Now you have a sword, press I in the command selection screen to check your inventory!");
                        sword = true;
                    }
                    if (hammer == false)
                    {
                        Console.WriteLine(heroName + ": Took a while, but inside a wooden old chest i found a hammer, it may prove useful.");
                        Console.WriteLine();
                        Console.WriteLine(heroName + ": There are no more chests to open, the armory has been completely ransacked.");
                        Console.WriteLine();
                        Console.WriteLine("Now you have a hammer, press I in the command selection screen to check your inventory!");
                        hammer = true;
                    }
                    Console.WriteLine();
                    goto AskAgain7;
                case "I":
                     OpenInv();
                    goto AskAgain7;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain7;
            }

            //Room B2BB, Central Room First Floor
        RoomB2BB:
            room = "RoomB2BB";
            Console.WriteLine(heroName + ": This is the Central Room of the First Floor.");
            Console.WriteLine();

        AskAgain8:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go North.");
            Console.WriteLine("2. Go East.");
            Console.WriteLine("3. Go West.");
            Console.WriteLine("4. Go South.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine(heroName + ": The path is blocked, I can't step through there.");
                    Console.WriteLine();
                    goto AskAgain8;
                case "2":
                    Console.WriteLine(heroName + ": This door leads to a corridor.");
                    Console.WriteLine();
                    goto RoomB2BC;
                case "3":
                    Console.WriteLine(heroName + ": This way leads to the Armory.");
                    Console.WriteLine();
                    goto RoomB2BA;
                case "4":
                    Console.WriteLine(heroName + ": This way leads to another corridor.");
                    Console.WriteLine();
                    goto RoomB3BB;
                case "L":
                    Console.WriteLine(heroName +": Nothing of interest here, better keep moving.");
                    Console.WriteLine();
                    goto AskAgain8;
                case "I":
                    OpenInv();
                    goto AskAgain8;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain8;
            }

        //Room B2BC, Mob 30% 7 hp
        RoomB2BC:
            room = "RoomB2BC";
            Console.WriteLine(heroName + ": The southern door looks reinforced, maybe i can break it with something.");
            Console.WriteLine();
            Console.WriteLine(heroName + ": I feel a dark presence within this corridor.");
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadLine();

            Random random1 = new Random();
            chance = random1.Next(0, 10);
            if (chance <= 2)
            {
                moblife = 7;
                extramobdmg = 0;
                BattleMob(moblife, room, extramobdmg);
            }
            else
            {
                Console.WriteLine(heroName + ": It was nothing, lets keep moving.");
            }
            Console.WriteLine();

        AskAgain9:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go North.");
            Console.WriteLine("2. Go West.");
            Console.WriteLine("3. Go South.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine(heroName + ": The path is blocked, I can't step through there.");
                    Console.WriteLine();
                    goto AskAgain9;
                case "2":
                    Console.WriteLine(heroName + ": This door leads to a corridor.");
                    Console.WriteLine();
                    goto RoomB2BC;
                case "3":
                    if (northdoor == false)
                    {
                        Console.WriteLine(heroName + ": This door looks heavily reinforced, maybe i can break it.");
                        Console.WriteLine();
                        if (hammer == true)
                        {
                            Console.WriteLine(heroName + ": Maybe trying with the hammer i found in the armory...");
                            Console.WriteLine();
                            goto AskAgain9;
                        }
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": This door leads to some staircases, which leads to the Second Floor.");
                        goto RoomB3BC;
                    }
                    break;
                case "L":
                    if (northdoor == false)
                    {
                        Console.WriteLine(heroName + ": The southern door looks heavily reinforced, i should be capable of breaking it somehow, maybe with some heavy tools.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": The southern door leads to the staircases to the Second Floor.");
                        Console.WriteLine();
                    }
                    Console.WriteLine(heroName + ": There are 3 doors, one leading to the North, which is blocked, another to the South and a last one to the West.");
                    Console.WriteLine();
                    goto AskAgain9;
                case "I":
                    OpenInv();
                    goto AskAgain9;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain9;
            }

            //Room B3BA, Infirmary
        RoomB3BA:
            room = "RoomB3BA";
            Console.WriteLine(heroName + ": This is the Infirmary, I can not imagine how many men died here.");
            Console.WriteLine();

        AskAgain10:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go North.");
            Console.WriteLine("2. Go East.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine(heroName + ": The path is blocked, I can't step through there.");
                    Console.WriteLine();
                    goto AskAgain10;
                case "2":
                    Console.WriteLine(heroName + ": This door leads to a corridor.");
                    Console.WriteLine();
                    goto RoomB3BB;
                case "L":
                    if (foundFirstVial == true)
                    {
                        Console.WriteLine(heroName + ": Nothing more of interest here, there is a door on the West, leading to the Black Tower entrance, and a blocked door to the South.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": Looking inside some cabinets i found a Heal Vial, i can use this to restore my Health.");
                        Console.WriteLine();
                        Console.WriteLine("Now you have " + vials + " Heal Vial, press I in the command selection screen to check your inventory!");
                        foundFirstVial = true;
                        vials = vials + 1;
                    }
                    goto AskAgain10;
                case "I":
                    OpenInv();
                    goto AskAgain10;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain10;
            }

            //Room B3BB, Mob 30% 6 hp
            RoomB3BB:
            room = "RoomB3BB";
            Console.WriteLine(heroName + ": Another corridor in the Black Tower, I wonder how many are...");
            Console.WriteLine();
            Console.WriteLine(heroName + ": I feel a dark presence within this corridor.");
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadLine();

            Random random2 = new Random();
            chance = random2.Next(0, 10);
            if (chance <= 2)
            {
                moblife = 6;
                extramobdmg = 1;
                BattleMob(moblife, room, extramobdmg);
            }
            else
            {
                Console.WriteLine(heroName + ": It was nothing, lets keep moving.");
            }
            Console.WriteLine();

        AskAgain11:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go North.");
            Console.WriteLine("2. Go East.");
            Console.WriteLine("3. Go West.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    Console.WriteLine(heroName + ": The door leads to the Central Room of the first floor.");
                    Console.WriteLine();
                    goto RoomB2BB;
                case "2":
                    if (westdoor == false)
                    {
                        Console.WriteLine(heroName + ": This door looks heavily reinforced, maybe i can break it.");
                        Console.WriteLine();
                        if (hammer == true)
                        {
                            Console.WriteLine(heroName + ": Maybe trying with the hammer i found in the armory...");
                            Console.WriteLine();
                            goto AskAgain11;
                        }
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": This door leads to some staircases, which leads to the Second Floor.");
                        goto RoomB3BC;
                    }
                    break;
                case "3":
                        Console.WriteLine(heroName + ": This door leads into an Infirmary, maybe I could find some meds.");
                        Console.WriteLine();
                        goto RoomB3BA;
                case "L":
                    if (northdoor == false)
                    {
                        Console.WriteLine(heroName + ": The eastern door looks heavily reinforced, i should be capable of breaking it somehow, maybe with some heavy tools.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": The eastern door leads to the staircases to the Second Floor.");
                        Console.WriteLine();
                    }
                    Console.WriteLine(heroName + ": There are 3 doors, one leading to the North, and 2 others to the East and West.");
                    Console.WriteLine();
                    goto AskAgain11;
                case "I":
                    OpenInv();
                    goto AskAgain11;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain11;
            }

            //Room B3BC, 1F Staircase
        RoomB3BC:
            room = "RoomB3BC";
            Console.WriteLine(heroName + ": Here is a staircase leading to the second floor.");
            Console.WriteLine();

        AskAgain12:
            Console.WriteLine("What should I do?");
            Console.WriteLine();
            Console.WriteLine("1. Go North.");
            Console.WriteLine("2. Go West.");
            Console.WriteLine("3. Go to the Second Floor.");
            Console.WriteLine("L. Look.");
            Console.WriteLine("I. Inventory.");

            KeyAsk();

            switch (command)
            {
                case "1":
                    if (northdoor == false)
                    {
                        Console.WriteLine(heroName + ": This door looks heavily reinforced, maybe i can break it.");
                        Console.WriteLine();
                        if (hammer == true)
                        {
                            Console.WriteLine(heroName + ": Maybe trying with the hammer i found in the armory...");
                            Console.WriteLine();
                            goto AskAgain12;
                        }
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": This door leads to some staircases, which leads to the Second Floor.");
                        goto RoomB2BC;
                    }
                    break;
                case "2":
                    if (westdoor == false)
                    {
                        Console.WriteLine(heroName + ": This door looks heavily reinforced, maybe i can break it.");
                        Console.WriteLine();
                        if (hammer == true)
                        {
                            Console.WriteLine(heroName + ": Maybe trying with the hammer i found in the armory...");
                            Console.WriteLine();
                            goto AskAgain12;
                        }
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": This door leads to some staircases, which leads to the Second Floor.");
                        goto RoomB3BB;
                    }
                    break;
                case "3":
                    Console.WriteLine(heroName + ": I will go to the Second Floor.");
                    Console.WriteLine();
                    //goto RoomN1NA; MUSTDOSOMETHING
                    break;
                case "L":
                    if (northdoor == false)
                    {
                        Console.WriteLine(heroName + ": The northern door looks heavily reinforced, i should be capable of breaking it somehow, maybe with some heavy tools.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": The northern door leads to a corridor.");
                        Console.WriteLine();
                    }
                    if (westdoor == false)
                    {
                        Console.WriteLine(heroName + ": The western door looks heavily reinforced, i should be capable of breaking it somehow, maybe with some heavy tools.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(heroName + ": The eastern door leads to a corridor.");
                        Console.WriteLine();
                    }
                    Console.WriteLine(heroName + ": There are 2 doors, one leading to the North, and other to the West.");
                    Console.WriteLine();
                    Console.WriteLine(heroName + ": Also, there is a staircase, which leads to the Second Floor.");
                    Console.WriteLine();
                    goto AskAgain12;
                case "I":
                    OpenInv();
                    goto AskAgain12;
                default:
                    Console.WriteLine("Please Enter a valid command.");
                    goto AskAgain12;
            }

            // SECOND FLOOR OF THE BLACK TOWER



        }

        static public void OpenInv()
        {
            Console.WriteLine();
            Console.WriteLine("Items on my inventory");
            Console.WriteLine("");
            if (sword == false && hammer == false && map == false && healVial == false && torch == false && shield == false && planks == false)
            {
                Console.WriteLine("I have no items on my inventory");
                goto InventoryEnd;
            }
            if (sword == true)
            {
                Console.WriteLine("Sword: A rusty steel sword I found in the Armory of the Black Tower, it will deal more damage than my fists.");
            }
            if (hammer == true)
            {
                Console.WriteLine("Hammer: A good old hammer made of pure iron, capable of destroying soft rocks.");
            }
            if (map == true)
            {
                Console.WriteLine("Map: A map of the Black Tower.. do i need to explain anything else?");
            }
            if (vials > 0)
            {
                Console.WriteLine("Heal Vial: This will heal my wounds and restore my mind to its maximum.");
            }
            if (torch == true)
            {
                Console.WriteLine("Torch: A torch, to lighten my way across this dark evil");
            }
            if (shield == true)
            {
                Console.WriteLine("Shield: This shield will help me keeping me alive, and i counter-attack fiercely when the Demons attack me");
            }
            if (planks == true)
            {
                Console.WriteLine("Wooden Planks: A long wood plank found on a costruction site of the Black Tower, i don't know how i carry it");
            }
            Console.WriteLine("");
            InventoryEnd:
            Console.WriteLine("");
        }

        static public void BattleMob(int moblife, string room, int extramobdmg)
        {
            Console.WriteLine(heroName + ": A foul creature of hell is on my way, i will wipe all evil!");
            Console.WriteLine();

            won = false;

            while (herolife > 0 && moblife > 0)
            {
            HeroTurn:

                Console.WriteLine("---- Your turn! ----");

                bool blocking;
                blocking = false;
                critherodmg = 0;
                Random randomherodmg = new Random();
                critchance = randomherodmg.Next(0, 10);

                if (critchance <= 0)
                {
                    critherodmg = 2;
                }
                else
                {
                    critherodmg = 0;
                }
            AskAgainX:
                Console.WriteLine("What should I do?");
                Console.WriteLine();
                Console.WriteLine("1. Attack!");
                Console.WriteLine("2. Defend.");
                Console.WriteLine("3. Try to escape.");

                KeyAsk();

                switch (command)
                {
                    case "1":
                        if (sword == true)
                        {
                            Console.WriteLine("You charge at the demon with your sword.");
                        }
                        else
                        {
                            Console.WriteLine("You attack the foul demon with your fists.");
                        }
                        Console.WriteLine();

                        if (sword == true)
                        {
                            herodmg = 3 + critherodmg;
                        }
                        else
                        {
                            herodmg = 1 + critherodmg;
                        }
                        Console.WriteLine("You deal " + herodmg + " damage to the Demon!");
                        moblife = moblife - herodmg;
                        Console.WriteLine("The Demon has " + moblife + " health points left!");
                        Console.WriteLine();

                        if (moblife <= 0)
                        {
                            Console.WriteLine("Congratulations! you have beaten the Demon!");
                            Console.WriteLine();
                            Console.WriteLine(heroName + ": One demon less in this wretched tower, the Dead King shall be next.");
                            Console.WriteLine();
                            Console.WriteLine("Press ENTER to continue..");
                            Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            won = true;
                            goto EndBattle;
                        }
                        else
                        {
                            goto MobTurn;
                        }
                    case "2":
                        if (shield == true)
                        {
                            Console.WriteLine("You keep your shield in front of you, trying to block the next attack.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("You stand in defensive position, trying to block the next attack.");
                            Console.WriteLine();
                        }
                        blocking = true;
                        goto MobTurn;
                    case "3":
                        escapechance = 0;
                        Random escaperandom = new Random();
                        escapechance = escaperandom.Next(0, 101);

                        if (escapechance <= 15)
                        {
                            Console.WriteLine("You successfully escaped, cowardly, but still alive.");
                        }
                        else
                        {
                            Console.WriteLine("Demon: COWARD, FIGHT LIKE A MAN!");
                            Console.WriteLine();
                            Console.WriteLine("When trying to escape, you were attacked by the demon, driving you to a corner with no escape");
                            herolife = herolife - mobdmg;
                            Console.WriteLine("You lost " + mobdmg + " health points");
                            Console.WriteLine("You have " + herolife + " health points left!");
                            goto MobTurn;
                        }
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid command.");
                        goto AskAgainX;
                }

            EndBattle:
                if (won == true)
                {
                    goto EndBattle2;
                }

            MobTurn:

                Console.WriteLine("---- Enemy turn! ----");
                Console.WriteLine();

                critmobdmg = 0;
                Random randommobdmg = new Random();
                critchance = randommobdmg.Next(0, 10);

                if (critchance <= 0)
                {
                    critmobdmg = 2;
                }
                else
                {
                    critmobdmg = 0;
                }

                Console.WriteLine("The demon attacks you!.");

                mobdmg = 2 + extramobdmg + critmobdmg;

                Random randomevade = new Random();
                evadechance = randomevade.Next(0, 20);

                if (evadechance <= 0)
                {
                    Console.WriteLine("You dodged the Demon's Attack!.");
                }
                else
                {
                    blockchance = 0;

                    if (blocking == true)
                    {
                        Random randomshblock = new Random();
                        blockchance = randomshblock.Next(0, 20);
                        switch (shield)
                        {
                            case true:
                                if (blockchance <= 6)
                                {
                                    Console.WriteLine("You blocked the attack with your shield!.");
                                    mobdmg = 1;
                                }
                                break;
                            case false:
                                if (blockchance <= 2)
                                {
                                    Console.WriteLine("You blocked the attack with your shield!.");
                                    mobdmg = 1;
                                }
                                break;
                            default:
                                Console.WriteLine("ERROR, THIS SHOULD NOT HAPPEN, PLEASE REPORT THIS INMEDIATELY WITH INFO TO RECREATE THE ERROR, PLEASE BE AS EXACT AS POSSIBLE, THANKS, DRIZAK");
                                Console.WriteLine("To prevent further errors, the game will now end, sorry for the apologies.");
                                GameEnd();
                                break;
                        }
                    }
                    Console.WriteLine("The demon clawed at you for " + mobdmg + " damage!");
                    herolife = herolife - mobdmg;
                    Console.WriteLine("You have " + herolife + " health points left!");
                    Console.WriteLine();

                    if (herolife <= 0)
                    {
                        causeOfDeath = 2;
                        Death();
                    }

                    goto HeroTurn;
                }

            }

        EndBattle2: ;
        }

        static public void Death()
        {
            switch (causeOfDeath)
            {
                case 1:
                    Console.WriteLine("As the demons destroy the wagon, they rip the wheels, and it fells into the cliff.");
                    Console.WriteLine("GAME OVER");
                    GameEnd();
                    break;
                case 2:
                    Console.WriteLine("The demon bash your skull against the wall, your blood spills all over the floor, your eyes begin to close...");
                    Console.WriteLine("GAME OVER");
                    GameEnd();
                    break;
                default:
                    Console.WriteLine("ERROR, THIS SHOULD NOT HAPPEN, PLEASE REPORT THIS INMEDIATELY WITH INFO TO RECREATE THE ERROR, PLEASE BE AS EXACT AS POSSIBLE, THANKS, DRIZAK");
                    Console.WriteLine("To prevent further errors, the game will now end, sorry for the apologies.");
                    GameEnd();
                    break;
            }
        }

        public static void GameEnd()
        {
            Console.WriteLine("Press ENTER to end..");
            Console.ReadLine(); 
            Environment.Exit(1);
        }

      }
    }