using System;
using System.Windows.Forms;

namespace CGP_ENDLESSRUNNER
{
    public partial class GameWindow : Form
    {
        private GameManager m_gameManager;
        private Player m_player;
        private Obstacle m_obstacle;

        public static event Action<bool> OnPlayerJump;
        public static event Action OnGameReset;

        public GameWindow()
        {
            InitializeComponent();

            m_gameManager = new GameManager(textScore, gameTimer);
            m_player = new Player(this, cat);
            m_obstacle = new Obstacle(this);
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            m_gameManager.ShowScore();
            m_gameManager.HandleSpeedIncrease();

            m_player.HandleGravity();
            m_player.HandleCollision();

            m_obstacle.HandleObstacleMovement();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space
                && m_player.IsGrounded)
            {
                OnPlayerJump?.Invoke(true);
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                OnPlayerJump?.Invoke(false);
            }

            if (e.KeyCode == Keys.R
                && m_gameManager.m_isGameOver)
            {
                OnGameReset?.Invoke();
            }
        }
    }
}
