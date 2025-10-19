using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleg
{
    internal class Player
    {
        public event Action OnDeath;
        private int health = 100;

        private void Die()
        {
            Console.WriteLine("Игрок погиб!");
            OnDeath?.Invoke();
        }
        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Die();
            }

        }
    }

}
