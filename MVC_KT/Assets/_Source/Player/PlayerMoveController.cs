using UnityEngine;

namespace Player
{
    public class PlayerMoveController
    {
        private PlayerMoveModel _model;
        private PlayerMoveView _view;

        public PlayerMoveController(PlayerMoveModel model, PlayerMoveView view)
        {
            _model = model;
            _view = view;
        }

        public void MovePlayer(Vector2 input)
        {
            _view.Move(_model.GetMoveVector(input));
        }
    }
}