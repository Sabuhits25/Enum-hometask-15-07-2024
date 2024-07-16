namespace Enum_hometask_15_07_2024
{
    public class Weapon
    {
        private static int _idCounter = 1;
        public int Id { get; private set; }
        public BulletType BulletType { get; private set; }
        public int Capacity { get; private set; }
        private Queue<Bullet> bullets;

        public Weapon(BulletType bulletType, int capacity)
        {
            Id = _idCounter++;
            BulletType = bulletType;
            Capacity = capacity;
            bullets = new Queue<Bullet>(capacity);
        }

        public void Fill()
        {
            for (int i = 0; i < Capacity; i++)
            {
                bullets.Enqueue(new Bullet(BulletType));
            }
            Console.WriteLine("Weapon is filled with bullets.");
        }

        public void Fire()
        {
            if (bullets.Count > 0)
            {
                Bullet bullet = bullets.Dequeue();
                Console.WriteLine($"Fired {bullet}. Bullets left: {bullets.Count}");
            }
            else
            {
                Console.WriteLine("No bullets left to fire!");
            }
        }

        public void PullTrigger()
        {
            if (bullets.Count > 0)
            {
                Bullet bullet = bullets.Peek();
                Console.WriteLine($"Next bullet to fire: {bullet}");
            }
            else
            {
                Console.WriteLine("No bullets left to fire!");
            }
        }
    }
}
