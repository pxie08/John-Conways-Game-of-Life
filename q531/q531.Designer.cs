namespace q531
{
    partial class q531
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.toggleButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackbarLabel = new System.Windows.Forms.Label();
            this.fasterlabel = new System.Windows.Forms.Label();
            this.slowerLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.presetCombo = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 418);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(90, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // toggleButton
            // 
            this.toggleButton.Location = new System.Drawing.Point(12, 447);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(90, 23);
            this.toggleButton.TabIndex = 1;
            this.toggleButton.Text = "Set Alive Cells";
            this.toggleButton.UseVisualStyleBackColor = true;
            this.toggleButton.Click += new System.EventHandler(this.toggleButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 300;
            this.trackBar1.Location = new System.Drawing.Point(139, 439);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(150, 45);
            this.trackBar1.SmallChange = 100;
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 800;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackbarLabel
            // 
            this.trackbarLabel.AutoSize = true;
            this.trackbarLabel.Location = new System.Drawing.Point(148, 423);
            this.trackbarLabel.Name = "trackbarLabel";
            this.trackbarLabel.Size = new System.Drawing.Size(102, 13);
            this.trackbarLabel.TabIndex = 3;
            this.trackbarLabel.Text = "Speed of Animation:";
            // 
            // fasterlabel
            // 
            this.fasterlabel.AutoSize = true;
            this.fasterlabel.Location = new System.Drawing.Point(108, 439);
            this.fasterlabel.Name = "fasterlabel";
            this.fasterlabel.Size = new System.Drawing.Size(36, 13);
            this.fasterlabel.TabIndex = 4;
            this.fasterlabel.Text = "Faster";
            // 
            // slowerLabel
            // 
            this.slowerLabel.AutoSize = true;
            this.slowerLabel.Location = new System.Drawing.Point(280, 439);
            this.slowerLabel.Name = "slowerLabel";
            this.slowerLabel.Size = new System.Drawing.Size(39, 13);
            this.slowerLabel.TabIndex = 5;
            this.slowerLabel.Text = "Slower";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(247, 423);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(25, 13);
            this.intervalLabel.TabIndex = 6;
            this.intervalLabel.Text = "800";
            // 
            // presetCombo
            // 
            this.presetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetCombo.FormattingEnabled = true;
            this.presetCombo.Items.AddRange(new object[] {
            "Glider",
            "Small Exploder",
            "Exploder",
            "10 Cell Row",
            "Lightweight Spaceship",
            "Tumbler"});
            this.presetCombo.Location = new System.Drawing.Point(111, 478);
            this.presetCombo.Name = "presetCombo";
            this.presetCombo.Size = new System.Drawing.Size(139, 21);
            this.presetCombo.TabIndex = 7;
            this.presetCombo.SelectedIndexChanged += new System.EventHandler(this.presetCombo_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 476);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // q531
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 507);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.presetCombo);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.slowerLabel);
            this.Controls.Add(this.fasterlabel);
            this.Controls.Add(this.trackbarLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.toggleButton);
            this.Controls.Add(this.startButton);
            this.Name = "q531";
            this.Text = "Quest 531 -- Patrick Xie";
            this.Load += new System.EventHandler(this.q531_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button toggleButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label trackbarLabel;
        private System.Windows.Forms.Label fasterlabel;
        private System.Windows.Forms.Label slowerLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.ComboBox presetCombo;
        private System.Windows.Forms.Button clearButton;

    }
}

