
namespace AirHockey2D
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.homeScoreLabel = new System.Windows.Forms.Label();
            this.awayScoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // homeScoreLabel
            // 
            this.homeScoreLabel.AutoSize = true;
            this.homeScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.homeScoreLabel.ForeColor = System.Drawing.Color.White;
            this.homeScoreLabel.Location = new System.Drawing.Point(104, 9);
            this.homeScoreLabel.Name = "homeScoreLabel";
            this.homeScoreLabel.Size = new System.Drawing.Size(0, 13);
            this.homeScoreLabel.TabIndex = 0;
            // 
            // awayScoreLabel
            // 
            this.awayScoreLabel.AutoSize = true;
            this.awayScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.awayScoreLabel.ForeColor = System.Drawing.Color.White;
            this.awayScoreLabel.Location = new System.Drawing.Point(502, 17);
            this.awayScoreLabel.Name = "awayScoreLabel";
            this.awayScoreLabel.Size = new System.Drawing.Size(0, 13);
            this.awayScoreLabel.TabIndex = 1;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.winLabel.Location = new System.Drawing.Point(311, 139);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(0, 16);
            this.winLabel.TabIndex = 2;
            this.winLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.awayScoreLabel);
            this.Controls.Add(this.homeScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.AutoSizeChanged += new System.EventHandler(this.Form1_AutoSizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label homeScoreLabel;
        private System.Windows.Forms.Label awayScoreLabel;
        private System.Windows.Forms.Label winLabel;
    }
}

