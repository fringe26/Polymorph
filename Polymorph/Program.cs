namespace Polymorph
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            IAttackable ogr = new Ogr(true,100,30);
          
            IDestructable ogr1 = new Ogr(false,200,10);
            IDestructable ogr2 = new Ogr(true, 50, 10);

            IDestructable ogr4 = new Ogr(false, 150, 10);

            IDestructable ogr3 = new Ogr(true, 500, 10);

            IDestructable ogr5 = new Ogr(false, 150, 10);


            ogr.Attack(ogr1);
            ogr.Attack(ogr2);
            ogr.Attack(ogr3);
            ogr.Attack(ogr4);
            ogr.Attack(ogr5);


        }
    }


    interface IDestructable
    {

        public bool IsDestructable { get;}

        public int Health { get;}

        public void TakeDamage(int damage);
    }


    interface IAttackable
    {
        public int Damage { get; }
        public void Attack(IDestructable entity);
        public void SetDamage(int damage);
    }


    class Ogr : IDestructable, IAttackable
    {
        private bool _isDestructable;
        private int _health;
        private int _damage;
        public bool IsDestructable => _isDestructable;
        public int Health => _health;
        public int Damage => _damage;

        public Ogr(bool isDestructable, int health, int damage)
        {
            _isDestructable = isDestructable;
            _health = health;
            _damage = damage;
        }

        public void SetDamage(int damage)
        {
            if (damage < 20 && damage>0)
            {
                _damage = damage;
            }
        }

        public void Attack(IDestructable entity)
        {
            if (entity.IsDestructable)
            {
                System.Console.WriteLine($"Ogr health = {entity.Health}");
                entity.TakeDamage(Damage);
                System.Console.WriteLine($"Ogr health after Attack = {entity.Health}");

            }
            else
            {
                System.Console.WriteLine($"Ogr cann't be destruct");
            }
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
        }
    }


}
