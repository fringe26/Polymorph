using System;

namespace Polymorph
{
    public class Warrior :Player
    {
        public int Damage { get; }
        public int Health { get; private set; }
        public int Strength { get; private set; }

        public Warrior(int  damage, int health,int strength,string name) : base(name)
        {
            Damage = damage;
            Health = health;
            Strength = strength;
            
        }

        protected override void Register()
        {
            Console.WriteLine("Register MyServices");
            base.Register();
        }
    }



}
