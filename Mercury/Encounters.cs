using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
    public class Encounters
    {
        static Random rnd = new Random();

        public static void OpeningBattle()
        {
            Console.WriteLine("                                       Klaxons blare and lights flash!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("");
            Console.Beep(100, 1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                                  RED ALERT!");
            Console.WriteLine("");
            Console.WriteLine("                                        Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("               'Captain, the Mercury is under attack! A small pirate fighter off the port bow.,' ");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("                                        says the computer's voice.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                          'Shields up, weapon systems online. Awaiting your orders.'");
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                     Press any key to begin combat...");
            Console.ReadKey();
            Console.Clear();
            ShipCombat(false, "Pirate Fighter", 0, 0, 0, 25, 25, 0, 0, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "flak gun", "empty", "empty", "empty", "empty", "empty", "empty", 1000);
        }
        // Encounters

        // Tools

        public static void ShipCombat(bool random, string name, int pilotdex, int piloting, int size, int maxhealth, int curhealth, int basearmor, int armorbonus, int armorclass, int maxshields, int curshields, int w1attack, int w1attackbonus, int w1damagemutiplier, int w2attack, int w2attackbonus, int w2damagemutiplier, int w3attack, int w3attackbonus, int w3damagemutiplier, string weapon1, string weapon2, string weapon3, string armor, string modules, string system, string framework, int price)
        {
            
            // Enemy Ship
            string n = ""; // Name
            int siz = 1; // Size
            int mxh = 25; // Max Health
            int crh = 25; // Current Health
            int bar = 0; // Base Armor (inherent to ship)
            int pd = 0; // Pilot dexterity
            int pil = 0; // Pilot piloting skill
            string iarm = "empty"; // Installed armor module
            int arb = 0; // Armor bonus (from ship enhancement)

            if (iarm == "empty") { arb = 0; }
            if (iarm == "ArmorMk1") { arb = 1; }
            if (iarm == "ArmorMk2") { arb = 2; }
            if (iarm == "ArmorMk3") { arb = 3; }
            if (iarm == "ArmorMk4") { arb = 4; }
            if (iarm == "ArmorMk5") { arb = 5; }
            if (iarm == "ArmorMk6") { arb = 6; }
            if (iarm == "ArmorMk7") { arb = 7; }
            if (iarm == "ArmorMk8") { arb = 8; }
            
            int ac = 10 + bar + arb + pd + pil - siz; // Armor Class (10 + base armor + armor bonus + pilot dex - size)
            int mxs = 0; // Max Shields
            int crs = 0; // Current Shields
            // Weapon 1
            int w1atb = 0;
            int w1atk = siz + pd + w1atb ;
            int w1dmx = 0;
            int w1dmg = w1dmx + siz;
            // Weapon 2
            int w2atb = 0;
            int w2atk = siz + pd + w2atb;
            int w2dmx = 0;
            int w2dmg = w2dmx + siz;
            // Weapon 3
            int w3atb = 0;
            int w3atk = siz + pd + w3atb;
            int w3dmx = 0;
            int w3dmg = w3dmx + siz;
            // Equipped Weapons
            string w1 = "flak gun";
            string w2 = "empty";
            string w3 = "empty";
            // Equipped ship enhancements
            string arm;
            string mod;
            string sys;
            string fme;

            int pri; // Price

            // Player Ship

            int parm = 0;
            if (Program.currentShip.equippedArmor == "empty") { parm = 0; }
            if (Program.currentShip.equippedArmor == "ArmorMk1") { parm = 1; }
            if (Program.currentShip.equippedArmor == "ArmorMk2") { parm = 2; }
            if (Program.currentShip.equippedArmor == "ArmorMk3") { parm = 3; }
            if (Program.currentShip.equippedArmor == "ArmorMk4") { parm = 4; }
            if (Program.currentShip.equippedArmor == "ArmorMk5") { parm = 5; }
            if (Program.currentShip.equippedArmor == "ArmorMk6") { parm = 6; }
            if (Program.currentShip.equippedArmor == "ArmorMk7") { parm = 7; }
            if (Program.currentShip.equippedArmor == "ArmorMk8") { parm = 8; }
            Program.currentShip.armorClass = 10 + Program.currentPlayer.Dexterity + Program.currentPlayer.Piloting + Program.currentShip.baseArmor + parm - Program.currentShip.sizeRating;

            //Weapon 1
            int w1pdmx = 0;
            int w1pab = 0;
            int w1patk = Program.currentPlayer.Dexterity + Program.currentShip.sizeRating + w1pab;
            int w1pdmg = Program.currentShip.sizeRating + w1pdmx;
            //Weapon 2
            int w2pdmx = 0;
            int w2pab = 0;
            int w2patk = Program.currentPlayer.Dexterity + Program.currentShip.sizeRating + w2pab;
            int w2pdmg = Program.currentShip.sizeRating + w2pdmx;
            //Weapon 3
            int w3pdmx = 0;
            int w3pab = 0;
            int w3patk = Program.currentPlayer.Dexterity + Program.currentShip.sizeRating + w3pab;
            int w3pdmg = Program.currentShip.sizeRating + w3pdmx;

            if (random == true)
            {
                
            }
            else
            {
                n = name; siz = size; mxh = maxhealth; crh = curhealth; bar = basearmor; ac = armorclass; arb = armorbonus; mxs = maxshields; crs = curshields; pd = pilotdex; pil = piloting; w1atk = w1attack; w1atb = w1attackbonus; w1dmx = w1damagemutiplier; w2atk = w2attack; w2atb = w2attackbonus; w2dmx = w2damagemutiplier; w3atk = w3attack; w3atb = w3attackbonus; w3dmx = w3damagemutiplier; w1 = weapon1; w2 = weapon2; w3 = weapon3; arm = armor; mod = modules; sys = system; fme = framework; pri = price; iarm = armor ;
            }
            while(crh > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                              SPACE BATTLE ");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("                The "+Program.currentShip.Name+" versus "+name+"");
                Console.WriteLine("");
                Console.WriteLine("                           Enemy Health "+crh+"/"+mxh+" ");
                Console.WriteLine("                 =======================================");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                ||            Full (A)ttack           ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                ||          (E)vasive Maneuvers       ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                ||          (R)echarge Shields        ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                ||           (F)lee the battle        ||");
                Console.WriteLine("                ||                                    ||");
                Console.WriteLine("                 =======================================");
                Console.WriteLine("             Health: "+Program.currentShip.currentHealth+" / "+Program.currentShip.maxHealth+ "    Shields: "+Program.currentShip.currentShields+ " / " +Program.currentShip.currentShields+ "");
                Console.WriteLine("");

                string input = Console.ReadLine();
                
                if (input.ToLower() == "e" || input.ToLower() == "evasive" || input.ToLower() == "evasive maneuvers")
                {
                    // evasive maneuvers
                    Console.WriteLine("" + Program.currentShip + " takes evasion maneuvers against " + name + " while still firing off a shot with its primary gun, and the enemy ship fires back in response."); Console.WriteLine("");
                    bool enemyhit1 = false;
                    bool enemyhit2 = false;
                    bool enemyhit3 = false;
                    bool playerhit1 = false;
                    int enemydmg1 = 0;
                    int enemydmg2 = 0;
                    int enemydmg3 = 0;
                    int playerdmg1 = 0;

                    if (w1 == "empty") w1atb = 0; w1dmx = -1;
                    if (w1 == "flak gun") w1atb = 0; w1dmx = 3;
                    if (w1 == "light laser cannon") w1atb = 1; w1dmx = 5;
                    if (w1 == "beam cannon") w1atb = 1; w1dmx = 7;
                    if (w1 == "gun4") w1atb = 3; w1dmx = 7;
                    if (w1 == "gun5") w1atb = 4; w1dmx = 8;
                    if (w1 == "gun6") w1atb = 1; w1dmx = 8;
                    if (w1 == "gun7") w1atb = 2; w1dmx = 7;
                    if (w1 == "gun8") w1atb = 3; w1dmx = 2;
                    if (w1 == "gun9") w1atb = 4; w1dmx = 3;

                    if (w1dmx < 0) w1dmg = 0;

                    int enemyAttack1 = rnd.Next(1, 21) + w1atk;
                    if (enemyAttack1 >= Program.currentShip.armorClass + 5) 
                    { 
                        enemyhit1 = true;
                        if (enemyhit1 == true)
                        {
                            enemydmg1 = rnd.Next(1, 7) * w1dmg;
                            if (enemydmg1 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w1 + " dealing " + enemydmg1 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }
                    
                    
                    if (w2 == "empty") w2atb = 0; w2dmx = -1;
                    if (w2 == "flak gun") w2atb = 0; w2dmx = 3;
                    if (w2 == "light laser cannon") w2atb = 1; w2dmx = 5;
                    if (w2 == "beam cannon") w2atb = 1; w2dmx = 7;
                    if (w2 == "gun4") w2atb = 3; w2dmx = 7;
                    if (w2 == "gun5") w2atb = 4; w2dmx = 8;
                    if (w2 == "gun6") w2atb = 1; w2dmx = 8;
                    if (w2 == "gun7") w2atb = 2; w2dmx = 7;
                    if (w2 == "gun8") w2atb = 3; w2dmx = 2;
                    if (w2 == "gun9") w2atb = 4; w2dmx = 3;

                    if (w2dmx < 0) w2dmg = 0;

                    int enemyAttack2 = rnd.Next(1, 21) + w2atk;
                    if (enemyAttack2 >= Program.currentShip.armorClass + 5) 
                    { 
                        enemyhit2 = true;
                        if (enemyhit2 == true)
                        {
                            enemydmg2 = rnd.Next(1, 7) * w2dmg;
                            if (enemydmg2 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w2 + " dealing " + enemydmg2 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }

                    if (w3 == "empty") w3atb = 0; w3dmx = -1;
                    if (w3 == "flak gun") w3atb = 0; w3dmx = 3;
                    if (w3 == "light laser cannon") w3atb = 1; w3dmx = 5;
                    if (w3 == "beam cannon") w3atb = 1; w3dmx = 7;
                    if (w3 == "gun4") w3atb = 3; w3dmx = 7;
                    if (w3 == "gun5") w3atb = 4; w3dmx = 8;
                    if (w3 == "gun6") w3atb = 1; w3dmx = 8;
                    if (w3 == "gun7") w3atb = 2; w3dmx = 7;
                    if (w3 == "gun8") w3atb = 3; w3dmx = 2;
                    if (w3 == "gun9") w3atb = 4; w3dmx = 3;

                    if (w3dmx < 0) w3dmg = 0;

                    int enemyAttack3 = rnd.Next(1, 21) + w3atk;
                    if (enemyAttack3 >= Program.currentShip.armorClass + 5) 
                    { 
                        enemyhit3 = true;
                        if (enemyhit3 == true)
                        {
                            enemydmg3 = rnd.Next(1, 7) * w3dmg;
                            if (enemydmg3 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w3 + " dealing " + enemydmg3 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }

                    if (Program.currentShip.equippedWeapon1 == "empty") w1pab = 0; w1pdmx = 0;
                    if (Program.currentShip.equippedWeapon1 == "flak gun") w1pab = 0; w1pdmx = 3;
                    if (Program.currentShip.equippedWeapon1 == "light laser cannon") w1pab = 1; w1pdmx = 5;
                    if (Program.currentShip.equippedWeapon1 == "beam cannon") w1pab = 1; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun4") w1pab = 3; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun5") w1pab = 4; w1pdmx = 8;
                    if (Program.currentShip.equippedWeapon1 == "gun6") w1pab = 1; w1pdmx = 8;
                    if (Program.currentShip.equippedWeapon1 == "gun7") w1pab = 2; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun8") w1pab = 3; w1pdmx = 2;
                    if (Program.currentShip.equippedWeapon1 == "gun9") w1pab = 4; w1pdmx = 3;

                    if (w1pdmx < 0) w1pdmg = 0;

                    int playerAttack1 = rnd.Next(1, 21) + w1patk;
                    if (playerAttack1 >= ac) 
                    { 
                        playerhit1 = true;
                        if (playerhit1 == true)
                        {
                            playerdmg1 = rnd.Next(1, 7) * w1pdmg;
                        }
                        if (playerdmg1 > 0)
                        {
                            Console.WriteLine("The " + Program.currentShip.Name + " scores a hit with its " + Program.currentShip.equippedWeapon1 + " dealing " + playerdmg1 + " damage to the enemy vessel."); Console.WriteLine("");
                        }
                    }
                    int enemytotaldamage = enemydmg1 + enemydmg2 + enemydmg3;
                    int playertotaldamage = playerdmg1;

                    // Enemy ship deals damage, first to shields, then to health
                    if (Program.currentShip.currentShields > 0)
                    {
                        Program.currentShip.currentShields -= enemytotaldamage;
                        if (Program.currentShip.currentShields < 0)
                        {
                            Program.currentShip.currentHealth += Program.currentShip.currentShields;
                            Program.currentShip.currentShields = 0;
                        }
                    }
                    else Program.currentShip.currentHealth -= enemytotaldamage;
                    if (enemytotaldamage > 0)
                    {
                        Console.WriteLine("The enemy ship deals a total of " + enemytotaldamage + " damage to the " + Program.currentShip.Name + " this turn."); Console.WriteLine("");
                    }
                    else Console.WriteLine("The enemy ship did not deal any damage to the " + Program.currentShip.Name + " this turn."); Console.WriteLine("");

                    // Player ship deals damage, first to shields, then to health

                    if (crs > 0)
                    {
                        crs -= playertotaldamage;
                        if (crs < 0)
                        {
                            crh += crs;
                            crs = 0;
                        }
                    }
                    else crh -= playertotaldamage;
                    if (playertotaldamage > 0)
                    {
                        Console.WriteLine("The " + Program.currentShip.Name + " deals a total " + playertotaldamage + " damage to the enemy vessel this turn."); Console.WriteLine("");
                    }
                    else Console.WriteLine("The " + Program.currentShip.Name + " did not manage to deal any damage to the enemy ship this turn."); Console.WriteLine("");

                }
                else if (input.ToLower() == "r" || input.ToLower() == "recharge" || input.ToLower() == "recharge shields")
                {
                    // recharge shields
                    Console.WriteLine("" + Program.currentShip + " recharges its shields while still firing off a shot with its primary gun against" + name + ", and the enemy ship fires back in response.");
                    Console.WriteLine("");

                    // Shields recharge
                    int recharge = (Program.currentShip.maxShields / 2) + (Program.currentPlayer.Computers * 5);
                    Program.currentShip.currentShields += recharge;
                    if (Program.currentShip.currentShields > Program.currentShip.maxShields) Program.currentShip.currentShields = Program.currentShip.maxShields;

                    Console.WriteLine("" + Program.currentShip + " recharges its shields for "+recharge+" points.");
                    Console.WriteLine("");

                    bool enemyhit1 = false;
                    bool enemyhit2 = false;
                    bool enemyhit3 = false;
                    bool playerhit1 = false;
                    int enemydmg1 = 0;
                    int enemydmg2 = 0;
                    int enemydmg3 = 0;
                    int playerdmg1 = 0;

                    if (w1 == "empty") w1atb = 0; w1dmx = -1;
                    if (w1 == "flak gun") w1atb = 0; w1dmx = 3;
                    if (w1 == "light laser cannon") w1atb = 1; w1dmx = 5;
                    if (w1 == "beam cannon") w1atb = 1; w1dmx = 7;
                    if (w1 == "gun4") w1atb = 3; w1dmx = 7;
                    if (w1 == "gun5") w1atb = 4; w1dmx = 8;
                    if (w1 == "gun6") w1atb = 1; w1dmx = 8;
                    if (w1 == "gun7") w1atb = 2; w1dmx = 7;
                    if (w1 == "gun8") w1atb = 3; w1dmx = 2;
                    if (w1 == "gun9") w1atb = 4; w1dmx = 3;

                    if (w1dmx < 0) w1dmg = 0;

                    int enemyAttack1 = rnd.Next(1, 21) + w1atk;
                    if (enemyAttack1 >= Program.currentShip.armorClass) 
                    { 
                        enemyhit1 = true;
                        if (enemyhit1 == true)
                        {
                            enemydmg1 = rnd.Next(1, 7) * w1dmg;
                            if (enemydmg1 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w1 + " dealing " + enemydmg1 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }

                    if (w2 == "empty") w2atb = 0; w2dmx = -1;
                    if (w2 == "flak gun") w2atb = 0; w2dmx = 3;
                    if (w2 == "light laser cannon") w2atb = 1; w2dmx = 5;
                    if (w2 == "beam cannon") w2atb = 1; w2dmx = 7;
                    if (w2 == "gun4") w2atb = 3; w2dmx = 7;
                    if (w2 == "gun5") w2atb = 4; w2dmx = 8;
                    if (w2 == "gun6") w2atb = 1; w2dmx = 8;
                    if (w2 == "gun7") w2atb = 2; w2dmx = 7;
                    if (w2 == "gun8") w2atb = 3; w2dmx = 2;
                    if (w2 == "gun9") w2atb = 4; w2dmx = 3;

                    if (w2dmx < 0) w2dmg = 0;

                    int enemyAttack2 = rnd.Next(1, 21) + w2atk;
                    if (enemyAttack2 >= Program.currentShip.armorClass) 
                    { 
                        enemyhit2 = true;
                        if (enemyhit2 == true)
                        {
                            enemydmg2 = rnd.Next(1, 7) * w2dmg;
                            if (enemydmg2 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w2 + " dealing " + enemydmg2 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }

                        }
                    }

                    if (w3 == "empty") w3atb = 0; w3dmx = -1;
                    if (w3 == "flak gun") w3atb = 0; w3dmx = 3;
                    if (w3 == "light laser cannon") w3atb = 1; w3dmx = 5;
                    if (w3 == "beam cannon") w3atb = 1; w3dmx = 7;
                    if (w3 == "gun4") w3atb = 3; w3dmx = 7;
                    if (w3 == "gun5") w3atb = 4; w3dmx = 8;
                    if (w3 == "gun6") w3atb = 1; w3dmx = 8;
                    if (w3 == "gun7") w3atb = 2; w3dmx = 7;
                    if (w3 == "gun8") w3atb = 3; w3dmx = 2;
                    if (w3 == "gun9") w3atb = 4; w3dmx = 3;

                    if (w3dmx < 0) w3dmg = 0;

                    int enemyAttack3 = rnd.Next(1, 21) + w3atk;
                    if (enemyAttack3 >= Program.currentShip.armorClass) 
                    { 
                        enemyhit3 = true;
                        if (enemyhit3 == true)
                        {
                            enemydmg3 = rnd.Next(1, 7) * w3dmg;
                            if (enemydmg3 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w3 + " dealing " + enemydmg3 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }

                    if (Program.currentShip.equippedWeapon1 == "empty") w1pab = 0; w1pdmx = 0;
                    if (Program.currentShip.equippedWeapon1 == "flak gun") w1pab = 0; w1pdmx = 3;
                    if (Program.currentShip.equippedWeapon1 == "light laser cannon") w1pab = 1; w1pdmx = 5;
                    if (Program.currentShip.equippedWeapon1 == "beam cannon") w1pab = 1; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun4") w1pab = 3; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun5") w1pab = 4; w1pdmx = 8;
                    if (Program.currentShip.equippedWeapon1 == "gun6") w1pab = 1; w1pdmx = 8;
                    if (Program.currentShip.equippedWeapon1 == "gun7") w1pab = 2; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun8") w1pab = 3; w1pdmx = 2;
                    if (Program.currentShip.equippedWeapon1 == "gun9") w1pab = 4; w1pdmx = 3;

                    if (w1pdmx < 0) w1pdmg = 0;

                    int playerAttack1 = rnd.Next(1, 21) + w1patk;
                    if (playerAttack1 >= ac) 
                    { 
                        playerhit1 = true;
                        if (playerhit1 == true)
                        {
                            playerdmg1 = rnd.Next(1, 7) * w1pdmg;
                            if (playerdmg1 > 0)
                            {
                                Console.WriteLine("The " + Program.currentShip.Name + " scores a hit with its " + Program.currentShip.equippedWeapon1 + " dealing " + playerdmg1 + " damage to the enemy vessel."); Console.WriteLine("");
                            }
                        }
                    }

                    int enemytotaldamage = enemydmg1 + enemydmg2 + enemydmg3;
                    int playertotaldamage = playerdmg1;
                    // Enemy ship deals damage, first to shields, then to health
                    if (Program.currentShip.currentShields > 0)
                    {
                        Program.currentShip.currentShields -= enemytotaldamage;
                        if (Program.currentShip.currentShields < 0)
                        {
                            Program.currentShip.currentHealth += Program.currentShip.currentShields;
                            Program.currentShip.currentShields = 0;
                        }
                    }
                    else Program.currentShip.currentHealth -= enemytotaldamage;
                    if (enemytotaldamage > 0)
                    {
                        Console.WriteLine("The enemy ship deals a total of " + enemytotaldamage + " damage to the " + Program.currentShip.Name + " this turn."); Console.WriteLine("");
                    }
                    else Console.WriteLine("The enemy ship did not deal any damage to the " + Program.currentShip.Name + " this turn."); Console.WriteLine("");

                    // Player ship deals damage, first to shields, then to health

                    if (crs > 0)
                    {
                        crs -= playertotaldamage;
                        if (crs < 0)
                        {
                            crh += crs;
                            crs = 0;
                        }
                    }
                    else crh -= playertotaldamage;
                    if (playertotaldamage > 0)
                    {
                        Console.WriteLine("The " + Program.currentShip.Name + " deals a total " + playertotaldamage + " damage to the enemy vessel this turn."); Console.WriteLine("");
                    }
                    else Console.WriteLine("The " + Program.currentShip.Name + " did not manage to deal any damage to the enemy ship this turn."); Console.WriteLine("");
                }
                else if (input.ToLower() == "f" || input.ToLower() == "flee" || input.ToLower() == "flee the battle")
                {
                    // flee the battle
                    Console.WriteLine("The " + Program.currentShip.Name + " flees the battlefield, as the enemy ship takes a potshot."); Console.WriteLine("");
                    bool enemyhit1 = false;
                    int enemydmg1 = 0;

                    if (w1 == "empty") w1atb = 0; w1dmx = -1;
                    if (w1 == "flak gun") w1atb = 0; w1dmx = 3;
                    if (w1 == "light laser cannon") w1atb = 1; w1dmx = 5;
                    if (w1 == "beam cannon") w1atb = 1; w1dmx = 7;
                    if (w1 == "gun4") w1atb = 3; w1dmx = 7;
                    if (w1 == "gun5") w1atb = 4; w1dmx = 8;
                    if (w1 == "gun6") w1atb = 1; w1dmx = 8;
                    if (w1 == "gun7") w1atb = 2; w1dmx = 7;
                    if (w1 == "gun8") w1atb = 3; w1dmx = 2;
                    if (w1 == "gun9") w1atb = 4; w1dmx = 3;

                    if (w1dmx < 0) w1dmg = 0;

                    int enemyAttack1 = rnd.Next(1, 21) + w1atk;
                    if (enemyAttack1 >= Program.currentShip.armorClass) 
                    { 
                        enemyhit1 = true;
                        if (enemyhit1 == true)
                        {
                            enemydmg1 = rnd.Next(1, 7) * w1dmg;
                            if (enemydmg1 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w1 + " dealing " + enemydmg1 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }

                    int enemytotaldamage = enemydmg1;

                    // Enemy ship deals damage, first to shields, then to health
                    if (Program.currentShip.currentShields > 0)
                    {
                        Program.currentShip.currentShields -= enemytotaldamage;
                        if (Program.currentShip.currentShields < 0)
                        {
                            Program.currentShip.currentHealth += Program.currentShip.currentShields;
                            Program.currentShip.currentShields = 0;
                        }
                    }
                    else Program.currentShip.currentHealth -= enemytotaldamage;
                    if (enemytotaldamage > 0)
                    {
                        Console.WriteLine("The enemy ship deals a total of " + enemytotaldamage + " damage to the " + Program.currentShip.Name + " this turn as it flees."); Console.WriteLine("");
                    }
                    else Console.WriteLine("The enemy ship did not deal any damage to the " + Program.currentShip.Name + " this turn as it flees.");
                    Console.WriteLine("Your ship successfully escapes the battle!"); Console.WriteLine("");
                    Console.ReadKey();
                    // Go to somewhere

                }
                else
                {
                    // full attack
                    Console.WriteLine("" + Program.currentShip + " opens fire on the approaching " + name + " with all guns, and the enemy ship fires back in response."); Console.WriteLine("");
                    bool enemyhit1 = false;
                    bool enemyhit2 = false;
                    bool enemyhit3 = false;
                    bool playerhit1 = false;
                    bool playerhit2 = false;
                    bool playerhit3 = false;
                    int enemydmg1 = 0;
                    int enemydmg2 = 0;
                    int enemydmg3 = 0;
                    int playerdmg1 = 0;
                    int playerdmg2 = 0;
                    int playerdmg3 = 0;


                    if (w1 == "empty") w1atb = 0; w1dmx = -1;
                    if (w1 == "flak gun") w1atb = 0; w1dmx = 3;
                    if (w1 == "light laser cannon") w1atb = 1; w1dmx = 5 ;
                    if (w1 == "beam cannon") w1atb = 1; w1dmx = 7 ;
                    if (w1 == "gun4") w1atb = 3; w1dmx = 7;
                    if (w1 == "gun5") w1atb = 4; w1dmx = 8;
                    if (w1 == "gun6") w1atb = 1; w1dmx = 8;
                    if (w1 == "gun7") w1atb = 2; w1dmx = 7;
                    if (w1 == "gun8") w1atb = 3; w1dmx = 2;
                    if (w1 == "gun9") w1atb = 4; w1dmx = 3;

                    if (w1dmx < 0) w1dmg = 0;

                    int enemyAttack1 = rnd.Next(1, 21) + w1atk;
                    if (enemyAttack1 >= Program.currentShip.armorClass) 
                    { 
                        enemyhit1 = true;
                        if (enemyhit1 == true)
                        {
                            enemydmg1 = rnd.Next(1, 7) * w1dmg;
                            if (enemydmg1 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w1 + " dealing " + enemydmg1 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }

                    if (w2 == "empty") w2atb = 0; w2dmx = -1;
                    if (w2 == "flak gun") w2atb = 0; w2dmx = 3;
                    if (w2 == "light laser cannon") w2atb = 1; w2dmx = 5;
                    if (w2 == "beam cannon") w2atb = 1; w2dmx = 7;
                    if (w2 == "gun4") w2atb = 3; w2dmx = 7;
                    if (w2 == "gun5") w2atb = 4; w2dmx = 8;
                    if (w2 == "gun6") w2atb = 1; w2dmx = 8;
                    if (w2 == "gun7") w2atb = 2; w2dmx = 7;
                    if (w2 == "gun8") w2atb = 3; w2dmx = 2;
                    if (w2 == "gun9") w2atb = 4; w2dmx = 3;

                    if (w2dmx < 0) w2dmg = 0;

                    int enemyAttack2 = rnd.Next(1, 21) + w2atk;
                    if (enemyAttack2 >= Program.currentShip.armorClass) 
                    { 
                        enemyhit2 = true;
                        if (enemyhit2 == true)
                        {
                            enemydmg2 = rnd.Next(1, 7) * w2dmg;
                            if (enemydmg2 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w2 + " dealing " + enemydmg2 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }
  
                    if (w3 == "empty") w3atb = 0; w3dmx = -1;
                    if (w3 == "flak gun") w3atb = 0; w3dmx = 3;
                    if (w3 == "light laser cannon") w3atb = 1; w3dmx = 5;
                    if (w3 == "beam cannon") w3atb = 1; w3dmx = 7;
                    if (w3 == "gun4") w3atb = 3; w3dmx = 7;
                    if (w3 == "gun5") w3atb = 4; w3dmx = 8;
                    if (w3 == "gun6") w3atb = 1; w3dmx = 8;
                    if (w3 == "gun7") w3atb = 2; w3dmx = 7;
                    if (w3 == "gun8") w3atb = 3; w3dmx = 2;
                    if (w3 == "gun9") w3atb = 4; w3dmx = 3;

                    if (w3dmx < 0) w3dmg = 0;

                    int enemyAttack3 = rnd.Next(1, 21) + w3atk;
                    if (enemyAttack3 >= Program.currentShip.armorClass) 
                    { 
                        enemyhit3 = true;
                        if (enemyhit3 == true)
                        {
                            enemydmg3 = rnd.Next(1, 7) * w3dmg;
                            if (enemydmg3 > 0)
                            {
                                Console.WriteLine("The enemy ship scores a hit with its " + w3 + " dealing " + enemydmg3 + " damage to the " + Program.currentShip.Name + "."); Console.WriteLine("");
                            }
                        }
                    }

                    if (Program.currentShip.equippedWeapon1 == "empty") w1pab = 0; w1pdmx = -1;
                    if (Program.currentShip.equippedWeapon1 == "flak gun") w1pab = 0; w1pdmx = 3;
                    if (Program.currentShip.equippedWeapon1 == "light laser cannon") w1pab = 1; w1pdmx = 5;
                    if (Program.currentShip.equippedWeapon1 == "beam cannon") w1pab = 1; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun4") w1pab = 3; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun5") w1pab = 4; w1pdmx = 8;
                    if (Program.currentShip.equippedWeapon1 == "gun6") w1pab = 1; w1pdmx = 8;
                    if (Program.currentShip.equippedWeapon1 == "gun7") w1pab = 2; w1pdmx = 7;
                    if (Program.currentShip.equippedWeapon1 == "gun8") w1pab = 3; w1pdmx = 2;
                    if (Program.currentShip.equippedWeapon1 == "gun9") w1pab = 4; w1pdmx = 3;

                    if (w1pdmx < 0) w1pdmg = 0;

                    int playerAttack1 = rnd.Next(1, 21) + w1patk;
                    if (playerAttack1 >= ac) 
                    { 
                        playerhit1 = true; 
                    }
                    if (playerhit1 == true)
                    {
                        playerdmg1 = rnd.Next(1, 7) * w1pdmg;
                        if (playerdmg1 > 0)
                        {
                            Console.WriteLine("The " + Program.currentShip.Name + " scores a hit with its " + Program.currentShip.equippedWeapon1 + " dealing " + playerdmg1 + " damage to the enemy vessel."); Console.WriteLine("");
                        }
                    }

                    if (Program.currentShip.equippedWeapon2 == "empty") w2pab = 0; w2pdmx = -1;
                    if (Program.currentShip.equippedWeapon2 == "flak gun") w2pab = 0; w2pdmx = 3;
                    if (Program.currentShip.equippedWeapon2 == "light laser cannon") w2pab = 1; w2pdmx = 5;
                    if (Program.currentShip.equippedWeapon2 == "beam cannon") w2pab = 1; w2pdmx = 7;
                    if (Program.currentShip.equippedWeapon2 == "gun4") w2pab = 3; w2pdmx = 7;
                    if (Program.currentShip.equippedWeapon2 == "gun5") w2pab = 4; w2pdmx = 8;
                    if (Program.currentShip.equippedWeapon2 == "gun6") w2pab = 1; w2pdmx = 8;
                    if (Program.currentShip.equippedWeapon2 == "gun7") w2pab = 2; w2pdmx = 7;
                    if (Program.currentShip.equippedWeapon2 == "gun8") w2pab = 3; w2pdmx = 2;
                    if (Program.currentShip.equippedWeapon2 == "gun9") w2pab = 4; w2pdmx = 3;

                    if (w2pdmx < 0) w2pdmg = 0;

                    int playerAttack2 = rnd.Next(1, 21) + w2patk;
                    if (playerAttack2 >= ac) 
                    { 
                        playerhit2 = true;
                        if (playerhit2 == true)
                        {
                            playerdmg2 = rnd.Next(1, 7) * w2pdmg;
                            if (playerdmg2 > 0)
                            {
                                Console.WriteLine("The " + Program.currentShip.Name + " scores a hit with its " + Program.currentShip.equippedWeapon2 + " dealing " + playerdmg2 + " damage to the enemy vessel."); Console.WriteLine("");
                            }
                        }
                    }

                    if (Program.currentShip.equippedWeapon3 == "empty") w3pab = 0; w3pdmx = -1;
                    if (Program.currentShip.equippedWeapon3 == "flak gun") w3pab = 0; w3pdmx = 3;
                    if (Program.currentShip.equippedWeapon3 == "light laser cannon") w3pab = 1; w3pdmx = 5;
                    if (Program.currentShip.equippedWeapon3 == "beam cannon") w3pab = 1; w3pdmx = 7;
                    if (Program.currentShip.equippedWeapon3 == "gun4") w3pab = 3; w3pdmx = 7;
                    if (Program.currentShip.equippedWeapon3 == "gun5") w3pab = 4; w3pdmx = 8;
                    if (Program.currentShip.equippedWeapon3 == "gun6") w3pab = 1; w3pdmx = 8;
                    if (Program.currentShip.equippedWeapon3 == "gun7") w3pab = 2; w3pdmx = 7;
                    if (Program.currentShip.equippedWeapon3 == "gun8") w3pab = 3; w3pdmx = 2;
                    if (Program.currentShip.equippedWeapon3 == "gun9") w3pab = 4; w3pdmx = 3;

                    if (w3pdmx < 0) w3pdmg = 0;

                    int playerAttack3 = rnd.Next(1, 21) + w3patk;
                    if (playerAttack3 >= ac) 
                    { 
                        playerhit3 = true;
                        if (playerhit3 == true)
                        {
                            playerdmg3 = rnd.Next(1, 7) * w3pdmg;
                            if (playerdmg3 > 0)
                            {
                                Console.WriteLine("The " + Program.currentShip.Name + " scores a hit with its " + Program.currentShip.equippedWeapon3 + " dealing " + playerdmg3 + " damage to the enemy vessel."); Console.WriteLine("");
                            }
                        }
                    }

                    int enemytotaldamage = enemydmg1 + enemydmg2 + enemydmg3;
                    int playertotaldamage = playerdmg1 + playerdmg2 + playerdmg3;

                    // Enemy ship deals damage, first to shields, then to health
                    if (Program.currentShip.currentShields > 0)
                    {
                        Program.currentShip.currentShields -= enemytotaldamage;
                        if (Program.currentShip.currentShields < 0)
                        {
                            Program.currentShip.currentHealth += Program.currentShip.currentShields;
                            Program.currentShip.currentShields = 0;
                        }
                    }
                    else Program.currentShip.currentHealth -= enemytotaldamage;
                    if (enemytotaldamage > 0)
                    {
                        Console.WriteLine("The enemy ship deals a total of " + enemytotaldamage + " damage to the " + Program.currentShip.Name + " this turn."); Console.WriteLine("");
                    }
                    else Console.WriteLine("The enemy ship did not deal any damage to the " + Program.currentShip.Name + " this turn."); Console.WriteLine("");

                    // Player ship deals damage, first to shields, then to health

                    if (crs > 0)
                    {
                        crs -= playertotaldamage;
                        if (crs < 0)
                        {
                            crh += crs;
                            crs = 0;
                        }
                    }
                    else crh -= playertotaldamage;
                    if (playertotaldamage > 0)
                    {
                        Console.WriteLine("The " + Program.currentShip.Name + " deals a total " + playertotaldamage + " damage to the enemy vessel this turn."); Console.WriteLine("");
                    }
                    else Console.WriteLine("The "+Program.currentShip.Name+" did not manage to deal any damage to the enemy ship this turn."); Console.WriteLine("");

                }
            }
        }
    }
}
