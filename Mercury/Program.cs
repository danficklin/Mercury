using System;

namespace Mercury
{
    public class Program
    {
        public static Player currentPlayer = new Player();
        public static Ship currentShip = new Ship();
        static void Main(string[] args)
        {
            GameComesOpen();
        }
        static void GameComesOpen()
        {

            int origWidth, width;
            int origHeight, height;
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            width = origWidth * (3/2);
            height = origHeight * 2;
            Console.SetWindowSize(width, height);
            Console.WriteLine("                                                  Welcome");
            Console.WriteLine("");
            Console.Beep(80, 1000);
            Console.WriteLine("                                                     to");
            Console.WriteLine("");
            Console.Beep(90, 1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                   MERCURY");
            Console.WriteLine("");
            Console.Beep(100, 1000);
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("       A spacefaring roleplaying game about a starship captain trying to deliver a message across the galaxy");
            Console.WriteLine("");
            Console.WriteLine("                                       Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("What is your character's name?");
            currentPlayer.Name = Console.ReadLine();
            if (currentPlayer.Name == "") { currentPlayer.Name = "Dan"; }
            if (currentPlayer.Name == "Dan")
            {
                Console.WriteLine("You awake in your bunk in the Mercury, an independent starship under your command, and with you as the sole crew member."); Console.WriteLine("");
                Console.WriteLine("You remember that your name is Dan, which is the best name, and it fills you with confidence about your mission."); Console.WriteLine("");
                Console.WriteLine("Press any key to continue..."); Console.WriteLine("");
                Console.ReadKey();
                Console.Clear();
            }
            else 
            {
                Console.WriteLine("You awake in your bunk in the Mercury, and independent starship under you command, and with you as the sole crew member."); Console.WriteLine("");
                Console.WriteLine("You remember that your name is " + currentPlayer.Name+", which is a pretty good name."); Console.WriteLine("");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("You ship has room for plenty of other crew, but you could barely afford to pay for the ship itself, "); Console.WriteLine("");
            Console.WriteLine("let alone hire crew members. You head for the bridge, thinking about your past career..."); Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            CharacterCreate();
        }
        public static void StartMercury()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("'Welcome to the MERCURY, " + currentPlayer.Name + ",'"); 
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("says a sexy, robotic voice from the computer console."); 
            Console.WriteLine("");
            currentShip.maxHealth = 100;
            currentShip.currentHealth = 100;
            currentShip.sizeRating = 2;
            currentShip.baseArmor = 1;
            currentShip.maxShields = 10;
            currentShip.currentShields = 10;
            currentShip.equippedWeapon1 = "light laser cannon";
            currentShip.equippedWeapon2 = "empty";
            currentShip.equippedWeapon3 = "empty";
            currentShip.equippedArmor = "empty";
            currentShip.equippedModule = "empty";
            currentShip.equippedSystem = "empty";
            currentShip.equippedFramework = "empty";
            currentShip.Name = "Mercury";
            Console.WriteLine("Press any key to begin your journey...");
            Console.ReadKey();
            Console.Clear();
            Encounters.OpeningBattle();
        }
        static void CharacterCreate()
        {
            Console.WriteLine("What were you before you purchased the Mercury?");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("(B)urglar");
            Console.WriteLine("(C)olonist");
            Console.WriteLine("(F)reebooter");
            Console.WriteLine("(M)echanic");
            Console.WriteLine("(P)ilot");
            Console.WriteLine("(R)esearcher");
            Console.WriteLine("(S)oldier");
            Console.WriteLine("(T)rader");
            Console.WriteLine("");
            Console.WriteLine("Type the letter or name of your character's background and press enter.");
            Console.WriteLine("");
            Console.WriteLine("Type help for more information, or help m for more information about the Mechanic etc. ");
            string input = Console.ReadLine();
            if (input.ToLower() == "help" || input.ToLower() == "h") Help();
            else if (input.ToLower() == "help b" || input.ToLower() == "help burglar") BurglarInfo();
            else if (input.ToLower() == "help c" || input.ToLower() == "help colonist") ColonistInfo();
            else if (input.ToLower() == "help f" || input.ToLower() == "help freebooter") FreebooterInfo();
            else if (input.ToLower() == "help m" || input.ToLower() == "help mechanic") MechanicInfo();
            else if (input.ToLower() == "help p" || input.ToLower() == "help pilot") PilotInfo();
            else if (input.ToLower() == "help s" || input.ToLower() == "help soldier") SoldierInfo();
            else if (input.ToLower() == "help t" || input.ToLower() == "help trader") TraderInfo();
            else if (input.ToLower() == "b" || input.ToLower() == "burglar") BurglarCreate();
            else if (input.ToLower() == "c" || input.ToLower() == "colonist") ColonistCreate();
            else if (input.ToLower() == "f" || input.ToLower() == "freebooter") FreebooterCreate();
            else if (input.ToLower() == "m" || input.ToLower() == "mechanic") MechanicCreate();
            else if (input.ToLower() == "p" || input.ToLower() == "pilot") PilotCreate();
            else if (input.ToLower() == "s" || input.ToLower() == "soldier") SoldierCreate();
            else if (input.ToLower() == "t" || input.ToLower() == "trader") TraderCreate();
            else 
            {
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey();
                Console.Clear();
                CharacterCreate();
            }

            static void Help()
            {
                Console.WriteLine("More here later. Press any key to return to character creation...");
                Console.ReadKey();
                Console.Clear();
                CharacterCreate();
            }

            static void BurglarInfo()
        {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                              THE BURGLAR ");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.WriteLine("You were orphaned at a young age, and you grew up mostly on the streets.");
                Console.WriteLine(" ");
                Console.WriteLine(" You learned to steal first to feed yourself, and only later became a professional. ");
                Console.WriteLine(" ");
                Console.WriteLine("You became such a good burglar, hacker, and thief that you were able to afford the Mercury. ");
                Console.WriteLine(" ");
                Console.WriteLine("                    Your statistics are as follows: ");
                Console.WriteLine(" ");
                Console.WriteLine("                 =======================================");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                || Health- 12/12     Armor Class- 15  ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                || Str 0             Int 2            ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                || Dex 4             Wis -1           ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                || Con 1             Cha 3            ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                || Skills: Athletics 1, Computers 1,  ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                || Intrigue 3, Karate 1, Guns 1,      ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                || Melee 1, Perception 1              ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                 =======================================");
                Console.WriteLine(" ");
                Console.WriteLine("              Inventory: lasknife, leather jacket, lockpicks");
                Console.WriteLine("                            Credits: 22");
                Console.ReadKey();
                Console.WriteLine(" ");
                Console.WriteLine("             Press any key to return to what you were doing...");
                Console.ReadKey();
                Console.Clear();
                CharacterCreate();
            }
        }
        static void ColonistInfo()
        {
            Console.WriteLine("More here later. Press any key to return to what you were doing...");
            Console.ReadKey();
            Console.Clear();
            CharacterCreate();
        }
        static void FreebooterInfo()
        {
            Console.WriteLine("More here later. Press any key to return to what you were doing...");
            Console.ReadKey();
            Console.Clear();
            CharacterCreate();
        }
        static void MechanicInfo()
        {
            Console.WriteLine("More here later. Press any key to return to what you were doing...");
            Console.ReadKey();
            Console.Clear();
            CharacterCreate();
        }
        static void PilotInfo()
        {
            Console.WriteLine("More here later. Press any key to return to what you were doing...");
            Console.ReadKey();
            Console.Clear();
            CharacterCreate();
        }
        static void ResearcherInfo()
        {
            Console.WriteLine("More here later. Press any key to return to what you were doing...");
            Console.ReadKey();
            Console.Clear();
            CharacterCreate();
        }
        static void SoldierInfo()
        {
            Console.WriteLine("More here later. Press any key to return to what you were doing...");
            Console.ReadKey();
            Console.Clear();
            CharacterCreate();
        }
        static void TraderInfo()
        {
            Console.WriteLine("More here later. Press any key to return to what you were doing...");
            Console.ReadKey();
            Console.Clear();
            CharacterCreate();
        }
        static void BurglarCreate()
        {
            currentPlayer.Strength = 0;
            currentPlayer.Dexterity = 4;
            currentPlayer.Constitution = 1;
            currentPlayer.Intelligence = 2;
            currentPlayer.Wisdom = -1;
            currentPlayer.Charisma = 3;
            currentPlayer.maxHealth = 12;
            currentPlayer.currentHealth = 12;
            currentPlayer.Attack = 0;
            currentPlayer.Athletics = 1;
            currentPlayer.Computers = 1;
            currentPlayer.Intrigue = 3;
            currentPlayer.Karate = 1;
            currentPlayer.Guns = 1;
            currentPlayer.Melee = 1;
            currentPlayer.Perception = 1;
            currentPlayer.equippedArmor = "leather";
            currentPlayer.equippedWeapon = "lasknife";
            currentPlayer.equippedTrinket = "lockpick";
            currentPlayer.armorBonus = 1;
            currentPlayer.armorClass = 10 + currentPlayer.Dexterity + currentPlayer.armorBonus;
            currentPlayer.experiencePoints = 0;
            currentPlayer.Credits = 22;
            currentPlayer.Background = "Burglar";
            currentPlayer.Description1 = "You were orphaned at a young age, and you grew up mostly on the streets.";
            currentPlayer.Description2 = "You learned to steal first to feed yourself, and only later became a professional.";
            currentPlayer.Description3 = "You became such a good burglar, hacker, and thief that you were able to afford the Mercury.";
            Console.Clear();
            StartMercury();
        }
        static void ColonistCreate()
        {
            Console.Clear();
            StartMercury();
        }
        static void FreebooterCreate()
        {
            Console.Clear();
            StartMercury();
        }
        static void MechanicCreate()
        {
            Console.Clear();
            StartMercury();
        }
        static void PilotCreate()
        {
            Console.Clear();
            StartMercury();
        }
        static void ResearcherCreate()
        {
            Console.Clear();
            StartMercury();
        }
        static void SoldierCreate()
        {
            Console.Clear();
            StartMercury();
        }
        static void TraderCreate()
        {
            Console.Clear();
            StartMercury();
        }
    }
}
