using System;
using System.Linq;
using System.Windows.Forms;

namespace CGP_ENDLESSRUNNER
{
    public class Player
    {
        private Form m_form;

        private PictureBox m_player;

        private int m_defaultForce = 12;
        private int m_currentForce;

        private int m_defaultJumpSpeed = 12;
        private int m_currentJumpSpeed;

        public bool IsJumping = false;
        public bool IsGrounded = false;

        public static event Action OnGameOver;

        public Player(Form form, PictureBox player)
        {
            m_form = form;
            m_player = player;

            m_currentForce = m_defaultForce;
            m_currentJumpSpeed = m_defaultJumpSpeed;

            m_player.Top = 400;

            OnGameOver += HandleDeath;
            GameWindow.OnGameReset += ResetPlayer;
        }

        public void HandlePlayerMovement()
        {
            m_player.Top += m_currentJumpSpeed;

            if (IsJumping == true && m_currentForce < 0)
            {
                IsJumping = false;
            }

            if (IsJumping == true)
            {
                m_currentJumpSpeed = -m_defaultJumpSpeed;
                m_currentForce -= 1;
            }
            else
            {
                m_currentJumpSpeed = m_defaultJumpSpeed;
            }
        }

        public void HandleCollision()
        {
            foreach (Control x in m_form.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ground")
                {
                    if (m_player.Bottom > x.Top)
                    {
                        m_currentForce = m_defaultForce;
                        m_currentJumpSpeed = 0;

                        IsGrounded = true;

                        m_player.Top = x.Top - m_player.Height;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    if (m_player.Bounds.IntersectsWith(x.Bounds))
                    {
                        OnGameOver?.Invoke();
                    }
                }
            }
        }

        private void HandleDeath()
        {
            m_player.Image = CGP_ENDLESSRUNNER.Properties.Resources.dead;
        }

        public void ResetPlayer()
        {
            m_currentForce = m_defaultForce;
            m_currentJumpSpeed = m_defaultJumpSpeed;

            m_player.Top = 400;

            IsJumping = false;

            m_player.Image = CGP_ENDLESSRUNNER.Properties.Resources.running;
        }
    }
}
