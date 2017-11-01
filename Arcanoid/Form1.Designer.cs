namespace Arcanoid
{
    partial class Board1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board1));
            this.Paddle = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Paddle
            // 
            this.Paddle.Image = ((System.Drawing.Image)(resources.GetObject("Paddle.Image")));
            this.Paddle.Location = new System.Drawing.Point(535, 628);
            this.Paddle.Name = "Paddle";
            this.Paddle.Size = new System.Drawing.Size(159, 24);
            this.Paddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Paddle.TabIndex = 0;
            this.Paddle.TabStop = false;
            // 
            // block1
            // 
            this.block1.Image = ((System.Drawing.Image)(resources.GetObject("block1.Image")));
            this.block1.Location = new System.Drawing.Point(13, 40);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(64, 32);
            this.block1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.block1.TabIndex = 1;
            this.block1.TabStop = false;
            this.block1.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(83, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(153, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(223, 40);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(293, 40);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(363, 40);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(433, 40);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(64, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(503, 40);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(64, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(573, 40);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(64, 32);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(643, 40);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(64, 32);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(713, 40);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(64, 32);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Layout += new System.Windows.Forms.LayoutEventHandler(this.pictureBox12_Layout);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Ball
            // 
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(600, 603);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(24, 24);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ball.TabIndex = 12;
            this.Ball.TabStop = false;
            this.Ball.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // Board1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.Paddle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Board1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcanoid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Board1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Board1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Paddle;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox Ball;
    }
}

