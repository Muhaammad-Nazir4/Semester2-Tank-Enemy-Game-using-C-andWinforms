
namespace Tank_Enemies_game
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
            this.myTankPictureBox = new System.Windows.Forms.PictureBox();
            this.hurdelPictureBox1 = new System.Windows.Forms.PictureBox();
            this.hurdelPictureBox3 = new System.Windows.Forms.PictureBox();
            this.hurdelPictureBox2 = new System.Windows.Forms.PictureBox();
            this.hurdelPictureBox4 = new System.Windows.Forms.PictureBox();
            this.hurdelPictureBox5 = new System.Windows.Forms.PictureBox();
            this.timerForGame = new System.Windows.Forms.Timer(this.components);
            this.scoreTextBox = new System.Windows.Forms.Label();
            this.enemyTankPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myTankPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTankPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myTankPictureBox
            // 
            this.myTankPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.myTankPictureBox.BackgroundImage = global::Tank_Enemies_game.Properties.Resources.images__1_;
            this.myTankPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myTankPictureBox.Location = new System.Drawing.Point(12, 202);
            this.myTankPictureBox.Name = "myTankPictureBox";
            this.myTankPictureBox.Size = new System.Drawing.Size(99, 50);
            this.myTankPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myTankPictureBox.TabIndex = 0;
            this.myTankPictureBox.TabStop = false;
            // 
            // hurdelPictureBox1
            // 
            this.hurdelPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.hurdelPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hurdelPictureBox1.Image")));
            this.hurdelPictureBox1.Location = new System.Drawing.Point(174, 1);
            this.hurdelPictureBox1.Name = "hurdelPictureBox1";
            this.hurdelPictureBox1.Size = new System.Drawing.Size(99, 86);
            this.hurdelPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hurdelPictureBox1.TabIndex = 1;
            this.hurdelPictureBox1.TabStop = false;
            this.hurdelPictureBox1.Tag = "hurdle";
            // 
            // hurdelPictureBox3
            // 
            this.hurdelPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("hurdelPictureBox3.Image")));
            this.hurdelPictureBox3.Location = new System.Drawing.Point(174, 371);
            this.hurdelPictureBox3.Name = "hurdelPictureBox3";
            this.hurdelPictureBox3.Size = new System.Drawing.Size(100, 78);
            this.hurdelPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hurdelPictureBox3.TabIndex = 2;
            this.hurdelPictureBox3.TabStop = false;
            this.hurdelPictureBox3.Tag = "hurdle";
            // 
            // hurdelPictureBox2
            // 
            this.hurdelPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("hurdelPictureBox2.Image")));
            this.hurdelPictureBox2.Location = new System.Drawing.Point(531, 1);
            this.hurdelPictureBox2.Name = "hurdelPictureBox2";
            this.hurdelPictureBox2.Size = new System.Drawing.Size(100, 86);
            this.hurdelPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hurdelPictureBox2.TabIndex = 3;
            this.hurdelPictureBox2.TabStop = false;
            this.hurdelPictureBox2.Tag = "hurdle";
            // 
            // hurdelPictureBox4
            // 
            this.hurdelPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("hurdelPictureBox4.Image")));
            this.hurdelPictureBox4.Location = new System.Drawing.Point(531, 371);
            this.hurdelPictureBox4.Name = "hurdelPictureBox4";
            this.hurdelPictureBox4.Size = new System.Drawing.Size(100, 78);
            this.hurdelPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hurdelPictureBox4.TabIndex = 4;
            this.hurdelPictureBox4.TabStop = false;
            this.hurdelPictureBox4.Tag = "hurdle";
            // 
            // hurdelPictureBox5
            // 
            this.hurdelPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("hurdelPictureBox5.Image")));
            this.hurdelPictureBox5.Location = new System.Drawing.Point(346, 187);
            this.hurdelPictureBox5.Name = "hurdelPictureBox5";
            this.hurdelPictureBox5.Size = new System.Drawing.Size(100, 77);
            this.hurdelPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hurdelPictureBox5.TabIndex = 5;
            this.hurdelPictureBox5.TabStop = false;
            this.hurdelPictureBox5.Tag = "hurdle";
            // 
            // timerForGame
            // 
            this.timerForGame.Enabled = true;
            this.timerForGame.Interval = 30;
            this.timerForGame.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.AutoSize = true;
            this.scoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTextBox.ForeColor = System.Drawing.Color.Black;
            this.scoreTextBox.Location = new System.Drawing.Point(12, 9);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(88, 24);
            this.scoreTextBox.TabIndex = 6;
            this.scoreTextBox.Text = "Score: 0";
            // 
            // enemyTankPictureBox
            // 
            this.enemyTankPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyTankPictureBox.Image")));
            this.enemyTankPictureBox.Location = new System.Drawing.Point(638, 202);
            this.enemyTankPictureBox.Name = "enemyTankPictureBox";
            this.enemyTankPictureBox.Size = new System.Drawing.Size(100, 50);
            this.enemyTankPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyTankPictureBox.TabIndex = 7;
            this.enemyTankPictureBox.TabStop = false;
            this.enemyTankPictureBox.Tag = "enemy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enemyTankPictureBox);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.hurdelPictureBox5);
            this.Controls.Add(this.hurdelPictureBox4);
            this.Controls.Add(this.hurdelPictureBox2);
            this.Controls.Add(this.hurdelPictureBox3);
            this.Controls.Add(this.hurdelPictureBox1);
            this.Controls.Add(this.myTankPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.myTankPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hurdelPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTankPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox myTankPictureBox;
        private System.Windows.Forms.PictureBox hurdelPictureBox1;
        private System.Windows.Forms.PictureBox hurdelPictureBox3;
        private System.Windows.Forms.PictureBox hurdelPictureBox2;
        private System.Windows.Forms.PictureBox hurdelPictureBox4;
        private System.Windows.Forms.PictureBox hurdelPictureBox5;
        private System.Windows.Forms.Timer timerForGame;
        private System.Windows.Forms.Label scoreTextBox;
        private System.Windows.Forms.PictureBox enemyTankPictureBox;
    }
}

