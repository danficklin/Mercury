using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
    public class Creature : Object
    {
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;
        public int Attack;
        public int meleeDamage;
        public int rangedDamage;
        public int armorClass;
        public int Athletics = 0; 
        public int Computers = 0;
        public int Culture = 0;
        public int Intrigue = 0;
        public int Karate = 0;
        public int Guns = 0;
        public int Learning = 0;
        public int Mechanics = 0;
        public int Medicine = 0;
        public int Melee = 0;
        public int Negotiation = 0;
        public int Perception = 0;
        public int Piloting = 0;
        public int Sciences = 0;
        public int Spellcraft = 0;
        public int Survival = 0;
        public string equippedWeapon = "fist";
        public string equippedArmor = "spacesuit";
        public string equippedTrinket = "wristwatch";
        public int armorBonus;

       
    }
}
