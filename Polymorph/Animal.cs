using System;

namespace Polymorph
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void Voice()
        {
            Console.WriteLine("Animal sesi");
        }
    }

}
