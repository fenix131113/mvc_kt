using Player;
using Services;
using UnityEngine;

namespace Spikes
{
    public class Spike : MonoBehaviour
    {
        [SerializeField] private LayerMask playerLayer;
        [SerializeField] private int damage;

        private PlayerController _playerController;

        public void Init(PlayerController playerController)
        {
            _playerController = playerController;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (LayerChecker.CheckLayersEquality(other.gameObject.layer, playerLayer))
                _playerController.ChangeHealth(-damage);
        }
    }
}
