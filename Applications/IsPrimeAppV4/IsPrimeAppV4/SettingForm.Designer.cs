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
            this.label1 = new System.Windows.Forms.Label();
            this.VForward = new System.Windows.Forms.Label();
            this.VLeft = new System.Windows.Forms.Label();
            this.VRight = new System.Windows.Forms.Label();
            this.VBack = new System.Windows.Forms.Label();
            this.VStop = new System.Windows.Forms.Label();
            this.VGrab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStop = new System.Windows.Forms.TextBox();
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
            this.btnAccept.Location = new System.Drawing.Point(261, 345);
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
            this.txtForward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtForward_KeyDown);
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(188, 191);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(100, 23);
            this.txtRight.TabIndex = 23;
            this.txtRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRight_KeyDown);
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(188, 249);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(100, 23);
            this.txtBack.TabIndex = 24;
            this.txtBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBack_KeyDown);
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(188, 220);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(100, 23);
            this.txtLeft.TabIndex = 25;
            this.txtLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLeft_KeyDown);
            // 
            // txtGrab
            // 
            this.txtGrab.Location = new System.Drawing.Point(188, 275);
            this.txtGrab.Name = "txtGrab";
            this.txtGrab.Size = new System.Drawing.Size(100, 23);
            this.txtGrab.TabIndex = 26;
            this.txtGrab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGrab_KeyDown);
            // 
            // lbForward
            // 
            this.lbForward.AutoSize = true;
            this.lbForward.Location = new System.Drawing.Point(14, 165);
            this.lbForward.Name = "lbForward";
            this.lbForward.Size = new System.Drawing.Size(139, 15);
            this.lbForward.TabIndex = 27;
            this.lbForward.Text = "Move Forward,  current : ";
            // 
            // lbRight
            // 
            this.lbRight.AutoSize = true;
            this.lbRight.Location = new System.Drawing.Point(14, 194);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(121, 15);
            this.lbRight.TabIndex = 28;
            this.lbRight.Text = "Move Right, current : ";
            // 
            // lbLeft
            // 
            this.lbLeft.AutoSize = true;
            this.lbLeft.Location = new System.Drawing.Point(14, 223);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(113, 15);
            this.lbLeft.TabIndex = 29;
            this.lbLeft.Text = "Move Left, current : ";
            // 
            // lbBack
            // 
            this.lbBack.AutoSize = true;
            this.lbBack.Location = new System.Drawing.Point(14, 252);
            this.lbBack.Name = "lbBack";
            this.lbBack.Size = new System.Drawing.Size(118, 15);
            this.lbBack.TabIndex = 30;
            this.lbBack.Text = "Move Back, current : ";
            // 
            // lbGrab
            // 
            this.lbGrab.AutoSize = true;
            this.lbGrab.Location = new System.Drawing.Point(13, 278);
            this.lbGrab.Name = "lbGrab";
            this.lbGrab.Size = new System.Drawing.Size(82, 15);
            this.lbGrab.TabIndex = 31;
            this.lbGrab.Text = "Grab, current :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "label1";
            // 
            // VForward
            // 
            this.VForward.AutoSize = true;
            this.VForward.Location = new System.Drawing.Point(150, 165);
            this.VForward.Name = "VForward";
            this.VForward.Size = new System.Drawing.Size(36, 15);
            this.VForward.TabIndex = 33;
            this.VForward.Text = "None";
            // 
            // VLeft
            // 
            this.VLeft.AutoSize = true;
            this.VLeft.Location = new System.Drawing.Point(150, 223);
            this.VLeft.Name = "VLeft";
            this.VLeft.Size = new System.Drawing.Size(36, 15);
            this.VLeft.TabIndex = 34;
            this.VLeft.Text = "None";
            // 
            // VRight
            // 
            this.VRight.AutoSize = true;
            this.VRight.Location = new System.Drawing.Point(150, 194);
            this.VRight.Name = "VRight";
            this.VRight.Size = new System.Drawing.Size(36, 15);
            this.VRight.TabIndex = 35;
            this.VRight.Text = "None";
            // 
            // VBack
            // 
            this.VBack.AutoSize = true;
            this.VBack.Location = new System.Drawing.Point(150, 249);
            this.VBack.Name = "VBack";
            this.VBack.Size = new System.Drawing.Size(36, 15);
            this.VBack.TabIndex = 36;
            this.VBack.Text = "None";
            // 
            // VStop
            // 
            this.VStop.AutoSize = true;
            this.VStop.Location = new System.Drawing.Point(150, 307);
            this.VStop.Name = "VStop";
            this.VStop.Size = new System.Drawing.Size(36, 15);
            this.VStop.TabIndex = 37;
            this.VStop.Text = "None";
            // 
            // VGrab
            // 
            this.VGrab.AutoSize = true;
            this.VGrab.Location = new System.Drawing.Point(150, 278);
            this.VGrab.Name = "VGrab";
            this.VGrab.Size = new System.Drawing.Size(36, 15);
            this.VGrab.TabIndex = 38;
            this.VGrab.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Stop, current :";
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(188, 304);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(100, 23);
            this.txtStop.TabIndex = 40;
            this.txtStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStop_KeyDown);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(348, 380);
            this.Controls.Add(this.txtStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VGrab);
            this.Controls.Add(this.VStop);
            this.Controls.Add(this.VBack);
            this.Controls.Add(this.VRight);
            this.Controls.Add(this.VLeft);
            this.Controls.Add(this.VForward);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Label VForward;
        private Label VLeft;
        private Label VRight;
        private Label VBack;
        private Label VStop;
        private Label VGrab;
        private Label label2;
        private TextBox txtStop;
    }
}