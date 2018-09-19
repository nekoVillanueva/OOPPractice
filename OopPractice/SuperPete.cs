using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    class SuperPete
    {
        //Fields
        private int bikeSpeed;
        private string name;
        private int bootSize;
        private int strength;
        //private int health;
        public int BikeSpeed
        {
            get { return this.bikeSpeed; }
            set { this.bikeSpeed = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int BootSize
        {
            get { return this.bootSize; }
            set { this.bootSize = value; }
        }
        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }
        //public int Health
        //{
        //    get { return this.health; }
        //    set { this.health = value; }
        //}
        public SuperPete()
        {

        }


        public SuperPete(int speed,string man,int foot,int power)
        {
            this.BikeSpeed = speed;
            this.Name = man;
            this.BootSize = foot;
            this.Strength = power;
        }

        public SuperPete(string man)
        {
            this.Name = "Super" + man;
            this.BikeSpeed = 60;
        }
        
        public void IncreaseStrength()
        {
            Strength = Strength * 10;
           
        }












    }


}
