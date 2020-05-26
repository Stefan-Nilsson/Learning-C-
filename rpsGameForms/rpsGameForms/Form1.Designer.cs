namespace rpsGameForms
{
    partial class Form1
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
            this.BtnRock = new System.Windows.Forms.Button();
            this.BtnPaper = new System.Windows.Forms.Button();
            this.BtnScissors = new System.Windows.Forms.Button();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picCpu = new System.Windows.Forms.PictureBox();
            this.LabelPlayer = new System.Windows.Forms.Label();
            this.LabelCPU = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.Label();
            this.txtRounds = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.TimerCountDownEvent = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRock
            // 
            this.BtnRock.Location = new System.Drawing.Point(80, 146);
            this.BtnRock.Name = "BtnRock";
            this.BtnRock.Size = new System.Drawing.Size(75, 23);
            this.BtnRock.TabIndex = 0;
            this.BtnRock.Text = "Rock";
            this.BtnRock.UseVisualStyleBackColor = true;
            this.BtnRock.Click += new System.EventHandler(this.BtnRock_Click);
            // 
            // BtnPaper
            // 
            this.BtnPaper.Location = new System.Drawing.Point(80, 174);
            this.BtnPaper.Name = "BtnPaper";
            this.BtnPaper.Size = new System.Drawing.Size(75, 23);
            this.BtnPaper.TabIndex = 1;
            this.BtnPaper.Text = "Paper";
            this.BtnPaper.UseVisualStyleBackColor = true;
            this.BtnPaper.Click += new System.EventHandler(this.BtnPaper_Click);
            // 
            // BtnScissors
            // 
            this.BtnScissors.Location = new System.Drawing.Point(80, 203);
            this.BtnScissors.Name = "BtnScissors";
            this.BtnScissors.Size = new System.Drawing.Size(75, 23);
            this.BtnScissors.TabIndex = 2;
            this.BtnScissors.Text = "Scissors";
            this.BtnScissors.UseVisualStyleBackColor = true;
            this.BtnScissors.Click += new System.EventHandler(this.BtnScissors_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::rpsGameForms.Properties.Resources.qq;
            this.picPlayer.Location = new System.Drawing.Point(190, 149);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(103, 76);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 3;
            this.picPlayer.TabStop = false;
            // 
            // picCpu
            // 
            this.picCpu.Image = global::rpsGameForms.Properties.Resources.qq;
            this.picCpu.Location = new System.Drawing.Point(374, 149);
            this.picCpu.Name = "picCpu";
            this.picCpu.Size = new System.Drawing.Size(102, 76);
            this.picCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCpu.TabIndex = 4;
            this.picCpu.TabStop = false;
            // 
            // LabelPlayer
            // 
            this.LabelPlayer.AutoSize = true;
            this.LabelPlayer.Location = new System.Drawing.Point(216, 116);
            this.LabelPlayer.Name = "LabelPlayer";
            this.LabelPlayer.Size = new System.Drawing.Size(36, 13);
            this.LabelPlayer.TabIndex = 5;
            this.LabelPlayer.Text = "Player";
            // 
            // LabelCPU
            // 
            this.LabelCPU.AutoSize = true;
            this.LabelCPU.Location = new System.Drawing.Point(396, 121);
            this.LabelCPU.Name = "LabelCPU";
            this.LabelCPU.Size = new System.Drawing.Size(29, 13);
            this.LabelCPU.TabIndex = 6;
            this.LabelCPU.Text = "CPU";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Location = new System.Drawing.Point(642, 121);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(91, 13);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "Player: 0 - CPU: 0";
            // 
            // txtCountDown
            // 
            this.txtCountDown.AutoSize = true;
            this.txtCountDown.Location = new System.Drawing.Point(642, 165);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(13, 13);
            this.txtCountDown.TabIndex = 8;
            this.txtCountDown.Text = "5";
            // 
            // txtRounds
            // 
            this.txtRounds.AutoSize = true;
            this.txtRounds.Location = new System.Drawing.Point(642, 213);
            this.txtRounds.Name = "txtRounds";
            this.txtRounds.Size = new System.Drawing.Size(51, 13);
            this.txtRounds.TabIndex = 9;
            this.txtRounds.Text = "Round: 3";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(185, 297);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(290, 37);
            this.ButtonReset.TabIndex = 10;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // TimerCountDownEvent
            // 
            this.TimerCountDownEvent.Interval = 1000;
            this.TimerCountDownEvent.Tick += new System.EventHandler(this.TimerCountDownEvent_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.txtRounds);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.LabelCPU);
            this.Controls.Add(this.LabelPlayer);
            this.Controls.Add(this.picCpu);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.BtnScissors);
            this.Controls.Add(this.BtnPaper);
            this.Controls.Add(this.BtnRock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRock;
        private System.Windows.Forms.Button BtnPaper;
        private System.Windows.Forms.Button BtnScissors;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCpu;
        private System.Windows.Forms.Label LabelPlayer;
        private System.Windows.Forms.Label LabelCPU;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Label txtRounds;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Timer TimerCountDownEvent;
    }
}

