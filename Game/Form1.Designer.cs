namespace Game
{
    partial class Form1
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
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoret = new System.Windows.Forms.Label();
            this.bird = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // pipe1
            // 
            this.pipe1.Image = global::Game.Properties.Resources.pipedown;
            this.pipe1.Location = new System.Drawing.Point(414, -23);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(88, 192);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 1;
            this.pipe1.TabStop = false;
            
            // 
            // pipe2
            // 
            this.pipe2.Image = global::Game.Properties.Resources.pipe;
            this.pipe2.Location = new System.Drawing.Point(238, 292);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(88, 153);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 2;
            this.pipe2.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Game.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-7, 439);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(541, 63);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoret
            // 
            this.scoret.AutoSize = true;
            this.scoret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.scoret.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoret.Location = new System.Drawing.Point(200, 461);
            this.scoret.Name = "scoret";
            this.scoret.Size = new System.Drawing.Size(94, 21);
            this.scoret.TabIndex = 4;
            this.scoret.Text = "Score:0";
            this.scoret.Click += new System.EventHandler(this.label1_Click);
            // 
            // bird
            // 
            this.bird.Image = global::Game.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(29, 102);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(57, 43);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 5;
            this.bird.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.gametimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(532, 501);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scoret);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe1);
            this.Name = "Form1";
            this.Text = "Floppy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pipe1;
        private PictureBox pipe2;
        private PictureBox ground;
        private Label scoret;
        private PictureBox bird;
        private System.Windows.Forms.Timer gametimer;
    }
}