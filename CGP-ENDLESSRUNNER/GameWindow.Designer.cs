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
            this.ground = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.textScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            this.SuspendLayout();
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
            // cat
            // 
            this.cat.Image = global::CGP_ENDLESSRUNNER.Properties.Resources.running;
            this.cat.Location = new System.Drawing.Point(150, 506);
            this.cat.Margin = new System.Windows.Forms.Padding(4);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(105, 70);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 1;
            this.cat.TabStop = false;
            this.cat.Tag = "player";
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::CGP_ENDLESSRUNNER.Properties.Resources.obstacle_1;
            this.obstacle1.Location = new System.Drawing.Point(800, 530);
            this.obstacle1.Margin = new System.Windows.Forms.Padding(4);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle1.TabIndex = 1;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::CGP_ENDLESSRUNNER.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(1200, 543);
            this.obstacle2.Margin = new System.Windows.Forms.Padding(4);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(32, 33);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 1;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
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
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.cat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameWindow";
            this.Text = "CGP-ENDLESSRUNNER";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}