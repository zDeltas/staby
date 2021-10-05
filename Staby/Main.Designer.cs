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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_smoothOnDraw = new System.Windows.Forms.CheckBox();
            this.checkBox_stayOnTop = new System.Windows.Forms.CheckBox();
            this.textBox_smoothingStrength = new System.Windows.Forms.TextBox();
            this.button_toggleDisplay = new System.Windows.Forms.Button();
            this.toolTip_smoothingOnOff = new System.Windows.Forms.ToolTip(this.components);
            this.button_smoothOnOff = new System.Windows.Forms.Button();
            this.toolTip_toggleOverScreen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_cursorColor = new System.Windows.Forms.ToolTip(this.components);
            this.button_colorDialog = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smoothingStrength)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // 
            // ToolStripMenuItem_saveConfig
            // 
            this.ToolStripMenuItem_saveConfig.Name = "ToolStripMenuItem_saveConfig";
            this.ToolStripMenuItem_saveConfig.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_saveConfig.Text = "Save Config";
            this.ToolStripMenuItem_saveConfig.Click += new System.EventHandler(this.ToolStripMenuItem_saveConfig_Click);
            // 
            // ToolStripMenuItem_restoreDefaults
            // 
            this.ToolStripMenuItem_restoreDefaults.Name = "ToolStripMenuItem_restoreDefaults";
            this.ToolStripMenuItem_restoreDefaults.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_restoreDefaults.Text = "Restore Defaults";
            this.ToolStripMenuItem_restoreDefaults.Click += new System.EventHandler(this.ToolStripMenuItem_restoreDefaults_Click);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_exit.Text = "Exit";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // trackBar_smoothingStrength
            // 
            this.trackBar_smoothingStrength.Location = new System.Drawing.Point(64, 5);
            this.trackBar_smoothingStrength.Maximum = 100;
            this.trackBar_smoothingStrength.Minimum = 1;
            this.trackBar_smoothingStrength.Name = "trackBar_smoothingStrength";
            this.trackBar_smoothingStrength.Size = new System.Drawing.Size(141, 45);
            this.trackBar_smoothingStrength.TabIndex = 1;
            this.trackBar_smoothingStrength.TickFrequency = 10;
            this.trackBar_smoothingStrength.Value = 30;
            this.trackBar_smoothingStrength.Scroll += new System.EventHandler(this.trackBar_smoothStrength_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Strength";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkBox_smoothOnDraw);
            this.panel1.Controls.Add(this.checkBox_stayOnTop);
            this.panel1.Controls.Add(this.textBox_smoothingStrength);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBar_smoothingStrength);
            this.panel1.Location = new System.Drawing.Point(84, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 60);
            this.panel1.TabIndex = 4;
            // 
            // checkBox_smoothOnDraw
            // 
            this.checkBox_smoothOnDraw.AutoSize = true;
            this.checkBox_smoothOnDraw.Location = new System.Drawing.Point(126, 33);
            this.checkBox_smoothOnDraw.Name = "checkBox_smoothOnDraw";
            this.checkBox_smoothOnDraw.Size = new System.Drawing.Size(107, 17);
            this.checkBox_smoothOnDraw.TabIndex = 9;
            this.checkBox_smoothOnDraw.Text = "Smooth On Draw";
            this.checkBox_smoothOnDraw.UseVisualStyleBackColor = true;
            // 
            // checkBox_stayOnTop
            // 
            this.checkBox_stayOnTop.AutoSize = true;
            this.checkBox_stayOnTop.Location = new System.Drawing.Point(6, 33);
            this.checkBox_stayOnTop.Name = "checkBox_stayOnTop";
            this.checkBox_stayOnTop.Size = new System.Drawing.Size(86, 17);
            this.checkBox_stayOnTop.TabIndex = 7;
            this.checkBox_stayOnTop.Text = "Stay On Top";
            this.checkBox_stayOnTop.UseVisualStyleBackColor = true;
            this.checkBox_stayOnTop.CheckedChanged += new System.EventHandler(this.checkBox_stayOnTop_CheckedChanged);
            // 
            // textBox_smoothingStrength
            // 
            this.textBox_smoothingStrength.Location = new System.Drawing.Point(207, 5);
            this.textBox_smoothingStrength.MaxLength = 3;
            this.textBox_smoothingStrength.Name = "textBox_smoothingStrength";
            this.textBox_smoothingStrength.Size = new System.Drawing.Size(26, 20);
            this.textBox_smoothingStrength.TabIndex = 4;
            this.textBox_smoothingStrength.Text = "30";
            this.textBox_smoothingStrength.TextChanged += new System.EventHandler(this.textBox_smoothingStrength_TextChanged);
            // 
            // button_toggleDisplay
            // 
            this.button_toggleDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.button_toggleDisplay.BackgroundImage = global::Staby.Properties.Resources.toggledisplay;
            this.button_toggleDisplay.Location = new System.Drawing.Point(12, 97);
            this.button_toggleDisplay.Name = "button_toggleDisplay";
            this.button_toggleDisplay.Size = new System.Drawing.Size(26, 26);
            this.button_toggleDisplay.TabIndex = 5;
            this.toolTip_toggleOverScreen.SetToolTip(this.button_toggleDisplay, "Toggle which screen displays the overlay");
            this.button_toggleDisplay.UseVisualStyleBackColor = false;
            this.button_toggleDisplay.Click += new System.EventHandler(this.button_toggleScreen_Click);
            // 
            // button_smoothOnOff
            // 
            this.button_smoothOnOff.BackColor = System.Drawing.Color.Gainsboro;
            this.button_smoothOnOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_smoothOnOff.BackgroundImage")));
            this.button_smoothOnOff.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_smoothOnOff.Location = new System.Drawing.Point(12, 31);
            this.button_smoothOnOff.Name = "button_smoothOnOff";
            this.button_smoothOnOff.Size = new System.Drawing.Size(60, 60);
            this.button_smoothOnOff.TabIndex = 2;
            this.button_smoothOnOff.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.button_smoothOnOff, "Turn smoothing on/off");
            this.button_smoothOnOff.UseVisualStyleBackColor = false;
            this.button_smoothOnOff.Click += new System.EventHandler(this.button_SmoothOnOff_Click);
            // 
            // button_colorDialog
            // 
            this.button_colorDialog.BackColor = System.Drawing.Color.Gainsboro;
            this.button_colorDialog.BackgroundImage = global::Staby.Properties.Resources.eyedropper;
            this.button_colorDialog.Location = new System.Drawing.Point(46, 97);
            this.button_colorDialog.Name = "button_colorDialog";
            this.button_colorDialog.Size = new System.Drawing.Size(26, 26);
            this.button_colorDialog.TabIndex = 5;
            this.toolTip_cursorColor.SetToolTip(this.button_colorDialog, "Change the virtual cursor\'s color");
            this.button_colorDialog.UseVisualStyleBackColor = false;
            this.button_colorDialog.Click += new System.EventHandler(this.button_colorDialog_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.BackgroundImage = global::Staby.Properties.Resources.stabi;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 60);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.toolTip_smoothingOnOff.SetToolTip(this.button1, "Turn smoothing on/off");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Stabilization);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(334, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_colorDialog);
            this.Controls.Add(this.button_toggleDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_smoothOnOff);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Staby";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_smoothingStrength)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolTip toolTip_smoothingOnOff;
        private System.Windows.Forms.ToolTip toolTip_toggleOverScreen;
        private System.Windows.Forms.ToolTip toolTip_cursorColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        public System.Windows.Forms.Button button_colorDialog;
        public System.Windows.Forms.Button button_smoothOnOff;
        public System.Windows.Forms.Button button_toggleDisplay;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_saveConfig;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_restoreDefaults;
        public System.Windows.Forms.TrackBar trackBar_smoothingStrength;
        public System.Windows.Forms.TextBox textBox_smoothingStrength;
        public System.Windows.Forms.CheckBox checkBox_stayOnTop;
        public System.Windows.Forms.CheckBox checkBox_smoothOnDraw;
        public System.Windows.Forms.Button button1;
    }
}

