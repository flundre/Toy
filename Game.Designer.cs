
namespace Toy
{
    partial class Game
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
            this.Score = new System.Windows.Forms.Label();
            this.BallTimer = new System.Windows.Forms.Timer(this.components);
            this.SecretBallBox = new System.Windows.Forms.PictureBox();
            this.YellowBallBox = new System.Windows.Forms.PictureBox();
            this.GreenBallBox = new System.Windows.Forms.PictureBox();
            this.BlueBallBox = new System.Windows.Forms.PictureBox();
            this.RedBallBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SecretBallBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBallBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBallBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBallBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBallBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score.Location = new System.Drawing.Point(12, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(108, 45);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score";
            // 
            // BallTimer
            // 
            this.BallTimer.Enabled = true;
            this.BallTimer.Interval = 1000;
            this.BallTimer.Tick += new System.EventHandler(this.BallTimer_Tick);
            // 
            // SecretBallBox
            // 
            this.SecretBallBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SecretBallBox.Image = global::Toy.Properties.Resources.secretball;
            this.SecretBallBox.Location = new System.Drawing.Point(72, 249);
            this.SecretBallBox.Name = "SecretBallBox";
            this.SecretBallBox.Size = new System.Drawing.Size(48, 50);
            this.SecretBallBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecretBallBox.TabIndex = 5;
            this.SecretBallBox.TabStop = false;
            this.SecretBallBox.Visible = false;
            // 
            // YellowBallBox
            // 
            this.YellowBallBox.Image = global::Toy.Properties.Resources.yellowball;
            this.YellowBallBox.Location = new System.Drawing.Point(214, 249);
            this.YellowBallBox.Name = "YellowBallBox";
            this.YellowBallBox.Size = new System.Drawing.Size(48, 50);
            this.YellowBallBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YellowBallBox.TabIndex = 4;
            this.YellowBallBox.TabStop = false;
            this.YellowBallBox.Visible = false;
            this.YellowBallBox.Click += new System.EventHandler(this.YellowBallBox_Click);
            // 
            // GreenBallBox
            // 
            this.GreenBallBox.Image = global::Toy.Properties.Resources.greenball;
            this.GreenBallBox.Location = new System.Drawing.Point(268, 249);
            this.GreenBallBox.Name = "GreenBallBox";
            this.GreenBallBox.Size = new System.Drawing.Size(48, 50);
            this.GreenBallBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GreenBallBox.TabIndex = 3;
            this.GreenBallBox.TabStop = false;
            this.GreenBallBox.Visible = false;
            this.GreenBallBox.Click += new System.EventHandler(this.GreenBallBox_Click);
            // 
            // BlueBallBox
            // 
            this.BlueBallBox.Image = global::Toy.Properties.Resources.blueball;
            this.BlueBallBox.Location = new System.Drawing.Point(151, 249);
            this.BlueBallBox.Name = "BlueBallBox";
            this.BlueBallBox.Size = new System.Drawing.Size(48, 50);
            this.BlueBallBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BlueBallBox.TabIndex = 2;
            this.BlueBallBox.TabStop = false;
            this.BlueBallBox.Visible = false;
            this.BlueBallBox.Click += new System.EventHandler(this.BlueBallBox_Click);
            // 
            // RedBallBox
            // 
            this.RedBallBox.Image = global::Toy.Properties.Resources.redball;
            this.RedBallBox.Location = new System.Drawing.Point(320, 152);
            this.RedBallBox.Name = "RedBallBox";
            this.RedBallBox.Size = new System.Drawing.Size(48, 50);
            this.RedBallBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedBallBox.TabIndex = 1;
            this.RedBallBox.TabStop = false;
            this.RedBallBox.Click += new System.EventHandler(this.RedBallBox_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.SecretBallBox);
            this.Controls.Add(this.YellowBallBox);
            this.Controls.Add(this.GreenBallBox);
            this.Controls.Add(this.BlueBallBox);
            this.Controls.Add(this.RedBallBox);
            this.Controls.Add(this.Score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Click += new System.EventHandler(this.Game_Click);
            ((System.ComponentModel.ISupportInitialize)(this.SecretBallBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBallBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBallBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBallBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBallBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox RedBallBox;
        private System.Windows.Forms.Timer BallTimer;
        private System.Windows.Forms.PictureBox BlueBallBox;
        private System.Windows.Forms.PictureBox GreenBallBox;
        private System.Windows.Forms.PictureBox YellowBallBox;
        private System.Windows.Forms.PictureBox SecretBallBox;
    }
}