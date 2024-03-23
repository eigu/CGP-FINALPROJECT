namespace CGP_ENDLESSRUNNER
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.mouse1 = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.mouse2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse2)).BeginInit();
            this.SuspendLayout();
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(17, 16);
            this.textScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(134, 32);
            this.textScore.TabIndex = 2;
            this.textScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // ground
            // 
            this.ground.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ground.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ground.Location = new System.Drawing.Point(0, 580);
            this.ground.Margin = new System.Windows.Forms.Padding(0, 100, 0, 0);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1280, 100);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            this.ground.Tag = "ground";
            // 
            // mouse1
            // 
            this.mouse1.Image = global::CGP_ENDLESSRUNNER.Properties.Resources.mouse;
            this.mouse1.Location = new System.Drawing.Point(655, 541);
            this.mouse1.Margin = new System.Windows.Forms.Padding(4);
            this.mouse1.Name = "mouse1";
            this.mouse1.Size = new System.Drawing.Size(47, 35);
            this.mouse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mouse1.TabIndex = 1;
            this.mouse1.TabStop = false;
            this.mouse1.Tag = "obstacle";
            // 
            // cat
            // 
            this.cat.Image = global::CGP_ENDLESSRUNNER.Properties.Resources.running;
            this.cat.Location = new System.Drawing.Point(149, 506);
            this.cat.Margin = new System.Windows.Forms.Padding(4);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(105, 70);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 1;
            this.cat.TabStop = false;
            this.cat.Tag = "player";
            // 
            // mouse2
            // 
            this.mouse2.Image = global::CGP_ENDLESSRUNNER.Properties.Resources.mouse;
            this.mouse2.Location = new System.Drawing.Point(1091, 541);
            this.mouse2.Margin = new System.Windows.Forms.Padding(4);
            this.mouse2.Name = "mouse2";
            this.mouse2.Size = new System.Drawing.Size(47, 35);
            this.mouse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mouse2.TabIndex = 3;
            this.mouse2.TabStop = false;
            this.mouse2.Tag = "obstacle";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.mouse2);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.mouse1);
            this.Controls.Add(this.cat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameWindow";
            this.Text = "CGP-ENDLESSRUNNER";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouse2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox mouse1;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox mouse2;
    }
}