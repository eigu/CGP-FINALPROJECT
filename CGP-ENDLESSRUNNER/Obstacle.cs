using System;
using System.Windows.Forms;

namespace CGP_ENDLESSRUNNER
{
    public class Obstacle
    {
        private Form m_form;

        private int m_defaultSpeed = 16;
        private int m_currentSpeed;

        Random random = new Random();

        public static event Action OnScoreIncrease;

        public Obstacle(Form form)
        {
            m_form = form;

            m_currentSpeed = m_defaultSpeed;

            ResetObstacle();

            GameManager.OnObstacleSpeedIncrease += HandleSpeedIncrease;
            GameWindow.OnGameReset += ResetObstacle;
        }

        public void HandleObstacleMovement()
        {
            foreach (Control x in m_form.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= m_currentSpeed;

                    if (x.Left < -100)
                    {
                        OnScoreIncrease?.Invoke();
                        x.Left = m_form.ClientSize.Width + random.Next(200, 600) + (x.Width * 50);
                    }
                }
            }
        }

        public void HandleSpeedIncrease()
        {
            m_currentSpeed++;
        }

        public void ResetObstacle()
        {
            m_currentSpeed = m_defaultSpeed;

            foreach (Control x in m_form.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left = m_form.ClientSize.Width + random.Next(200, 600) + (x.Width * 50);
                }
            }
        }
    }
}
