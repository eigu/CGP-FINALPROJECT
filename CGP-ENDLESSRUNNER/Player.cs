using System;
using System.Linq;
using System.Windows.Forms;

namespace CGP_ENDLESSRUNNER
{
    public class Player
    {
        private Form m_form;
        private PictureBox m_player;


        private const int m_defaultJumpSpeed = 10;
        private int m_currentJumpSpeed;

        private const int m_maxJumpForce = 1;
        private const int m_increaseJumpForce = 1;
        private int m_currentJumpForce = 0;

        public bool IsJumping = false;
        public bool IsGrounded = false;

        public static event Action OnGameOver;

        public Player(Form form, PictureBox player)
        {
            m_form = form;
            m_player = player;

            ResetPlayer();

            OnGameOver += HandleDeath;
            GameWindow.OnPlayerJump += HandlePlayerJump;
            GameWindow.OnGameReset += ResetPlayer;
        }

        public void HandlePlayerJump(bool action)
        {
            IsJumping = action;

            if (IsJumping && m_currentJumpForce > m_maxJumpForce)
            {
                IsJumping = false;
            }
            
            if (IsJumping)
            {
                m_currentJumpSpeed = -m_defaultJumpSpeed;
                m_currentJumpForce += m_increaseJumpForce;
            }
        }

        public void HandleGravity()
        {
            m_player.Top += m_currentJumpSpeed;

            if (!IsJumping)
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
                        m_currentJumpForce = 0;
                        m_currentJumpSpeed = 0;

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
            IsJumping = false;

            m_currentJumpForce = 0;

            m_player.Top = 420;

            m_player.Image = CGP_ENDLESSRUNNER.Properties.Resources.running;
        }
    }
}
