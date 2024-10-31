using Player;
using Player.Data;
using Spikes;
using Unity.Mathematics;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerView playerPrefab;
        [SerializeField] private InputListener inputListener;
        [SerializeField] private Spike spikePrefab;
        [SerializeField] private Transform spikePoint;
        [SerializeField] private PlayerDataSO playerData;
        
        private PlayerView _playerView;
        private PlayerController _playerController;
        private PlayerModel _playerModel;
        private PlayerMoveView _playerMoveView;
        private PlayerMoveController _playerMoveController;
        private PlayerMoveModel _playerMoveModel;

        private void Awake()
        {
            InitPlayer();
            InitSpikes();
        }

        private void InitPlayer()
        {
            // Player
            _playerView = Instantiate(playerPrefab);
            _playerModel = new PlayerModel(playerData.PlayerMaxHealth);
            _playerController = new PlayerController(_playerView, _playerModel);
            
            // Move
            _playerMoveView = _playerView.GetComponent<PlayerMoveView>();
            _playerMoveModel = new PlayerMoveModel(playerData.PlayerMoveSpeed);
            _playerMoveController = new PlayerMoveController(_playerMoveModel, _playerMoveView);
            inputListener.Init(_playerMoveController);
        }

        private void InitSpikes() => Instantiate(spikePrefab, spikePoint.position, quaternion.identity).Init(_playerController);
    }
}