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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_saveConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar_smoothingPower = new System.Windows.Forms.TrackBar();
            this.textBox_smoothingPower = new System.Windows.Forms.TextBox();
            this.toolTip_smoothingOnOff = new System.Windows.Forms.ToolTip(this.components);
            this.MouseDragBtn = new System.Windows.Forms.Button();
            this.MouseDoubleBtn = new System.Windows.Forms.Button();
            this.MouseRightBtn = new System.Windows.Forms.Button();
            this.MouseLeftBtn = new System.Windows.Forms.Button();
            this.MouseResetBtn = new System.Windows.Forms.Button();
            this.StabilizationBtn = new System.Windows.Forms.Button();
            this.button_smoothOnOff = new System.Windows.Forms.Button();
            this.toolTip_toggleOverScreen = new System.Windows.Forms.ToolTip(this.components);
            this.SotBtn = new System.Windows.Forms.Button();
            this.button_toggleDisplay = new System.Windows.Forms.Button();
            this.toolTip_cursorColor = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smoothingPower)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.ToolStripMenuItem_help});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(133, 24);
            this.menu.TabIndex = 0;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_saveConfig,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_exit});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.testToolStripMenuItem.Text = "File";
            // 
            // ToolStripMenuItem_saveConfig
            // 
            this.ToolStripMenuItem_saveConfig.Name = "ToolStripMenuItem_saveConfig";
            this.ToolStripMenuItem_saveConfig.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_saveConfig.Text = "Save Config";
            this.ToolStripMenuItem_saveConfig.Click += new System.EventHandler(this.ToolStripMenuItem_saveConfig_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_exit.Text = "Exit";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // ToolStripMenuItem_help
            // 
            this.ToolStripMenuItem_help.Name = "ToolStripMenuItem_help";
            this.ToolStripMenuItem_help.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItem_help.Text = "Help";
            this.ToolStripMenuItem_help.Click += new System.EventHandler(this.ToolStripMenuItem_help_Click);
            // 
            // trackBar_smoothingPower
            // 
            this.trackBar_smoothingPower.Location = new System.Drawing.Point(98, 55);
            this.trackBar_smoothingPower.Maximum = 100;
            this.trackBar_smoothingPower.Minimum = 1;
            this.trackBar_smoothingPower.Name = "trackBar_smoothingPower";
            this.trackBar_smoothingPower.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_smoothingPower.Size = new System.Drawing.Size(45, 667);
            this.trackBar_smoothingPower.TabIndex = 1;
            this.trackBar_smoothingPower.TickFrequency = 10;
            this.trackBar_smoothingPower.Value = 30;
            this.trackBar_smoothingPower.Scroll += new System.EventHandler(this.TrackBarSmoothPower);
            // 
            // textBox_smoothingPower
            // 
            this.textBox_smoothingPower.Location = new System.Drawing.Point(98, 40);
            this.textBox_smoothingPower.MaxLength = 3;
            this.textBox_smoothingPower.Name = "textBox_smoothingPower";
            this.textBox_smoothingPower.Size = new System.Drawing.Size(26, 20);
            this.textBox_smoothingPower.TabIndex = 4;
            this.textBox_smoothingPower.Text = "30";
            this.textBox_smoothingPower.TextChanged += new System.EventHandler(this.TextBoxSmoothingPower);
            // 
            // MouseDragBtn
            // 
            this.MouseDragBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MouseDragBtn.BackgroundImage = global::Staby.Properties.Resources.dragdrop;
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
            this.MouseDragBtn.MouseHover += new System.EventHandler(this.MouseDragClick);
            // 
            // MouseDoubleBtn
            // 
            this.MouseDoubleBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.MouseDoubleBtn.BackgroundImage = global::Staby.Properties.Resources._2l_click;
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
            this.MouseRightBtn.BackgroundImage = global::Staby.Properties.Resources.r_click;
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
            this.MouseLeftBtn.BackgroundImage = global::Staby.Properties.Resources.l_click;
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
            this.MouseResetBtn.BackgroundImage = global::Staby.Properties.Resources.cancel;
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
            this.StabilizationBtn.BackgroundImage = global::Staby.Properties.Resources.stabilisation;
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
            this.button_smoothOnOff.BackgroundImage = global::Staby.Properties.Resources.smoothing;
            this.button_smoothOnOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_smoothOnOff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_smoothOnOff.Location = new System.Drawing.Point(12, 470);
            this.button_smoothOnOff.Name = "button_smoothOnOff";
            this.button_smoothOnOff.Size = new System.Drawing.Size(80, 80);
            this.button_smoothOnOff.TabIndex = 2;
            this.button_smoothOnOff.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.button_smoothOnOff, "Turn smoothing on/off");
            this.button_smoothOnOff.UseVisualStyleBackColor = false;
            this.button_smoothOnOff.Click += new System.EventHandler(this.SmoothOnOffClickBtn);
            this.button_smoothOnOff.MouseHover += new System.EventHandler(this.SmoothOnOffClickBtn);
            // 
            // SotBtn
            // 
            this.SotBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.SotBtn.BackgroundImage = global::Staby.Properties.Resources.fleche_haut;
            this.SotBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SotBtn.Location = new System.Drawing.Point(12, 556);
            this.SotBtn.Name = "SotBtn";
            this.SotBtn.Size = new System.Drawing.Size(80, 80);
            this.SotBtn.TabIndex = 12;
            this.SotBtn.TabStop = false;
            this.toolTip_toggleOverScreen.SetToolTip(this.SotBtn, "Turn stay on top on/off");
            this.SotBtn.UseVisualStyleBackColor = false;
            this.SotBtn.Click += new System.EventHandler(this.SotClickBtn);
            // 
            // button_toggleDisplay
            // 
            this.button_toggleDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.button_toggleDisplay.BackgroundImage = global::Staby.Properties.Resources.toggledisplay;
            this.button_toggleDisplay.Location = new System.Drawing.Point(95, 0);
            this.button_toggleDisplay.Name = "button_toggleDisplay";
            this.button_toggleDisplay.Size = new System.Drawing.Size(26, 26);
            this.button_toggleDisplay.TabIndex = 5;
            this.toolTip_toggleOverScreen.SetToolTip(this.button_toggleDisplay, "Toggle which screen displays the overlay");
            this.button_toggleDisplay.UseVisualStyleBackColor = false;
            this.button_toggleDisplay.Click += new System.EventHandler(this.DisplayOverlayBtn);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(133, 750);
            this.Controls.Add(this.textBox_smoothingPower);
            this.Controls.Add(this.SotBtn);
            this.Controls.Add(this.MouseDragBtn);
            this.Controls.Add(this.trackBar_smoothingPower);
            this.Controls.Add(this.MouseDoubleBtn);
            this.Controls.Add(this.MouseRightBtn);
            this.Controls.Add(this.MouseLeftBtn);
            this.Controls.Add(this.MouseResetBtn);
            this.Controls.Add(this.StabilizationBtn);
            this.Controls.Add(this.button_toggleDisplay);
            this.Controls.Add(this.button_smoothOnOff);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Staby";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smoothingPower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_help;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolTip toolTip_smoothingOnOff;
        private System.Windows.Forms.ToolTip toolTip_toggleOverScreen;
        private System.Windows.Forms.ToolTip toolTip_cursorColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.Button button_smoothOnOff;
        public System.Windows.Forms.Button button_toggleDisplay;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_saveConfig;
        public System.Windows.Forms.TextBox textBox_smoothingPower;
        public System.Windows.Forms.Button StabilizationBtn;
        public System.Windows.Forms.Button MouseResetBtn;
        public System.Windows.Forms.Button MouseLeftBtn;
        public System.Windows.Forms.Button MouseRightBtn;
        public System.Windows.Forms.Button MouseDoubleBtn;
        public System.Windows.Forms.Button MouseDragBtn;
        private System.Windows.Forms.Button SotBtn;
        public System.Windows.Forms.TrackBar trackBar_smoothingPower;
    }
}

