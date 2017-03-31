namespace TimeShutD
{
    partial class TimeShut
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numHrs = new System.Windows.Forms.NumericUpDown();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bntShutdown = new System.Windows.Forms.Button();
            this.bntAbort = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.recentTimesBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguêsBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRecentTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.numHrs);
            this.flowLayoutPanel1.Controls.Add(this.HoursLabel);
            this.flowLayoutPanel1.Controls.Add(this.numMin);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 35);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(301, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // numHrs
            // 
            this.numHrs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numHrs.Location = new System.Drawing.Point(4, 4);
            this.numHrs.Margin = new System.Windows.Forms.Padding(4);
            this.numHrs.Name = "numHrs";
            this.numHrs.Size = new System.Drawing.Size(84, 22);
            this.numHrs.TabIndex = 0;
            this.numHrs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoursLabel
            // 
            this.HoursLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(96, 7);
            this.HoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(44, 16);
            this.HoursLabel.TabIndex = 2;
            this.HoursLabel.Text = "Hours";
            this.HoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMin
            // 
            this.numMin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numMin.Location = new System.Drawing.Point(148, 4);
            this.numMin.Margin = new System.Windows.Forms.Padding(4);
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(84, 22);
            this.numMin.TabIndex = 1;
            this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMin.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Minutes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntShutdown
            // 
            this.bntShutdown.Location = new System.Drawing.Point(174, 87);
            this.bntShutdown.Margin = new System.Windows.Forms.Padding(4);
            this.bntShutdown.Name = "bntShutdown";
            this.bntShutdown.Size = new System.Drawing.Size(100, 28);
            this.bntShutdown.TabIndex = 4;
            this.bntShutdown.Text = "Shutdown";
            this.bntShutdown.UseVisualStyleBackColor = true;
            this.bntShutdown.Click += new System.EventHandler(this.bntShutdown_Click);
            // 
            // bntAbort
            // 
            this.bntAbort.Location = new System.Drawing.Point(66, 87);
            this.bntAbort.Margin = new System.Windows.Forms.Padding(4);
            this.bntAbort.Name = "bntAbort";
            this.bntAbort.Size = new System.Drawing.Size(100, 28);
            this.bntAbort.TabIndex = 5;
            this.bntAbort.Text = "Abort";
            this.bntAbort.UseVisualStyleBackColor = true;
            this.bntAbort.Click += new System.EventHandler(this.bntAbort_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(23, 156);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(72, 15);
            this.InfoLabel.TabIndex = 6;
            this.InfoLabel.Text = "placeholder";
            // 
            // recentTimesBox
            // 
            this.recentTimesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recentTimesBox.FormattingEnabled = true;
            this.recentTimesBox.Location = new System.Drawing.Point(220, 153);
            this.recentTimesBox.Name = "recentTimesBox";
            this.recentTimesBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.recentTimesBox.Size = new System.Drawing.Size(107, 24);
            this.recentTimesBox.TabIndex = 8;
            this.recentTimesBox.SelectedIndexChanged += new System.EventHandler(this.recentTimesBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Recent times:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.extraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem,
            this.clearRecentTimesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.portuguêsBRToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckOnClick = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // portuguêsBRToolStripMenuItem
            // 
            this.portuguêsBRToolStripMenuItem.CheckOnClick = true;
            this.portuguêsBRToolStripMenuItem.Name = "portuguêsBRToolStripMenuItem";
            this.portuguêsBRToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.portuguêsBRToolStripMenuItem.Text = "Português(BR)";
            // 
            // clearRecentTimesToolStripMenuItem
            // 
            this.clearRecentTimesToolStripMenuItem.Name = "clearRecentTimesToolStripMenuItem";
            this.clearRecentTimesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.clearRecentTimesToolStripMenuItem.Text = "Clear recent times";
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // TimeShut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 192);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recentTimesBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bntShutdown);
            this.Controls.Add(this.bntAbort);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeShut";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timed Shutdown";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeShut_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numHrs;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntShutdown;
        private System.Windows.Forms.Button bntAbort;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.ComboBox recentTimesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portuguêsBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRecentTimesToolStripMenuItem;
    }
}

