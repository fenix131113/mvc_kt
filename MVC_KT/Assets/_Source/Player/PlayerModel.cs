using System;
using UnityEngine;

namespace Player
{
    public class PlayerModel
    {
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }

        public event Action OnHealthChange;
        public event Action OnPlayerDeath;

        public PlayerModel(int maxHealth)
        {
            MaxHealth = maxHealth;
            Health = MaxHealth;
        }

        public void ChangeHealth(int health)
        {
            Health += health;
            Health = Mathf.Clamp(Health, 0, int.MaxValue);
            OnHealthChange?.Invoke();
            
            if(Health == 0)
                OnPlayerDeath?.Invoke();
        }
    }
}
