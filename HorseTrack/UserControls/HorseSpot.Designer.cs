namespace HorseTrack.UserControls
{
    partial class HorseSpot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.channelContainerRight = new System.Windows.Forms.FlowLayoutPanel();
            this.channellTimer7 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer8 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer9 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer10 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer11 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer12 = new HorseTrack.UserControls.ChannellTimer();
            this.channelContainerLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.channellTimer1 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer2 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer3 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer4 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer5 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer6 = new HorseTrack.UserControls.ChannellTimer();
            this.lblCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.channelContainerRight.SuspendLayout();
            this.channelContainerLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCaption, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Location = new System.Drawing.Point(320, 0);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 25);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "X";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel2.Controls.Add(this.channelContainerRight, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.channelContainerLeft, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 405F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(345, 405);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // channelContainerRight
            // 
            this.channelContainerRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelContainerRight.Controls.Add(this.channellTimer7);
            this.channelContainerRight.Controls.Add(this.channellTimer8);
            this.channelContainerRight.Controls.Add(this.channellTimer9);
            this.channelContainerRight.Controls.Add(this.channellTimer10);
            this.channelContainerRight.Controls.Add(this.channellTimer11);
            this.channelContainerRight.Controls.Add(this.channellTimer12);
            this.channelContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelContainerRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.channelContainerRight.Location = new System.Drawing.Point(174, 0);
            this.channelContainerRight.Margin = new System.Windows.Forms.Padding(0);
            this.channelContainerRight.Name = "channelContainerRight";
            this.channelContainerRight.Size = new System.Drawing.Size(171, 405);
            this.channelContainerRight.TabIndex = 2;
            // 
            // channellTimer7
            // 
            this.channellTimer7.AutoSize = true;
            this.channellTimer7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer7.ChannelName = "Ser C2";
            this.channellTimer7.Index = 0;
            this.channellTimer7.Location = new System.Drawing.Point(0, 0);
            this.channellTimer7.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer7.Name = "channellTimer7";
            this.channellTimer7.Size = new System.Drawing.Size(170, 25);
            this.channellTimer7.TabIndex = 0;
            this.channellTimer7.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer7.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer8
            // 
            this.channellTimer8.AutoSize = true;
            this.channellTimer8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer8.ChannelName = "Med C1";
            this.channellTimer8.Index = 0;
            this.channellTimer8.Location = new System.Drawing.Point(0, 25);
            this.channellTimer8.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer8.Name = "channellTimer8";
            this.channellTimer8.Size = new System.Drawing.Size(170, 25);
            this.channellTimer8.TabIndex = 1;
            this.channellTimer8.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer8.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer9
            // 
            this.channellTimer9.AutoSize = true;
            this.channellTimer9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer9.ChannelName = "Med C2";
            this.channellTimer9.Index = 0;
            this.channellTimer9.Location = new System.Drawing.Point(0, 50);
            this.channellTimer9.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer9.Name = "channellTimer9";
            this.channellTimer9.Size = new System.Drawing.Size(170, 25);
            this.channellTimer9.TabIndex = 2;
            this.channellTimer9.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer9.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer10
            // 
            this.channellTimer10.AutoSize = true;
            this.channellTimer10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer10.ChannelName = "Val C1";
            this.channellTimer10.Index = 0;
            this.channellTimer10.Location = new System.Drawing.Point(0, 75);
            this.channellTimer10.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer10.Name = "channellTimer10";
            this.channellTimer10.Size = new System.Drawing.Size(170, 25);
            this.channellTimer10.TabIndex = 3;
            this.channellTimer10.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer10.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer11
            // 
            this.channellTimer11.AutoSize = true;
            this.channellTimer11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer11.ChannelName = "Val C2";
            this.channellTimer11.Index = 0;
            this.channellTimer11.Location = new System.Drawing.Point(0, 100);
            this.channellTimer11.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer11.Name = "channellTimer11";
            this.channellTimer11.Size = new System.Drawing.Size(170, 25);
            this.channellTimer11.TabIndex = 4;
            this.channellTimer11.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer11.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer12
            // 
            this.channellTimer12.AutoSize = true;
            this.channellTimer12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer12.ChannelName = "Val C3";
            this.channellTimer12.Index = 0;
            this.channellTimer12.Location = new System.Drawing.Point(0, 125);
            this.channellTimer12.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer12.Name = "channellTimer12";
            this.channellTimer12.Size = new System.Drawing.Size(170, 25);
            this.channellTimer12.TabIndex = 5;
            this.channellTimer12.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer12.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channelContainerLeft
            // 
            this.channelContainerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelContainerLeft.Controls.Add(this.channellTimer1);
            this.channelContainerLeft.Controls.Add(this.channellTimer2);
            this.channelContainerLeft.Controls.Add(this.channellTimer3);
            this.channelContainerLeft.Controls.Add(this.channellTimer4);
            this.channelContainerLeft.Controls.Add(this.channellTimer5);
            this.channelContainerLeft.Controls.Add(this.channellTimer6);
            this.channelContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelContainerLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.channelContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.channelContainerLeft.Margin = new System.Windows.Forms.Padding(0);
            this.channelContainerLeft.Name = "channelContainerLeft";
            this.channelContainerLeft.Size = new System.Drawing.Size(171, 405);
            this.channelContainerLeft.TabIndex = 0;
            // 
            // channellTimer1
            // 
            this.channellTimer1.AutoSize = true;
            this.channellTimer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer1.ChannelName = "Velia C1";
            this.channellTimer1.Index = 0;
            this.channellTimer1.Location = new System.Drawing.Point(0, 0);
            this.channellTimer1.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer1.Name = "channellTimer1";
            this.channellTimer1.Size = new System.Drawing.Size(170, 25);
            this.channellTimer1.TabIndex = 0;
            this.channellTimer1.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer1.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer2
            // 
            this.channellTimer2.AutoSize = true;
            this.channellTimer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer2.ChannelName = "Bal C1";
            this.channellTimer2.Index = 0;
            this.channellTimer2.Location = new System.Drawing.Point(0, 25);
            this.channellTimer2.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer2.Name = "channellTimer2";
            this.channellTimer2.Size = new System.Drawing.Size(170, 25);
            this.channellTimer2.TabIndex = 1;
            this.channellTimer2.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer2.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer3
            // 
            this.channellTimer3.AutoSize = true;
            this.channellTimer3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer3.ChannelName = "Bal C2";
            this.channellTimer3.Index = 0;
            this.channellTimer3.Location = new System.Drawing.Point(0, 50);
            this.channellTimer3.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer3.Name = "channellTimer3";
            this.channellTimer3.Size = new System.Drawing.Size(170, 25);
            this.channellTimer3.TabIndex = 2;
            this.channellTimer3.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer3.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer4
            // 
            this.channellTimer4.AutoSize = true;
            this.channellTimer4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer4.ChannelName = "Cal C1";
            this.channellTimer4.Index = 0;
            this.channellTimer4.Location = new System.Drawing.Point(0, 75);
            this.channellTimer4.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer4.Name = "channellTimer4";
            this.channellTimer4.Size = new System.Drawing.Size(170, 25);
            this.channellTimer4.TabIndex = 3;
            this.channellTimer4.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer4.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer5
            // 
            this.channellTimer5.AutoSize = true;
            this.channellTimer5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer5.ChannelName = "Cal C2";
            this.channellTimer5.Index = 0;
            this.channellTimer5.Location = new System.Drawing.Point(0, 100);
            this.channellTimer5.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer5.Name = "channellTimer5";
            this.channellTimer5.Size = new System.Drawing.Size(170, 25);
            this.channellTimer5.TabIndex = 4;
            this.channellTimer5.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer5.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // channellTimer6
            // 
            this.channellTimer6.AutoSize = true;
            this.channellTimer6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.channellTimer6.ChannelName = "Ser C1";
            this.channellTimer6.Index = 0;
            this.channellTimer6.Location = new System.Drawing.Point(0, 125);
            this.channellTimer6.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer6.Name = "channellTimer6";
            this.channellTimer6.Size = new System.Drawing.Size(170, 25);
            this.channellTimer6.TabIndex = 5;
            this.channellTimer6.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            this.channellTimer6.OnExpandClicked += new System.EventHandler(this.channelTimer_OnExpandClicked);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(320, 25);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Spot Name";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HorseSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(345, 430);
            this.MinimumSize = new System.Drawing.Size(345, 430);
            this.Name = "HorseSpot";
            this.Size = new System.Drawing.Size(345, 430);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.channelContainerRight.ResumeLayout(false);
            this.channelContainerRight.PerformLayout();
            this.channelContainerLeft.ResumeLayout(false);
            this.channelContainerLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.FlowLayoutPanel channelContainerLeft;
        private ChannellTimer channellTimer1;
        private ChannellTimer channellTimer2;
        private ChannellTimer channellTimer3;
        private System.Windows.Forms.FlowLayoutPanel channelContainerRight;
        private ChannellTimer channellTimer7;
        private ChannellTimer channellTimer8;
        private ChannellTimer channellTimer9;
        private ChannellTimer channellTimer10;
        private ChannellTimer channellTimer11;
        private ChannellTimer channellTimer12;
        private ChannellTimer channellTimer4;
        private ChannellTimer channellTimer5;
        private ChannellTimer channellTimer6;
    }
}
