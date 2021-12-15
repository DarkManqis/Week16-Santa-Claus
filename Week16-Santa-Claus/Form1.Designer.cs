namespace Week16_Santa_Claus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.house_DOWN = new System.Windows.Forms.PictureBox();
            this.grounds = new System.Windows.Forms.PictureBox();
            this.Moon_UP = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1_tick = new System.Windows.Forms.Timer(this.components);
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.house_DOWN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon_UP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            this.SuspendLayout();
            // 
            // house_DOWN
            // 
            this.house_DOWN.Image = ((System.Drawing.Image)(resources.GetObject("house_DOWN.Image")));
            this.house_DOWN.Location = new System.Drawing.Point(614, 305);
            this.house_DOWN.Name = "house_DOWN";
            this.house_DOWN.Size = new System.Drawing.Size(143, 133);
            this.house_DOWN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.house_DOWN.TabIndex = 0;
            this.house_DOWN.TabStop = false;
            // 
            // grounds
            // 
            this.grounds.Image = ((System.Drawing.Image)(resources.GetObject("grounds.Image")));
            this.grounds.Location = new System.Drawing.Point(-2, 435);
            this.grounds.Name = "grounds";
            this.grounds.Size = new System.Drawing.Size(1017, 99);
            this.grounds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grounds.TabIndex = 1;
            this.grounds.TabStop = false;
            // 
            // Moon_UP
            // 
            this.Moon_UP.Image = ((System.Drawing.Image)(resources.GetObject("Moon_UP.Image")));
            this.Moon_UP.Location = new System.Drawing.Point(385, 2);
            this.Moon_UP.Name = "Moon_UP";
            this.Moon_UP.Size = new System.Drawing.Size(127, 118);
            this.Moon_UP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Moon_UP.TabIndex = 2;
            this.Moon_UP.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(-2, 265);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(100, 173);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree.TabIndex = 3;
            this.tree.TabStop = false;
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(104, 192);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(196, 118);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 4;
            this.santa.TabStop = false;
            this.santa.Click += new System.EventHandler(this.santa_Click);
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(824, 28);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(125, 92);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake.TabIndex = 5;
            this.snowflake.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(22, 28);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(220, 50);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "scoreLabel";
            // 
            // timer1_tick
            // 
            this.timer1_tick.Enabled = true;
            this.timer1_tick.Tick += new System.EventHandler(this.timer1_tick_Tick);
            // 
            // playAgain
            // 
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgain.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(306, 263);
            this.playAgain.Name = "playAgain";
            this.playAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playAgain.Size = new System.Drawing.Size(206, 117);
            this.playAgain.TabIndex = 7;
            this.playAgain.Text = "PLAY AGAIN";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.snowflake);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.Moon_UP);
            this.Controls.Add(this.grounds);
            this.Controls.Add(this.house_DOWN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.house_DOWN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon_UP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox house_DOWN;
        private System.Windows.Forms.PictureBox grounds;
        private System.Windows.Forms.PictureBox Moon_UP;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1_tick;
        private System.Windows.Forms.Button playAgain;
    }
}

