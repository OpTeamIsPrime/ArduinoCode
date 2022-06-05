namespace IsPrimeAppV4
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.btnQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labeltextcolor = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtForward = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtBack = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtGrab = new System.Windows.Forms.TextBox();
            this.lbForward = new System.Windows.Forms.Label();
            this.lbRight = new System.Windows.Forms.Label();
            this.lbLeft = new System.Windows.Forms.Label();
            this.lbBack = new System.Windows.Forms.Label();
            this.lbGrab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.BackgroundImage")));
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(304, 8);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(34, 30);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labeltextcolor
            // 
            this.labeltextcolor.AutoSize = true;
            this.labeltextcolor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeltextcolor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labeltextcolor.Location = new System.Drawing.Point(46, 137);
            this.labeltextcolor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltextcolor.Name = "labeltextcolor";
            this.labeltextcolor.Size = new System.Drawing.Size(261, 22);
            this.labeltextcolor.TabIndex = 20;
            this.labeltextcolor.Text = "Choose a Keys for the commands";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(213, 316);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 21;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtForward
            // 
            this.txtForward.Location = new System.Drawing.Point(188, 162);
            this.txtForward.Name = "txtForward";
            this.txtForward.Size = new System.Drawing.Size(100, 23);
            this.txtForward.TabIndex = 22;
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(188, 191);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(100, 23);
            this.txtRight.TabIndex = 23;
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(188, 249);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(100, 23);
            this.txtBack.TabIndex = 24;
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(188, 220);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(100, 23);
            this.txtLeft.TabIndex = 25;
            // 
            // txtGrab
            // 
            this.txtGrab.Location = new System.Drawing.Point(188, 278);
            this.txtGrab.Name = "txtGrab";
            this.txtGrab.Size = new System.Drawing.Size(100, 23);
            this.txtGrab.TabIndex = 26;
            // 
            // lbForward
            // 
            this.lbForward.AutoSize = true;
            this.lbForward.Location = new System.Drawing.Point(43, 165);
            this.lbForward.Name = "lbForward";
            this.lbForward.Size = new System.Drawing.Size(145, 15);
            this.lbForward.TabIndex = 27;
            this.lbForward.Text = "Move Forward(current : Z)";
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.Location = new System.Drawing.Point(46, 194);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(131, 15);
            this.lbRight.TabIndex = 28;
            this.lbRight.Text = "Move Right(current : D)";
            // 
            // lbLeft
            // 
            this.lbLeft.AutoSize = true;
            this.lbLeft.Location = new System.Drawing.Point(46, 223);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(124, 15);
            this.lbLeft.TabIndex = 29;
            this.lbLeft.Text = "Move Left(current : Q)";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Location = new System.Drawing.Point(46, 252);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(126, 15);
            this.lbBack.TabIndex = 30;
            this.lbBack.Text = "Move Back(current : S)";
            // 
            // lbGrab
            // 
            this.lbGrab.AutoSize = true;
            this.lbGrab.Location = new System.Drawing.Point(46, 281);
            this.lbGrab.Name = "lbGrab";
            this.lbGrab.Size = new System.Drawing.Size(138, 15);
            this.lbGrab.TabIndex = 31;
            this.lbGrab.Text = "Grab(current : Space Bar)";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(348, 349);
            this.Controls.Add(this.lbGrab);
            this.Controls.Add(this.lbBack);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbForward);
            this.Controls.Add(this.txtGrab);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.txtBack);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtForward);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.labeltextcolor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnQuit;
        private PictureBox pictureBox1;
        private Label labeltextcolor;
        private Button btnAccept;
        private TextBox txtForward;
        private TextBox txtRight;
        private TextBox txtBack;
        private TextBox txtLeft;
        private TextBox txtGrab;
        private Label lbForward;
        private Label lbRight;
        private Label lbLeft;
        private Label lbBack;
        private Label lbGrab;
    }
}