using TMPro;
using UnityEngine;

namespace Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Gradient healthGradient;
        [SerializeField] private TMP_Text healthLabel;
        [SerializeField] private TMP_Text playerObjectLabel;

        [SerializeField] private GameObject deathScreen;

        public void ShowDeathScreen() => deathScreen.SetActive(true);

        public void DrawHealth(int health, int maxHealth)
        {
            healthLabel.text = health.ToString();
            playerObjectLabel.color = healthGradient.Evaluate((float)health / maxHealth);
            healthLabel.color = healthGradient.Evaluate((float)health / maxHealth);
        }
    }
}