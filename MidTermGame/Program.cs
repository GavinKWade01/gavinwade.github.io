using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int userMenuSelection;
            
            while (running)
            {
                //There are two \\ to make it appear as a single \ within the WriteLines otherwise it gives an error. 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" _____ _            _____                              __  ___  ___           _   _  __          ");
                Console.WriteLine("|_   _| |          /  __ \\                            / _| |  \\/  |          | | (_)/ _|         ");
                Console.WriteLine("  | | | |__   ___  | /  \\/_   _ _ __ ___  ___    ___ | |_  | .  . | ___  _ __| |_ _| |_ ___ _ __ ");
                Console.WriteLine("  | | | '_ \\ / _ \\ | |   | | | | '__/ __|/ _ \\  / _ \\|  _| | |\\/| |/ _ \\| '__| __| |  _/ _ \\ '__|");
                Console.WriteLine("  | | | | | |  __/ | \\__/\\ |_| | |  \\__ \\  __/ | (_) | |   | |  | | (_) | |  | |_| | ||  __/ |   ");
                Console.WriteLine("  \\_/ |_| |_|\\___|  \\____/\\__,_|_|  |___/\\___|  \\___/|_|   \\_|  |_/\\___/|_|   \\__|_|_| \\___|_|   \n");;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please select an option from the menu below: \n");
                Console.WriteLine("1) Show Production Credits");
                Console.WriteLine("2) Show Game Instructions");
                Console.WriteLine("3) Play Game");
                Console.WriteLine("4) Exit the Command Console.");

                userMenuSelection = Convert.ToInt32(Console.ReadLine());

                switch (userMenuSelection)
                {
                    case 1:
                        Credit();
                        break;
                    case 2:
                        Instructions();
                        break;
                    case 3:
                        Game();
                        break;
                    case 4:
                        Exit();
                        break;
                }

            }


        }

        public static void Credit()
        {
            Console.Clear();
            Console.WriteLine("This application was design by Gavin Wade in 2021.");
            Console.WriteLine("\nPress Enter to return to the Main Menu...");
            Console.ReadLine();
        }

        public static void Instructions()
        {
            Console.Clear();
            Console.WriteLine("...Game Instructions...");
            Console.WriteLine("To play the game simply read the story and then enter the number \nto make your decision in the game story line. Doing such will allow \n you to play through the game and win! \n Good luck and have fun!");
            Console.WriteLine("\nPress Enter to return to the Main Menu...");
            Console.ReadLine();
        }

        public static void Game()
        {
            Console.Clear();
            Console.WriteLine("Play Game!!!");
            Console.WriteLine("\nPress Enter to start the game!");
            Console.ReadLine();
            PlayGame();
        }

        public static void PlayGame()
        { 
            public bool classArmor;
            public bool isStealthy; 
            public int classSelection;
            Console.Clear();
            Console.WriteLine("What is your name?");
            public string charName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome {0}", charName);

            Console.WriteLine("\nWhat class are you?");
            Console.WriteLine("1) Warrior");
            Console.WriteLine("2) Ranger");
            Console.WriteLine("3) Mage");
            Console.WriteLine("4) What is the difference?");
            classSelection = Convert.ToInt32(Console.ReadLine());
            
            if (classSelection == 1)
            {
                Warrior myWarrior1 = new Warrior(charName);
            }else if(classSelection == 2)
            {
                Ranger myRanger1 = new Ranger(charName);
            }else if (classSelection == 3)
            {
                Wizard myWizard = new Wizard(charName);
            }else if (classSelection == 4)
            {
                Console.Clear();
                Console.WriteLine("Warriors carry a sword and adorn heavy armor. \nRangers carry a short bow and adorn light armor. \nMages carry a wand and adorn no armor.");
            }else
            {
                PlayGame();
            }
        }
        

        public static void Exit()
        {
            Environment.Exit();
        }
    
        public void gameOptionOne()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("          .                                                      .");
            Console.WriteLine("        .n                   .                 .                  n.");
            Console.WriteLine("  .   .dP                  dP                   9b                 9b.    .");
            Console.WriteLine(" 4    qXb         .       dX                     Xb       .        dXp     t");
            Console.WriteLine("dX.    9Xb      .dXb    __                         __    dXb.     dXP     .Xb");
            Console.WriteLine("9XXb._       _.dXXXXb dXXXXbo.                 .odXXXXb dXXXXb._       _.dXXP");
            Console.WriteLine(" 9XXXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP");
            Console.WriteLine("  `9XXXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'");
            Console.WriteLine("    `9XXXXXXXXXXXP' `9XX'   DIE    `98v8P'  HUMAN   `XXP' `9XXXXXXXXXXXP'");
            Console.WriteLine("        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~");
            Console.WriteLine("                        )b.  .dbo.dP'`v'`9b.odb.  .dX(");
            Console.WriteLine("                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb.");
            Console.WriteLine("                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb");
            Console.WriteLine("                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb");
            Console.WriteLine("                    9XXb'   `XXXXXb.dX|Xb.dXXXXX'   `dXXP");
            Console.WriteLine("                     `'      9XXXXXX(   )XXXXXXP      `'");
            Console.WriteLine("                              XXXX X.`v'.X XXXX");
            Console.WriteLine("                              XP^X'`b   d'`X^XX");
            Console.WriteLine("                              X. 9  `   '  P )X");
            Console.WriteLine("                              `b  `       '  d'");
            Console.WriteLine("                               `             '\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("As the light comes back to your eyes you begin to see the world again as you did nearly one thousand years ago when you died. "); 
            Console.WriteLine("Slowly feeling your bones connect again as your vision returns in front of you stands a strange Satyr with long black hair with grey speckles.\nThe strange man begins saying 'You are my greatest accomplishment yet {0}.\nResurrecting you has been quite difficult.' ", charName);
            Console.WriteLine("Unsure of who it is but you sense the gloomy presense and feel the need to run. \nKnowing that the Celestial Gates in Xecren are where you need to go. \n ");
            Console.ReadLine();
            
            while (running)
            {
                int initialSelection;

                Console.Clear();
                Console.WriteLine("With this man and his army of undead surround your east and south sides you have two options to flee to: ");
                Console.WriteLine("1) Run West towards a faint light in the distance.");
                Console.WriteLine("2) Run north into the dense jungle.");

                initialSelection = Convert.ToInt32(Console.ReadLine());

                switch (initialSelection)
                {
                    case 1:
                        Cyme();
                        break;
                    case 2:
                        Jungle();
                        break;
                }
            }
            

        }

        public void Cyme()
        {
            int cymeSelection;

            Console.Clear();
            Console.WriteLine("As you begin approaching the light you notice that it is the village of Cyme in the country Lynnrynn. \n");
            Console.WriteLine("Behind you the undead army is slowly approaching.\n");
            Console.WriteLine("1) Get closer to the village");
            Console.WriteLine("2) Run along the village wall");
            Console.WriteLine("3) Run back into the jungle");
            
            cymeSelection = Convert.ToInt32(Console.ReadLine());

            switch (cymeSelection)
            {
                case 1:
                    cymeSecondary();
                    break;
                case 2:
                    cymeWall();
                case 3:
                    gameOptionOne();
                    break;
            }

            public void cymeSecondary()
            {
                int cymeSecondarySelection();
        
                Console.Clear();
                Console.WriteLine("Nearing the village you stop at the nearest building and listen to the guards talking in the village square and hear them say\n that the infamous Necromancer Mortifer was spotted near the village. \n They go to say that any spotted undead will are to be reported and killed on sight");
                Console.WriteLine("The description of Mortifer matches who resurrected you and is now hunting you.\n");
                Console.WriteLine("With the growing threat on your life you know you have to make your way back to the afterlife.\n");
                Console.WriteLine("1) Remove your armor and enter the village");
                Console.WriteLine("2) Keep your armor on");
                
                cymeSecondarySelection = Convert.ToInt32(Console.ReadLine());
                
                if(cymeSecondarySelection == 1)
                {
                    classArmor = false;
                    isStealthy = true;
                    cymeSecondarySelectionTwo();
                }
                else (){
                    cymeSecondarySelectionTwo();
                }
                public void cymeSecondarySelectionTwo()
                {
                    int cymeSecondarySelectionThree;
                    Console.Clear();
                    Console.WriteLine("As the meeting in the village square is wrapping up guards start walking towards your position. Where do you want to go? \n");
                    Console.WriteLine("1) Sneak behind the house north of you.");
                    Console.WriteLine("2) Walk through the village towards the guards.");
                    Console.WriteLine("3) Sneak into the house you are standing at.");
                    Console.WriteLine("4) Go back.");

                    cymeSecondarySelectionThree = Convert.ToInt32(Console.ReadLine());

                switch (cymeSecondarySelectionThree)
                {
                    case 1: 
                        cymeAlley();
                        break;
                    case 2:
                        villageSquare();
                        break;
                    case 3:
                        cymeHouse();
                        break;
                    case 4:
                        Cyme();
                        break;
                }
                    public void cymeAlley()
                    {
                        int cymeAlleySelection
                        Console.Clear();
                        Console.WriteLine("As you run north along the buildings there is a large alleyway between these two buildings. While running across the alley you trip and two nearby guards begin down the alley. \n");
                        Console.WriteLine("In a hurry you only see a trashpile to hide under or hide behind the corner closest to you.");
                        Console.WriteLine("1) Hide under the trash");
                        Console.WriteLine("2) Hide around the corner");
                        cymeAlleySelection = Convert.ToInt32(Console.ReadLine());

                        switch (cymeAlleySelection)
                        {
                            case 1:
                                cymeAlleyCorner();
                                break;
                            case 2:
                                Console.WriteLine("The guards approach the trash pile and begin to stab into it thinking it was an unwanted rodent. \n In the process they notice you. ");
                                Console.WriteLine("Realizing their discovery of you one guard beheads you quickly.");
                                Console.ReadLine();
                                deathScreen();
                                break;
                        }

                        public void cymeAlleyCorner()
                        {
                            int cymeAlleyCornerSelection;
                    
                            Console.Clear();
                            Console.WriteLine("As the guards walk down the alley they stop at the pile of trash they stab at it with their swords to kill \n what they suspect was a rodent.");
                            Console.WriteLine("After nothing comes out of the trash they leave the alley but are on higher alert. ");
                            Console.WriteLine("Unsure if you should risk staying inside the village walls you can get to the outside of the wall here.")
                            Console.WriteLine("1) Walk outside the village wall");
                            Console.WriteLine("2) Keep running through the alley");
                            Console.WriteLine("3) Go Back");
                            
                            cymeAlleyCornerSelection = Convert.ToInt32(Console.ReadLine());

                            switch (cymeAlleyCornerSelection)
                            {
                                case 1:
                                    cymeWall();
                                    break;
                                case 2:
                                    cymeAlleyExtended();
                                    break;
                                case 3:
                                    cymeSecondarySelectionTwo();
                                    break;
                            }

                                public void cymeAlleyExtended()
                                {
                                    Console.Clear();
                                    Console.WriteLine("As you dart through the alley you run into a guard as they step out in front of you. \n The guard is shocked at first when he realizes you're a skeleton.");
                                    Console.WriteLine("He quickly recovers from his suprise and grabs you to be beheaded in the village square.");
                                    Console.ReadLine();
                                    deathScreen();
                                }
                            
                        }
                        
                    }
                    
                    public void villageSquare()
                    {
                        int villageSquareSelection;
                
                        Console.Clear();        
                        Console.WriteLine("You decide to try and pursuade the guards and tell them of Mortifer's location. You step out into the village square and try to hail the head guard.");
                        Console.WriteLine("As you yell out that you have information of Mortifer the guards all turn and begin to chase you. None of them believe you. ");
                        Console.WriteLine("1) Run out of the village");
                        Console.WriteLine("2) Run into the nearby house");
                        
                        villageSquareSelection = Convert.ToInt32(Console.ReadLine());

                        switch (villageSquareSelection)
                        {
                            case 1:
                                Cyme();
                                break;
                            case 2:
                                cymeHouse();
                                break;
                        }
                    }
                    public void cymeHouse()
                    {
                        int cymeHouseSelection;        

                        Console.Clear();
                        Console.WriteLine("You enter the nearby house and realize it is the alchemy shop. ");
                        Console.WriteLine("The front room is empty, there is a shelf and the counter you might be able to find something on\n");
                        Console.WriteLine("1) Search the shelf");
                        Console.WriteLine("2) Search the counter");
                        Console.WriteLine("3) Run out the back door");
                        
                        cymeHouseSelection = Convert.ToInt32(Console.ReadLine());

                        switch (cymeHouseSelection)
                        {
                            case 1:
                                cymeHouseShelf();
                                break;
                            case 2:
                                cymeHouseCounter();
                                break;
                            case 3:
                                Cyme();
                                break;
                        }
                        public void cymeHouseShelf()
                        {
                            int cymeHouseShelfSelection;
                        
                            Console.Clear();
                            Console.WriteLine("As you quickly search the shelf you find a potion of invisibility. You quickly use it to hide yourself as you finish the guards enter the building.");
                            Console.WriteLine("1) Run upstairs and hide in the bedroom");
                            Console.WriteLine("2) Hide behind the counter in a pile of crates");
                            Console.WriteLine("3) Run out the backdoor");
                            
                            cymeHouseShelfSelection = Convert.ToInt32(Console.ReadLine());

                            switch (cymeHouseShelfSelection)
                            {
                                case 1:
                                    cymeHouseBedroom();
                                    break;
                                case 2:
                                    cymeHouseCounter();
                                    break;
                                case 3:
                                    Cyme();
                                    break;
                            }

                        }

                        public void cymeHouseCounter()
                        {
                            Console.Clear();
                            Console.WriteLine("As you get behind the counter there are no potions but there is a small pile of crates.\nAs you have no time to hide anywhere else you hope the guards don't find you here.");
                            Console.WriteLine("The realization that you will most likely be found sets in and as the guards walk in you accept your fate. \n They approach the counter and quickly notice something is off and find you hiding in the crates. ");
                            Console.ReadLine();
                            deathScreen();
                        }
                        
                        public void cymeHouseBedroom()
                        {
                            Console.Clear();
                            Console.WriteLine("Once you enter the bedroom you quickly jump under the bed and try to conseal yourself as best as you can.\nSoon after you can hear the guards walking up the stairs to the top floor with you.");
                            Console.WriteLine("The guards enter the bedroom, one heads to the closet and the other starts to kneel down to check under the bed. He quickly notices you.\nThey pull you out then bring you outside and behead you");
                            deathScreen();
                        }
                    }
                }
            }

            public void cymeWall()
            {
                int cymeWallSelection;
                Console.Clear();
                Console.WriteLine("As you run north along the wall you soon see the edge of the jungle.\nYou make a break for the clearing and can see the Celestial Gate upon the hill.");
                Console.WriteLine("1) Run to the Celestial Gate to safety");
                Console.WriteLine("2) Go back");
                
                cymeWallSelection = Convert.ToInt32(Console.ReadLine());
                
                switch (cymeWallSelection)
                {
                    case 1:
                        celestialGate();
                        break;
                    case 2
                        Cyme();
                        break;
                }
            }
        }


        public void Jungle()
        {
            int jungleSelection;
            Console.Clear();
            Console.WriteLine("Just ahead of you on the other side of the wall of vines you hear the faint sounds of an adventuring party. \n")
            Console.WriteLine("With the group hunting you behind you need to push forward. How do you want to approach this?");
            Console.WriteLine("1) Attempt to sneak up to the camp");
            Console.WriteLine("2) Go back");

            jungleSelection = Convert.ToInt32(Console.ReadLine());
            switch (jungleSelection)
            {
                case 1:
                    jungleCamp();
                    break;
                case 2:
                    gameOptionOne();
                    break;
            }

            public void jungleCamp()
                {
                    int jungleCampSelection;
                    Console.Clear();
                    Console.WriteLine("As you get closer to the camp you can see that it isn't just some adventuring party.\nIt's another group of undead like the ones hunting you!");
                    Console.WriteLine("1) Turn yourself into the camp");
                    Console.WriteLine("2) Go east around the camp");
                    Console.WriteLine("3) Go west around the camp");
                    Console.WriteLine("4) Go back");

                    jungleCampSelection = Convert.ToInt32(Console.ReadLine());

                    switch (jungleCampSelection)
                    {
                        case 1: 
                            jungleCampExtended();
                            break;
                        case 2:
                            jungleCampEast();
                            break;
                        case 3: 
                            jungleCampWest();
                            break;
                        case 4: 
                            Jungle();
                            break;
                    }
                    
                    public void jungleCampExtended()
                        {
                            Console.Clear();
                            Console.WriteLine("The undead scouting party grabs you and kills you.");
                            Console.ReadLine();
                            deathScreen();
                        }
                    public void jungleCampEast()
                        {
                            int jungleCampEastSelection;
                            Console.Clear();
                            Console.WriteLine("As you start heading east of the camp you approach a large thicket you peer through and see an undead drake laying down. ");
                            Console.WriteLine("1) Run past the drake");
                            Console.WriteLine("2) Run through the camp after waking it");
                            Console.WriteLine("3) Go back");

                            jungleCampEastSelection = Convert.ToInt32(Console.ReadLine());
                            switch (jungleCampEastSelection)
                            {
                                case 1:
                                    jungleCampEastExtended();
                                    break;
                                case 2:
                                    jungleCampDistraction();
                                    break;
                                case 3:
                                    jungleCamp();
                                    break;
                            }

                            public void jungleCampEastExtended()
                                {
                                    Console.Clear();
                                    Console.WriteLine("You break through the thicket and sprint past the undead drake.\nThe drake doesn't react as fast as you manage to go past it.");
                                    Console.WriteLine("As you continue running as far as you can the area starts to look familiar.\nThe edge of the jungleright ahead of you.");
                                    Console.WriteLine("You see the Celestial Gates just up the hill ahead of you. You walk up the hill into the Celestial Gate and return to the afterlife");
                                    Console.ReadLine();
                                    celestialGate();
                                }
                            public void jungleCampDistraction()
                                {
                                    Console.WriteLine("You approach the drake and as carefully as possible you wake it up and taunt it.\nOnce it awakes you sprint through the camp and as the drake chases you it wrecks havok upon the camp.");
                                    Console.WriteLine("After running to safety and enjoying the entertainment of the skeletons skulls being thrown around from the drake stomping and running through\nyou remember you still need to get to the Celestial Gates.");
                                    Console.WriteLine("You return to your journey and begin traversing north through the dense jungle until you approach the jungles edge.");
                                    Console.WriteLine("You see the Celestial Gates just up the hill ahead of you. You walk up the hill into the Celestial Gate and return to the afterlife");
                                    Console.ReadLine();
                                    celestialGate();
                                }
                        }
                    public void jungleCampWest()
                        {
                            Console.WriteLine("Carefully making your way around the west side of the camp.");
                            Console.WriteLine("You continue your journey and begin traversing north through the dense jungle until you approach the jungles edge.");
                            Console.WriteLine("You see the Celestial Gates just up the hill ahead of you. You walk up the hill into the Celestial Gate and return to the afterlife");
                            Console.ReadLine();
                            celestialGate();
                        }
                }
        }



    public void celestialGate()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                         @@##@@@#####@@@##@@");
        Console.WriteLine("                         @    @       @    @");
        Console.WriteLine("                          @@ @         @ @@");
        Console.WriteLine("                            @           @");
        Console.WriteLine("                           @             @");
        Console.WriteLine("                           @             @");
        Console.WriteLine("                           @             @");
        Console.WriteLine("                            @           @");
        Console.WriteLine("                            /@         @\\");
        Console.WriteLine("                          @   @       @   @");
        Console.WriteLine("                       @/    @@@#####@@@   \\@");
        Console.WriteLine("                 /@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\\");
        Console.WriteLine("                /@/                               \\@\\");
        Console.WriteLine("               /@/                                 \\@\\");
        Console.WriteLine("              /@/                                   \\@\\");
        Console.WriteLine("             /@/                                     \\@\\");
        Console.WriteLine("\n                   _   _ _      _                   ");
        Console.WriteLine("                  | | | (_)    | |                  ");
        Console.WriteLine("                  | | | |_  ___| |_ ___  _ __ _   _ ");
        Console.WriteLine("                  | | | | |/ __| __/ _ \\| '__| | | |");
        Console.WriteLine("                  \\ \\_/ / | (__| || (_) | |  | |_| |");
        Console.WriteLine("                   \\___/|_|\\___|\\__\\___/|_|   \\__, |");
        Console.WriteLine("                                               __/ |");
        Console.WriteLine("                                              |___/ \n");
        Console.ReadLine();
        Console.WriteLine("Congratulations {0}, the {1}", charName, classSelection,);
        Console.WriteLine("Armor equipped: {o}", classArmor);
        Console.ReadLine();
        Exit();
    }


    public void deathScreen()
    {
        int deathSelection;    

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("               ...");
        Console.WriteLine("             ;::::;");
        Console.WriteLine("           ;::::; :;");
        Console.WriteLine("         ;:::::'   :;");
        Console.WriteLine("        ;:::::;     ;.");
        Console.WriteLine("       ,:::::'       ;           OOO\\");
        Console.WriteLine("       ::::::;       ;          OOOOO\\");
        Console.WriteLine("       ;:::::;       ;         OOOOOOOO");
        Console.WriteLine("      ,;::::::;     ;'         / OOOOOOO");
        Console.WriteLine("    ;:::::::::`. ,,,;.        /  / DOOOOOO");
        Console.WriteLine("  .';:::::::::::::::::;,     /  /     DOOOO");
        Console.WriteLine(" ,::::::;::::::;;;;::::;,   /  /        DOOO");
        Console.WriteLine(";`::::::`'::::::;;;::::: ,#/  /          DOOO");
        Console.WriteLine(":`:::::::`;::::::;;::: ;::#  /            DOOO");
        Console.WriteLine("::`:::::::`;:::::::: ;::::# /              DOO");
        Console.WriteLine("`:`:::::::`;:::::: ;::::::#/               DOO");
        Console.WriteLine(" :::`:::::::`;; ;:::::::::##                OO");
        Console.WriteLine(" ::::`:::::::`;::::::::;:::#                OO");
        Console.WriteLine(" `:::::`::::::::::::;'`:;::#                O");
        Console.WriteLine("  `:::::`::::::::;' /  / `:#");
        Console.WriteLine("   ::::::`:::::;'  /  /   `#\n");
        Console.WriteLine("__   __           ______ _          _ ");
        Console.WriteLine("\\ \\ / /           |  _  (_)        | |");
        Console.WriteLine(" \\ V /___  _   _  | | | |_  ___  __| |");
        Console.WriteLine("  \\ // _ \\| | | | | | | | |/ _ \\/ _` |");
        Console.WriteLine("  | | (_) | |_| | | |/ /| |  __/ (_| |");
        Console.WriteLine("  \\_/\\___/ \\__,_| |___/ |_|\\___|\\__,_|");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Do you want to restart or Quit?");
        Console.WriteLine("1) Restart");
        Console.WriteLine("1) Quit");
        
        deathSelection = Convert.ToInt32(Console.ReadLine());

        switch (deathSelection)
        {
            case 1: 
                Main();
                break;
            case 2:
                Exit();
                break;
        }
    }
    }
}
