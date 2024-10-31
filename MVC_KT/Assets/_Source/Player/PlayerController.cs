namespace Player
{
    public class PlayerController
    {
        private readonly PlayerView _view;
        private readonly PlayerModel _model;

        public PlayerController(PlayerView view, PlayerModel playerModel)
        {
            _view = view;
            _model = playerModel;

            Init();
        }

        ~PlayerController() => Expose();

        private void Init()
        {
            Bind();
            OnHealthUpdate();
        }

        public void ChangeHealth(int health) => _model.ChangeHealth(health);

        private void OnHealthUpdate()
        {
            _view.DrawHealth(_model.Health, _model.MaxHealth);
        }

        private void Bind()
        {
            _model.OnHealthChange += OnHealthUpdate;
            _model.OnPlayerDeath += _view.ShowDeathScreen;
        }

        private void Expose()
        {
            _model.OnHealthChange -= OnHealthUpdate;
            _model.OnPlayerDeath -= _view.ShowDeathScreen;
        }
    }
}
