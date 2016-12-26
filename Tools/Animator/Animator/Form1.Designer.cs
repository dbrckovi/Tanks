namespace Animator
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtHeight = new System.Windows.Forms.Label();
      this.txtWidth = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.picSourceImage = new System.Windows.Forms.PictureBox();
      this.picAnimation = new System.Windows.Forms.PictureBox();
      this.numFrameWidth = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.trackInterval = new System.Windows.Forms.TrackBar();
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.txtMessage = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtInterval = new System.Windows.Forms.Label();
      this.timerAnimator = new System.Windows.Forms.Timer(this.components);
      this.radCenter = new System.Windows.Forms.RadioButton();
      this.radZoom = new System.Windows.Forms.RadioButton();
      this.radStretch = new System.Windows.Forms.RadioButton();
      this.txtFrames = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numFrameWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackInterval)).BeginInit();
      this.panel1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtFrames);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.txtHeight);
      this.groupBox1.Controls.Add(this.txtWidth);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.picSourceImage);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(216, 112);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      // 
      // txtHeight
      // 
      this.txtHeight.AutoSize = true;
      this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtHeight.Location = new System.Drawing.Point(144, 40);
      this.txtHeight.Name = "txtHeight";
      this.txtHeight.Size = new System.Drawing.Size(14, 13);
      this.txtHeight.TabIndex = 4;
      this.txtHeight.Text = "0";
      // 
      // txtWidth
      // 
      this.txtWidth.AutoSize = true;
      this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtWidth.Location = new System.Drawing.Point(144, 16);
      this.txtWidth.Name = "txtWidth";
      this.txtWidth.Size = new System.Drawing.Size(14, 13);
      this.txtWidth.TabIndex = 3;
      this.txtWidth.Text = "0";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(104, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Height";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(104, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Width";
      // 
      // picSourceImage
      // 
      this.picSourceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.picSourceImage.Location = new System.Drawing.Point(8, 16);
      this.picSourceImage.Name = "picSourceImage";
      this.picSourceImage.Size = new System.Drawing.Size(88, 88);
      this.picSourceImage.TabIndex = 0;
      this.picSourceImage.TabStop = false;
      this.picSourceImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.picSourceImage_DragDrop);
      this.picSourceImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.picSourceImage_DragEnter);
      // 
      // picAnimation
      // 
      this.picAnimation.BackColor = System.Drawing.Color.DarkRed;
      this.picAnimation.Dock = System.Windows.Forms.DockStyle.Fill;
      this.picAnimation.Location = new System.Drawing.Point(0, 112);
      this.picAnimation.Name = "picAnimation";
      this.picAnimation.Size = new System.Drawing.Size(1084, 422);
      this.picAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.picAnimation.TabIndex = 2;
      this.picAnimation.TabStop = false;
      // 
      // numFrameWidth
      // 
      this.numFrameWidth.Location = new System.Drawing.Point(104, 24);
      this.numFrameWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numFrameWidth.Name = "numFrameWidth";
      this.numFrameWidth.Size = new System.Drawing.Size(64, 20);
      this.numFrameWidth.TabIndex = 5;
      this.numFrameWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numFrameWidth.ValueChanged += new System.EventHandler(this.numFrameWidth_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 24);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Frame width";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(8, 48);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(90, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Animation interval";
      // 
      // trackInterval
      // 
      this.trackInterval.AutoSize = false;
      this.trackInterval.LargeChange = 100;
      this.trackInterval.Location = new System.Drawing.Point(104, 48);
      this.trackInterval.Maximum = 1000;
      this.trackInterval.Minimum = 1;
      this.trackInterval.Name = "trackInterval";
      this.trackInterval.Size = new System.Drawing.Size(200, 32);
      this.trackInterval.TabIndex = 10;
      this.trackInterval.TickFrequency = 100;
      this.trackInterval.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.trackInterval.Value = 100;
      this.trackInterval.Scroll += new System.EventHandler(this.trackInterval_Scroll);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.groupBox3);
      this.panel1.Controls.Add(this.groupBox2);
      this.panel1.Controls.Add(this.groupBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1084, 112);
      this.panel1.TabIndex = 3;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.txtMessage);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox3.Location = new System.Drawing.Point(528, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(556, 112);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      // 
      // txtMessage
      // 
      this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtMessage.Location = new System.Drawing.Point(3, 16);
      this.txtMessage.Name = "txtMessage";
      this.txtMessage.Size = new System.Drawing.Size(550, 93);
      this.txtMessage.TabIndex = 10;
      this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.radStretch);
      this.groupBox2.Controls.Add(this.radZoom);
      this.groupBox2.Controls.Add(this.radCenter);
      this.groupBox2.Controls.Add(this.txtInterval);
      this.groupBox2.Controls.Add(this.trackInterval);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.numFrameWidth);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
      this.groupBox2.Location = new System.Drawing.Point(216, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(312, 112);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      // 
      // txtInterval
      // 
      this.txtInterval.Location = new System.Drawing.Point(8, 64);
      this.txtInterval.Name = "txtInterval";
      this.txtInterval.Size = new System.Drawing.Size(88, 13);
      this.txtInterval.TabIndex = 11;
      this.txtInterval.Text = "100";
      this.txtInterval.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // timerAnimator
      // 
      this.timerAnimator.Enabled = true;
      this.timerAnimator.Tick += new System.EventHandler(this.timerAnimator_Tick);
      // 
      // radCenter
      // 
      this.radCenter.AutoSize = true;
      this.radCenter.Location = new System.Drawing.Point(32, 88);
      this.radCenter.Name = "radCenter";
      this.radCenter.Size = new System.Drawing.Size(56, 17);
      this.radCenter.TabIndex = 12;
      this.radCenter.Text = "Center";
      this.radCenter.UseVisualStyleBackColor = true;
      this.radCenter.CheckedChanged += new System.EventHandler(this.radCenter_CheckedChanged);
      // 
      // radZoom
      // 
      this.radZoom.AutoSize = true;
      this.radZoom.Checked = true;
      this.radZoom.Location = new System.Drawing.Point(120, 88);
      this.radZoom.Name = "radZoom";
      this.radZoom.Size = new System.Drawing.Size(52, 17);
      this.radZoom.TabIndex = 13;
      this.radZoom.TabStop = true;
      this.radZoom.Text = "Zoom";
      this.radZoom.UseVisualStyleBackColor = true;
      this.radZoom.CheckedChanged += new System.EventHandler(this.radZoom_CheckedChanged);
      // 
      // radStretch
      // 
      this.radStretch.AutoSize = true;
      this.radStretch.Location = new System.Drawing.Point(208, 88);
      this.radStretch.Name = "radStretch";
      this.radStretch.Size = new System.Drawing.Size(59, 17);
      this.radStretch.TabIndex = 14;
      this.radStretch.Text = "Stretch";
      this.radStretch.UseVisualStyleBackColor = true;
      this.radStretch.CheckedChanged += new System.EventHandler(this.radStretch_CheckedChanged);
      // 
      // txtFrames
      // 
      this.txtFrames.AutoSize = true;
      this.txtFrames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.txtFrames.Location = new System.Drawing.Point(144, 64);
      this.txtFrames.Name = "txtFrames";
      this.txtFrames.Size = new System.Drawing.Size(14, 13);
      this.txtFrames.TabIndex = 6;
      this.txtFrames.Text = "0";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(104, 64);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(41, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "Frames";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1084, 534);
      this.Controls.Add(this.picAnimation);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picAnimation)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numFrameWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackInterval)).EndInit();
      this.panel1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numFrameWidth;
    private System.Windows.Forms.Label txtHeight;
    private System.Windows.Forms.Label txtWidth;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox picSourceImage;
    private System.Windows.Forms.PictureBox picAnimation;
    private System.Windows.Forms.TrackBar trackInterval;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label txtInterval;
    private System.Windows.Forms.Label txtMessage;
    private System.Windows.Forms.Timer timerAnimator;
    private System.Windows.Forms.RadioButton radStretch;
    private System.Windows.Forms.RadioButton radZoom;
    private System.Windows.Forms.RadioButton radCenter;
    private System.Windows.Forms.Label txtFrames;
    private System.Windows.Forms.Label label6;
  }
}

