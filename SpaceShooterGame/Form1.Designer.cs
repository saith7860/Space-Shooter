namespace SpaceShooterGame
{
    partial class SpaceShooter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceShooter));
            GameTimer = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            RightMoveTimer = new System.Windows.Forms.Timer(components);
            UpMoveTimer = new System.Windows.Forms.Timer(components);
            DownMoveTimer = new System.Windows.Forms.Timer(components);
            LeftMoveTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 10;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(331, 470);
            player.Name = "player";
            player.Size = new Size(50, 50);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // RightMoveTimer
            // 
            RightMoveTimer.Interval = 2;
            RightMoveTimer.Tick += RightMoveTimer_Tick;
            // 
            // UpMoveTimer
            // 
            UpMoveTimer.Interval = 2;
            UpMoveTimer.Tick += UpMoveTimer_Tick;
            // 
            // DownMoveTimer
            // 
            DownMoveTimer.Interval = 2;
            DownMoveTimer.Tick += DownMoveTimer_Tick;
            // 
            // LeftMoveTimer
            // 
            LeftMoveTimer.Interval = 2;
            LeftMoveTimer.Tick += LeftMoveTimer_Tick;
            // 
            // SpaceShooter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(778, 544);
            Controls.Add(player);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 600);
            Name = "SpaceShooter";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "SpaceShooter";
            WindowState = FormWindowState.Minimized;
            Load += SpaceShooter_Load;
            KeyDown += SpaceShooter_KeyDown;
            KeyUp += SpaceShooter_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private PictureBox player;
        private System.Windows.Forms.Timer RightMoveTimer;
        private System.Windows.Forms.Timer UpMoveTimer;
        private System.Windows.Forms.Timer DownMoveTimer;
        private System.Windows.Forms.Timer LeftMoveTimer;
    }
}
