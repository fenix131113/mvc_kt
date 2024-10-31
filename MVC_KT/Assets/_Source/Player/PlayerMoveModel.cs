using UnityEngine;

namespace Player
{
    public class PlayerMoveModel
    {
        private readonly int _speed;

        public PlayerMoveModel(int speed)
        {
            _speed = speed;
        }
        
        public Vector2 GetMoveVector(Vector2 input) => input.normalized * (_speed * Time.deltaTime);
    }
}