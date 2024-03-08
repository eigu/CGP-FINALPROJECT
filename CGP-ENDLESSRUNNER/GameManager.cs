using System;
using System.Windows.Forms;

namespace CGP_ENDLESSRUNNER
{
    public class GameManager
    {
        public int score = 0;
        public int lastCheckedScore;

        private Label m_textScore;
        private Timer m_gameTimer;

        public bool m_isGameOver = false;

        public static event Action OnObstacleSpeedIncrease;

        public GameManager(Label textScore, Timer timer)
        {
            m_textScore = textScore;
            m_gameTimer = timer;

            GameWindow.OnGameReset += ResetGame;
            Obstacle.OnScoreIncrease += HandleScoreIncrease;
            Player.OnGameOver += HandleGameOver;
        }

        public void ShowScore()
        {
            m_textScore.Text = "Score: " + score;
        }

        public void HandleSpeedIncrease()
        {
            if (score >= lastCheckedScore + 5)
            {
                int scoreIncrease = (score - lastCheckedScore) / 5;

                OnObstacleSpeedIncrease?.Invoke();

                lastCheckedScore += scoreIncrease * 5;
            }
        }

        public void HandleScoreIncrease()
        {
            score++;
        }

        private void HandleGameOver()
        {
            m_gameTimer.Stop();
            m_textScore.Text += " Press R to restart the game!";
            m_isGameOver = true;
        }

        private void ResetGame()
        {
            m_isGameOver = false;

            score = 0;
            m_textScore.Text = "Score: " + score;

            m_gameTimer.Start();
        }

    }
}
