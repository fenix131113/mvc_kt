using UnityEngine;

namespace Player
{
    public class InputListener : MonoBehaviour
    {
        private Vector2 _moveVector;
        
        private PlayerMoveController _playerMoveController;

        public void Init(PlayerMoveController playerMoveController) => _playerMoveController = playerMoveController;

        private void Update()
        {
            MoveInputHandler();
        }
        
        private void FixedUpdate()
        {
            MovePlayerInputSend();
        }

        private void MovePlayerInputSend()
        {
            _playerMoveController.MovePlayer(_moveVector);
        }

        private void MoveInputHandler()
        {
            _moveVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
    }
}