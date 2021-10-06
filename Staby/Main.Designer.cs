namespace Staby
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_saveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_restoreDefaults = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar_smoothingStrength = new System.Windows.Forms.TrackBar();
            this.textBox_smoothingStrength = new System.Windows.Forms.TextBox();
            this.toolTip_smoothingOnOff = new System.Windows.Forms.ToolTip(this.components);
            this.MouseDragBtn = new System.Windows.Forms.Button();
            this.MouseDoubleBtn = new System.Windows.Forms.Button();
            this.MouseRightBtn = new System.Windows.Forms.Button();
            this.MouseLeftBtn = new System.Windows.Forms.Button();
            this.MouseResetBtn = new System.Windows.Forms.Button();
            this.StabilizationBtn = new System.Windows.Forms.Button();
            this.button_smoothOnOff = new System.Windows.Forms.Button();
            this.SotBtn = new System.Windows.Forms.Button();
            this.toolTip_toggleOverScreen = new System.Windows.Forms.ToolTip(this.components);
            this.button_toggleDisplay = new System.Windows.Forms.Button();
            this.toolTip_cursorColor = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smoothingStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(133, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_saveConfig,
            this.ToolStripMenuItem_restoreDefaults,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_exit});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.testToolStripMenuItem.Text = "File";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_saveConfig
            // 
            this.ToolStripMenuItem_saveConfig.Name = "ToolStripMenuItem_saveConfig";
            this.ToolStripMenuItem_saveConfig.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItem_saveConfig.Text = "Save Config";
            this.ToolStripMenuItem_saveConfig.Click += new System.EventHandler(this.ToolStripMenuItem_saveConfig_Click);
            // 
            // ToolStripMenuItem_restoreDefaults
            // 
            this.ToolStripMenuItem_restoreDefaults.Name = "ToolStripMenuItem_restoreDefaults";
            this.ToolStripMenuItem_restoreDefaults.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItem_restoreDefaults.Text = "Restore Defaults";
            this.ToolStripMenuItem_restoreDefaults.Click += new System.EventHandler(this.ToolStripMenuItem_restoreDefaults_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(159, 22);
            this.ToolStripMenuItem_exit.Text = "Exit";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // trackBar_smoothingStrength
            // 
            this.trackBar_smoothingStrength.Location = new System.Drawing.Point(98, 55);
            this.trackBar_smoothingStrength.Maximum = 200;
            this.trackBar_smoothingStrength.Minimum = 1;
            this.trackBar_smoothingStrength.Name = "trackBar_smoothingStrength";
            this.trackBar_smoothingStrength.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_smoothingStrength.Size = new System.Drawing.Size(45, 667);
            this.trackBar_smoothingStrength.TabIndex = 1;
            this.trackBar_smoothingStrength.TickFrequency = 10;
            this.trackBar_smoothingStrength.Value = 30;
            this.trackBar_smoothingStrength.Scroll += new System.EventHandler(this.trackBar_smoothStrength_Scroll);
            // 
            // textBox_smoothingStrength
            // 
            this.textBox_smoothingStrength.Location = new System.Drawing.Point(98, 40);
            this.textBox_smoothingStrength.MaxLength = 3;
            this.textBox_smoothingStrength.Name = "textBox_smoothingStrength";
            this.textBox_smoothingStrength.Size = new System.Drawing.Size(26, 20);
            this.textBox_smoothingStrength.TabIndex = 4;
            this.textBox_smoothingStrength.Text = "30";
            this.textBox_smoothingStrength.TextChanged += new System.EventHandler(this.textBox_smoothingStrength_TextChanged);
            // 
            // MouseDragBtn
            // 
            this.MouseDragBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MouseDragBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MouseDragBtn.BackgroundImage")));
            this.MouseDragBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MouseDragBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MouseDragBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseDragBtn.Location = new System.Drawing.Point(12, 384);
            this.MouseDragBtn.Name = "MouseDragBtn";
            this.MouseDragBtn.Size = new System.Drawing.Size(80, 80);
            this.MouseDragBtn.TabIndex = 11;
            this.MouseDragBtn.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.MouseDragBtn, "Drag and drop");
            this.MouseDragBtn.UseVisualStyleBackColor = false;
            this.MouseDragBtn.Click += new System.EventHandler(this.MouseDragBtn_Click);
            this.MouseDragBtn.MouseHover += new System.EventHandler(this.MouseDragClick);
            // 
            // MouseDoubleBtn
            // 
            this.MouseDoubleBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MouseDoubleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MouseDoubleBtn.BackgroundImage")));
            this.MouseDoubleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MouseDoubleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MouseDoubleBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseDoubleBtn.Location = new System.Drawing.Point(12, 298);
            this.MouseDoubleBtn.Name = "MouseDoubleBtn";
            this.MouseDoubleBtn.Size = new System.Drawing.Size(80, 80);
            this.MouseDoubleBtn.TabIndex = 10;
            this.MouseDoubleBtn.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.MouseDoubleBtn, "Double clique");
            this.MouseDoubleBtn.UseVisualStyleBackColor = false;
            this.MouseDoubleBtn.MouseHover += new System.EventHandler(this.MouseDoublClick);
            // 
            // MouseRightBtn
            // 
            this.MouseRightBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MouseRightBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MouseRightBtn.BackgroundImage")));
            this.MouseRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MouseRightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MouseRightBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseRightBtn.Location = new System.Drawing.Point(12, 212);
            this.MouseRightBtn.Name = "MouseRightBtn";
            this.MouseRightBtn.Size = new System.Drawing.Size(80, 80);
            this.MouseRightBtn.TabIndex = 9;
            this.MouseRightBtn.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.MouseRightBtn, "Clique droit");
            this.MouseRightBtn.UseVisualStyleBackColor = false;
            this.MouseRightBtn.MouseHover += new System.EventHandler(this.MouseRightClick);
            // 
            // MouseLeftBtn
            // 
            this.MouseLeftBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MouseLeftBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MouseLeftBtn.BackgroundImage")));
            this.MouseLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MouseLeftBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MouseLeftBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseLeftBtn.Location = new System.Drawing.Point(12, 126);
            this.MouseLeftBtn.Name = "MouseLeftBtn";
            this.MouseLeftBtn.Size = new System.Drawing.Size(80, 80);
            this.MouseLeftBtn.TabIndex = 8;
            this.MouseLeftBtn.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.MouseLeftBtn, "Clique gauche");
            this.MouseLeftBtn.UseVisualStyleBackColor = false;
            this.MouseLeftBtn.MouseHover += new System.EventHandler(this.MouseLeftClick);
            // 
            // MouseResetBtn
            // 
            this.MouseResetBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MouseResetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MouseResetBtn.BackgroundImage")));
            this.MouseResetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MouseResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MouseResetBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseResetBtn.Location = new System.Drawing.Point(12, 40);
            this.MouseResetBtn.Name = "MouseResetBtn";
            this.MouseResetBtn.Size = new System.Drawing.Size(80, 80);
            this.MouseResetBtn.TabIndex = 7;
            this.MouseResetBtn.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.MouseResetBtn, "Aucune action");
            this.MouseResetBtn.UseVisualStyleBackColor = false;
            this.MouseResetBtn.MouseHover += new System.EventHandler(this.MouseReset);
            // 
            // StabilizationBtn
            // 
            this.StabilizationBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.StabilizationBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StabilizationBtn.BackgroundImage")));
            this.StabilizationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StabilizationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StabilizationBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StabilizationBtn.Location = new System.Drawing.Point(12, 642);
            this.StabilizationBtn.Name = "StabilizationBtn";
            this.StabilizationBtn.Size = new System.Drawing.Size(80, 80);
            this.StabilizationBtn.TabIndex = 6;
            this.StabilizationBtn.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.StabilizationBtn, "Turn smoothing on/off");
            this.StabilizationBtn.UseVisualStyleBackColor = false;
            this.StabilizationBtn.Click += new System.EventHandler(this.Stabilization);
            // 
            // button_smoothOnOff
            // 
            this.button_smoothOnOff.BackColor = System.Drawing.Color.Gainsboro;
            this.button_smoothOnOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_smoothOnOff.BackgroundImage")));
            this.button_smoothOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_smoothOnOff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_smoothOnOff.Location = new System.Drawing.Point(12, 470);
            this.button_smoothOnOff.Name = "button_smoothOnOff";
            this.button_smoothOnOff.Size = new System.Drawing.Size(80, 80);
            this.button_smoothOnOff.TabIndex = 2;
            this.button_smoothOnOff.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.button_smoothOnOff, "Turn smoothing on/off");
            this.button_smoothOnOff.UseVisualStyleBackColor = false;
            this.button_smoothOnOff.Click += new System.EventHandler(this.button_SmoothOnOff_Click);
            this.button_smoothOnOff.MouseHover += new System.EventHandler(this.button_SmoothOnOff_Click);
            // 
            // SotBtn
            // 
            this.SotBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.SotBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SotBtn.BackgroundImage")));
            this.SotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SotBtn.Location = new System.Drawing.Point(12, 556);
            this.SotBtn.Name = "SotBtn";
            this.SotBtn.Size = new System.Drawing.Size(80, 80);
            this.SotBtn.TabIndex = 12;
            this.SotBtn.TabStop = false;
            this.toolTip_toggleOverScreen.SetToolTip(this.SotBtn, "Turn stay on top on/off");
            this.SotBtn.UseVisualStyleBackColor = false;
            this.SotBtn.Click += new System.EventHandler(this.SotBtn_Click);
            // 
            // button_toggleDisplay
            // 
            this.button_toggleDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.button_toggleDisplay.BackgroundImage = global::Staby.Properties.Resources.toggledisplay;
            this.button_toggleDisplay.Location = new System.Drawing.Point(36, 0);
            this.button_toggleDisplay.Name = "button_toggleDisplay";
            this.button_toggleDisplay.Size = new System.Drawing.Size(26, 26);
            this.button_toggleDisplay.TabIndex = 5;
            this.toolTip_toggleOverScreen.SetToolTip(this.button_toggleDisplay, "Toggle which screen displays the overlay");
            this.button_toggleDisplay.UseVisualStyleBackColor = false;
            this.button_toggleDisplay.Click += new System.EventHandler(this.button_displayOverlay);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(133, 750);
            this.Controls.Add(this.textBox_smoothingStrength);
            this.Controls.Add(this.SotBtn);
            this.Controls.Add(this.MouseDragBtn);
            this.Controls.Add(this.trackBar_smoothingStrength);
            this.Controls.Add(this.MouseDoubleBtn);
            this.Controls.Add(this.MouseRightBtn);
            this.Controls.Add(this.MouseLeftBtn);
            this.Controls.Add(this.MouseResetBtn);
            this.Controls.Add(this.StabilizationBtn);
            this.Controls.Add(this.button_toggleDisplay);
            this.Controls.Add(this.button_smoothOnOff);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Staby";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smoothingStrength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolTip toolTip_smoothingOnOff;
        private System.Windows.Forms.ToolTip toolTip_toggleOverScreen;
        private System.Windows.Forms.ToolTip toolTip_cursorColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.Button button_smoothOnOff;
        public System.Windows.Forms.Button button_toggleDisplay;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_saveConfig;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_restoreDefaults;
        public System.Windows.Forms.TrackBar trackBar_smoothingStrength;
        public System.Windows.Forms.TextBox textBox_smoothingStrength;
        public System.Windows.Forms.Button StabilizationBtn;
        public System.Windows.Forms.Button MouseResetBtn;
        public System.Windows.Forms.Button MouseLeftBtn;
        public System.Windows.Forms.Button MouseRightBtn;
        public System.Windows.Forms.Button MouseDoubleBtn;
        public System.Windows.Forms.Button MouseDragBtn;
        private System.Windows.Forms.Button SotBtn;
    }
}

