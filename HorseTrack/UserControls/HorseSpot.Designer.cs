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
            this.channelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.channellTimer12 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer11 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer10 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer9 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer8 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer7 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer6 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer5 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer4 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer3 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer2 = new HorseTrack.UserControls.ChannellTimer();
            this.channellTimer1 = new HorseTrack.UserControls.ChannellTimer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.channelContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // channelContainer
            // 
            this.channelContainer.ColumnCount = 4;
            this.channelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.channelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.channelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.channelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.channelContainer.Controls.Add(this.channellTimer12, 3, 2);
            this.channelContainer.Controls.Add(this.channellTimer11, 2, 2);
            this.channelContainer.Controls.Add(this.channellTimer10, 1, 2);
            this.channelContainer.Controls.Add(this.channellTimer9, 0, 2);
            this.channelContainer.Controls.Add(this.channellTimer8, 3, 1);
            this.channelContainer.Controls.Add(this.channellTimer7, 2, 1);
            this.channelContainer.Controls.Add(this.channellTimer6, 1, 1);
            this.channelContainer.Controls.Add(this.channellTimer5, 0, 1);
            this.channelContainer.Controls.Add(this.channellTimer4, 3, 0);
            this.channelContainer.Controls.Add(this.channellTimer3, 2, 0);
            this.channelContainer.Controls.Add(this.channellTimer2, 1, 0);
            this.channelContainer.Controls.Add(this.channellTimer1, 0, 0);
            this.channelContainer.Location = new System.Drawing.Point(0, 30);
            this.channelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.channelContainer.Name = "channelContainer";
            this.channelContainer.RowCount = 3;
            this.channelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.channelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.channelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.channelContainer.Size = new System.Drawing.Size(320, 240);
            this.channelContainer.TabIndex = 0;
            // 
            // channellTimer12
            // 
            this.channellTimer12.ChannelName = "Valencia C3";
            this.channellTimer12.Index = 11;
            this.channellTimer12.Location = new System.Drawing.Point(240, 160);
            this.channellTimer12.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer12.Name = "channellTimer12";
            this.channellTimer12.Size = new System.Drawing.Size(80, 80);
            this.channellTimer12.TabIndex = 11;
            this.channellTimer12.Ticks = 0;
            this.channellTimer12.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer11
            // 
            this.channellTimer11.ChannelName = "Valencia C2";
            this.channellTimer11.Index = 10;
            this.channellTimer11.Location = new System.Drawing.Point(160, 160);
            this.channellTimer11.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer11.Name = "channellTimer11";
            this.channellTimer11.Size = new System.Drawing.Size(80, 80);
            this.channellTimer11.TabIndex = 10;
            this.channellTimer11.Ticks = 0;
            this.channellTimer11.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer10
            // 
            this.channellTimer10.ChannelName = "Valencia C1";
            this.channellTimer10.Index = 9;
            this.channellTimer10.Location = new System.Drawing.Point(80, 160);
            this.channellTimer10.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer10.Name = "channellTimer10";
            this.channellTimer10.Size = new System.Drawing.Size(80, 80);
            this.channellTimer10.TabIndex = 9;
            this.channellTimer10.Ticks = 0;
            this.channellTimer10.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer9
            // 
            this.channellTimer9.ChannelName = "Mediah C2";
            this.channellTimer9.Index = 8;
            this.channellTimer9.Location = new System.Drawing.Point(0, 160);
            this.channellTimer9.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer9.Name = "channellTimer9";
            this.channellTimer9.Size = new System.Drawing.Size(80, 80);
            this.channellTimer9.TabIndex = 8;
            this.channellTimer9.Ticks = 0;
            this.channellTimer9.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer8
            // 
            this.channellTimer8.ChannelName = "Mediah C1";
            this.channellTimer8.Index = 7;
            this.channellTimer8.Location = new System.Drawing.Point(240, 80);
            this.channellTimer8.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer8.Name = "channellTimer8";
            this.channellTimer8.Size = new System.Drawing.Size(80, 80);
            this.channellTimer8.TabIndex = 7;
            this.channellTimer8.Ticks = 0;
            this.channellTimer8.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer7
            // 
            this.channellTimer7.ChannelName = "Serendia C2";
            this.channellTimer7.Index = 6;
            this.channellTimer7.Location = new System.Drawing.Point(160, 80);
            this.channellTimer7.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer7.Name = "channellTimer7";
            this.channellTimer7.Size = new System.Drawing.Size(80, 80);
            this.channellTimer7.TabIndex = 6;
            this.channellTimer7.Ticks = 0;
            this.channellTimer7.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer6
            // 
            this.channellTimer6.ChannelName = "Serendia C1";
            this.channellTimer6.Index = 5;
            this.channellTimer6.Location = new System.Drawing.Point(80, 80);
            this.channellTimer6.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer6.Name = "channellTimer6";
            this.channellTimer6.Size = new System.Drawing.Size(80, 80);
            this.channellTimer6.TabIndex = 5;
            this.channellTimer6.Ticks = 0;
            this.channellTimer6.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer5
            // 
            this.channellTimer5.ChannelName = "Calpheon C2";
            this.channellTimer5.Index = 4;
            this.channellTimer5.Location = new System.Drawing.Point(0, 80);
            this.channellTimer5.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer5.Name = "channellTimer5";
            this.channellTimer5.Size = new System.Drawing.Size(80, 80);
            this.channellTimer5.TabIndex = 4;
            this.channellTimer5.Ticks = 0;
            this.channellTimer5.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer4
            // 
            this.channellTimer4.ChannelName = "Calpheon C1";
            this.channellTimer4.Index = 3;
            this.channellTimer4.Location = new System.Drawing.Point(240, 0);
            this.channellTimer4.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer4.Name = "channellTimer4";
            this.channellTimer4.Size = new System.Drawing.Size(80, 80);
            this.channellTimer4.TabIndex = 3;
            this.channellTimer4.Ticks = 0;
            this.channellTimer4.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer3
            // 
            this.channellTimer3.ChannelName = "Balenos C2";
            this.channellTimer3.Index = 2;
            this.channellTimer3.Location = new System.Drawing.Point(160, 0);
            this.channellTimer3.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer3.Name = "channellTimer3";
            this.channellTimer3.Size = new System.Drawing.Size(80, 80);
            this.channellTimer3.TabIndex = 2;
            this.channellTimer3.Ticks = 0;
            this.channellTimer3.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer2
            // 
            this.channellTimer2.ChannelName = "Balenos C1";
            this.channellTimer2.Index = 1;
            this.channellTimer2.Location = new System.Drawing.Point(80, 0);
            this.channellTimer2.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer2.Name = "channellTimer2";
            this.channellTimer2.Size = new System.Drawing.Size(80, 80);
            this.channellTimer2.TabIndex = 1;
            this.channellTimer2.Ticks = 0;
            this.channellTimer2.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // channellTimer1
            // 
            this.channellTimer1.ChannelName = "Velia C1";
            this.channellTimer1.Index = 0;
            this.channellTimer1.Location = new System.Drawing.Point(0, 0);
            this.channellTimer1.Margin = new System.Windows.Forms.Padding(0);
            this.channellTimer1.Name = "channellTimer1";
            this.channellTimer1.Size = new System.Drawing.Size(80, 80);
            this.channellTimer1.TabIndex = 0;
            this.channellTimer1.Ticks = 0;
            this.channellTimer1.OnTimerStarted += new System.EventHandler(this.ChannelTimerStarted);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.channelContainer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(320, 270);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Controls.Add(this.lblCaption, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.lblClose, 1, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(320, 30);
            this.tableLayoutPanel15.TabIndex = 1;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoEllipsis = true;
            this.lblCaption.AutoSize = true;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(300, 30);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClose.Location = new System.Drawing.Point(300, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 30);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // HorseSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HorseSpot";
            this.Size = new System.Drawing.Size(320, 270);
            this.channelContainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel channelContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblClose;
        private ChannellTimer channellTimer12;
        private ChannellTimer channellTimer11;
        private ChannellTimer channellTimer10;
        private ChannellTimer channellTimer9;
        private ChannellTimer channellTimer8;
        private ChannellTimer channellTimer7;
        private ChannellTimer channellTimer6;
        private ChannellTimer channellTimer5;
        private ChannellTimer channellTimer4;
        private ChannellTimer channellTimer3;
        private ChannellTimer channellTimer2;
        private ChannellTimer channellTimer1;
    }
}
