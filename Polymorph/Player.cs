using System;

namespace Polymorph
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string NickName { get; set; }
        public string Guild { get; set; }

        protected virtual void Register()
        {
            Console.WriteLine("Make Registration for All services");
        }



    }



}
