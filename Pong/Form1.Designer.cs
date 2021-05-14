
namespace Pong
{
    partial class Pong
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
            this.components = new System.ComponentModel.Container();
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.topBorder = new System.Windows.Forms.PictureBox();
            this.bottomBorder = new System.Windows.Forms.PictureBox();
            this.resetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // paddle1
            // 
            this.paddle1.BackColor = System.Drawing.Color.LightGray;
            this.paddle1.Location = new System.Drawing.Point(12, 247);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(10, 50);
            this.paddle1.TabIndex = 0;
            this.paddle1.TabStop = false;
            this.paddle1.Tag = "object";
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.Color.LightGray;
            this.paddle2.Location = new System.Drawing.Point(778, 247);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(10, 50);
            this.paddle2.TabIndex = 1;
            this.paddle2.TabStop = false;
            this.paddle2.Tag = "object";
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 30;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimerEvent);
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player1Score.ForeColor = System.Drawing.Color.White;
            this.player1Score.Location = new System.Drawing.Point(156, 9);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(46, 54);
            this.player1Score.TabIndex = 2;
            this.player1Score.Text = "0";
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player2Score.ForeColor = System.Drawing.Color.White;
            this.player2Score.Location = new System.Drawing.Point(625, 9);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(46, 54);
            this.player2Score.TabIndex = 3;
            this.player2Score.Text = "0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.LightGray;
            this.ball.Location = new System.Drawing.Point(404, 266);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            this.ball.Tag = "";
            // 
            // topBorder
            // 
            this.topBorder.BackColor = System.Drawing.Color.DimGray;
            this.topBorder.Location = new System.Drawing.Point(0, 66);
            this.topBorder.Name = "topBorder";
            this.topBorder.Size = new System.Drawing.Size(803, 5);
            this.topBorder.TabIndex = 5;
            this.topBorder.TabStop = false;
            this.topBorder.Tag = "border";
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.DimGray;
            this.bottomBorder.Location = new System.Drawing.Point(0, 518);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(803, 5);
            this.bottomBorder.TabIndex = 6;
            this.bottomBorder.TabStop = false;
            this.bottomBorder.Tag = "border";
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.ForeColor = System.Drawing.Color.White;
            this.resetLabel.Location = new System.Drawing.Point(355, 26);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(96, 15);
            this.resetLabel.TabIndex = 7;
            this.resetLabel.Text = "Press Esc to reset";
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.resetLabel);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.topBorder);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.paddle1);
            this.Name = "Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox topBorder;
        private System.Windows.Forms.PictureBox bottomBorder;
        private System.Windows.Forms.Label resetLabel;
    }
}

