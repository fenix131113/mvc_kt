using System;
using UnityEngine;

namespace Player
{
    public class PlayerModel
    {
        public int Health
        {
            get => _health;

            private set
            {
                _health = value;
                OnHealthChange?.Invoke();
            }
        }

        public int MaxHealth { get; private set; }

        private int _health;

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

            if (Health == 0)
                OnPlayerDeath?.Invoke();
        }
    }
}