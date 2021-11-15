// Week 12 Project 1
// File Name: week12project1.cs
// Author: Lucas Smith
// Date:  November 15, 2021
//
// Problem Statement: The code is not very object oriented and does not support information hiding in the Alien class.  Split the code into multiple files.  
// Rewrite the code so that inheritance is used to represent the different types of aliens instead of the “type” parameter.  This should result in deletion of the “type” parameter.  Also rewrite the Alien class to hide the instance variables and create a GetDamage method for each derived class that returns the amount of damage the alien inflicts.  
// Finally, rewrite the CalculateDamage method to use GetDamage and write a Main method that tests the code.
// 
// 
// Overall Plan:
// 1) Show original code
// 2) Change to multiple classes inherited from Alien class
// 3) Run the code to check for compiler errors

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Initial Program
/*
namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Alien
    {
        public const int SNAKE_ALIEN = 0;
        public const int OGRE_ALIEN = 1;
        public const int MARSHALLOW_MAN_ALIEN = 2;
        public int type;
        public int health; //0 = dead, 100 = full
        public string name;

        public Alien(int type, int health, string name)
        {
            this.type = type;
            this.health = health;
            this.name = name;
        }
    }

    class AlienPack
    {
        private Alien[] aliens;
        
        public AlienPack(int numAliens)
        {
            aliens = new Alien[numAliens];
        }

        public void AddAlien(Alien newAlien, int index)
        {
            aliens[index] = newAlien;
        }

        public Alien[] GetAliens()
        {
            return aliens;
        }

        public int CalculateDamage()
        {
            int damage = 0;

            foreach(Alien a in aliens)
            {
                if (a.type = Alien.SNAKE_ALIEN)
                {
                    damage += 10;
                } else if (a.type == Alien.OGRE_ALIEN)
                {
                    damage += 6;
                } else if (a.type = Alien.MARSHALLOW_MAN_ALIEN)
                {
                    damage += 1;
                }
            }
            return damage;
        }
    }
}
*/

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Alien
    {
        protected int health;
        protected string name;

        public Alien()
        {

        }

        public Alien(int health, string name)
        {
            this.health = health;
            this.name = name;
        }
    }

    public class MarshmallowAlien : Alien
    {
        private const int damage = 1;
        private int number;

        public MarshmallowAlien(int number, int health, string name)
        {
            this.health = health;
            this.name = name;
            this.number = number;
        }

        public int getDamage()
        {
            return damage;
        }

        public int calculateDamage()
        {
            return getDamage() * number;
        }

        public override string ToString()
        {
            return ("The Alien " + name + " has " + health + " Health. " + name + " dealt " + calculateDamage() + " Damage.");
        }
    }

    public class OgreAlien : Alien
    {
        private const int damage = 6;
        private int number;
        public OgreAlien(int number, int health, string name)
        {
            this.health = health;
            this.name = name;
            this.number = number;
        }

        public int getDamage()
        {
            return damage;
        }

        int calculateDamage()
        {
            return getDamage() * number;
        }

        public override string ToString()
        {
            return ("The Alien " + name + " has " + health + " Health. " + name + " dealt " + calculateDamage() + " Damage.");
        }
    }

    public class SnakeAlien : Alien
    {
        private const int damage = 10;
        private int number;

        public SnakeAlien(int number, int health, string name)
        {
            this.health = health;
            this.name = name;
            this.number = number;
        }


        public int getDamage()
        {
            return damage;
        }

        public int calculateDamage()
        {
            return getDamage() * number;
        }

        public override string ToString()
        {
            return ("The Alien " + name + " has " + health + " Health. " + name + " dealt " + calculateDamage() + " Damage.");
        }
    }
}