namespace Cube3D
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.Display = new System.Windows.Forms.PictureBox();
			this.ColorEditor = new System.Windows.Forms.Panel();
			this.Color_pictureBox = new System.Windows.Forms.PictureBox();
			this.Blue_UpDown = new System.Windows.Forms.NumericUpDown();
			this.Green_UpDown = new System.Windows.Forms.NumericUpDown();
			this.Red_UpDown = new System.Windows.Forms.NumericUpDown();
			this.Blue_label = new System.Windows.Forms.Label();
			this.Green_label = new System.Windows.Forms.Label();
			this.Red_label = new System.Windows.Forms.Label();
			this.BlueChannel_trackBar = new System.Windows.Forms.TrackBar();
			this.GreenChannel_trackBar = new System.Windows.Forms.TrackBar();
			this.RedChannel_trackBar = new System.Windows.Forms.TrackBar();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.offset_UpDown = new System.Windows.Forms.NumericUpDown();
			this.offset_label = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
			this.ColorEditor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Color_pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Blue_UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Green_UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Red_UpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueChannel_trackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GreenChannel_trackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RedChannel_trackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.offset_UpDown)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1199, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
			this.toolStripMenuItem1.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_MenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_MenuItem_click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
			this.aboutToolStripMenuItem.Text = "Program";
			// 
			// instructionsToolStripMenuItem
			// 
			this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
			this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
			this.instructionsToolStripMenuItem.Text = "Instructions";
			this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
			// 
			// Display
			// 
			this.Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Display.InitialImage = null;
			this.Display.Location = new System.Drawing.Point(-5, 31);
			this.Display.Name = "Display";
			this.Display.Size = new System.Drawing.Size(890, 616);
			this.Display.TabIndex = 1;
			this.Display.TabStop = false;
			this.Display.Click += new System.EventHandler(this.Display_Click);
			this.Display.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Display_MouseClick);
			this.Display.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Display_PreviewKeyDown);
			this.Display.Resize += new System.EventHandler(this.Display_Resize);
			// 
			// ColorEditor
			// 
			this.ColorEditor.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.ColorEditor.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ColorEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ColorEditor.Controls.Add(this.Color_pictureBox);
			this.ColorEditor.Controls.Add(this.Blue_UpDown);
			this.ColorEditor.Controls.Add(this.Green_UpDown);
			this.ColorEditor.Controls.Add(this.Red_UpDown);
			this.ColorEditor.Controls.Add(this.Blue_label);
			this.ColorEditor.Controls.Add(this.Green_label);
			this.ColorEditor.Controls.Add(this.Red_label);
			this.ColorEditor.Controls.Add(this.BlueChannel_trackBar);
			this.ColorEditor.Controls.Add(this.GreenChannel_trackBar);
			this.ColorEditor.Controls.Add(this.RedChannel_trackBar);
			this.ColorEditor.Location = new System.Drawing.Point(891, 150);
			this.ColorEditor.Name = "ColorEditor";
			this.ColorEditor.Size = new System.Drawing.Size(308, 497);
			this.ColorEditor.TabIndex = 2;
			// 
			// Color_pictureBox
			// 
			this.Color_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Color_pictureBox.Location = new System.Drawing.Point(60, 60);
			this.Color_pictureBox.Name = "Color_pictureBox";
			this.Color_pictureBox.Size = new System.Drawing.Size(140, 110);
			this.Color_pictureBox.TabIndex = 12;
			this.Color_pictureBox.TabStop = false;
			this.Color_pictureBox.BackColorChanged += new System.EventHandler(this.Color_pictureBox_BackColorChanged);
			// 
			// Blue_UpDown
			// 
			this.Blue_UpDown.Location = new System.Drawing.Point(206, 352);
			this.Blue_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.Blue_UpDown.Name = "Blue_UpDown";
			this.Blue_UpDown.Size = new System.Drawing.Size(73, 22);
			this.Blue_UpDown.TabIndex = 10;
			this.Blue_UpDown.ValueChanged += new System.EventHandler(this.Blue_UpDown_ValueChanged);
			// 
			// Green_UpDown
			// 
			this.Green_UpDown.Location = new System.Drawing.Point(206, 290);
			this.Green_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.Green_UpDown.Name = "Green_UpDown";
			this.Green_UpDown.Size = new System.Drawing.Size(73, 22);
			this.Green_UpDown.TabIndex = 9;
			this.Green_UpDown.ValueChanged += new System.EventHandler(this.Green_UpDown_ValueChanged);
			// 
			// Red_UpDown
			// 
			this.Red_UpDown.Location = new System.Drawing.Point(206, 228);
			this.Red_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.Red_UpDown.Name = "Red_UpDown";
			this.Red_UpDown.Size = new System.Drawing.Size(73, 22);
			this.Red_UpDown.TabIndex = 8;
			this.Red_UpDown.ValueChanged += new System.EventHandler(this.Red_UpDown_ValueChanged);
			// 
			// Blue_label
			// 
			this.Blue_label.AutoSize = true;
			this.Blue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Blue_label.Location = new System.Drawing.Point(33, 351);
			this.Blue_label.Name = "Blue_label";
			this.Blue_label.Size = new System.Drawing.Size(21, 20);
			this.Blue_label.TabIndex = 6;
			this.Blue_label.Text = "B";
			// 
			// Green_label
			// 
			this.Green_label.AutoSize = true;
			this.Green_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Green_label.Location = new System.Drawing.Point(33, 289);
			this.Green_label.Name = "Green_label";
			this.Green_label.Size = new System.Drawing.Size(22, 20);
			this.Green_label.TabIndex = 5;
			this.Green_label.Text = "G";
			// 
			// Red_label
			// 
			this.Red_label.AutoSize = true;
			this.Red_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Red_label.Location = new System.Drawing.Point(33, 227);
			this.Red_label.Name = "Red_label";
			this.Red_label.Size = new System.Drawing.Size(21, 20);
			this.Red_label.TabIndex = 4;
			this.Red_label.Text = "R";
			// 
			// BlueChannel_trackBar
			// 
			this.BlueChannel_trackBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.BlueChannel_trackBar.Location = new System.Drawing.Point(60, 351);
			this.BlueChannel_trackBar.Maximum = 255;
			this.BlueChannel_trackBar.Name = "BlueChannel_trackBar";
			this.BlueChannel_trackBar.Size = new System.Drawing.Size(140, 56);
			this.BlueChannel_trackBar.TabIndex = 2;
			this.BlueChannel_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// GreenChannel_trackBar
			// 
			this.GreenChannel_trackBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.GreenChannel_trackBar.Location = new System.Drawing.Point(60, 289);
			this.GreenChannel_trackBar.Maximum = 255;
			this.GreenChannel_trackBar.Name = "GreenChannel_trackBar";
			this.GreenChannel_trackBar.Size = new System.Drawing.Size(140, 56);
			this.GreenChannel_trackBar.TabIndex = 1;
			this.GreenChannel_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// RedChannel_trackBar
			// 
			this.RedChannel_trackBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.RedChannel_trackBar.Location = new System.Drawing.Point(60, 227);
			this.RedChannel_trackBar.Maximum = 255;
			this.RedChannel_trackBar.Name = "RedChannel_trackBar";
			this.RedChannel_trackBar.Size = new System.Drawing.Size(140, 56);
			this.RedChannel_trackBar.TabIndex = 0;
			this.RedChannel_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 28);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 619);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// offset_UpDown
			// 
			this.offset_UpDown.Location = new System.Drawing.Point(141, 53);
			this.offset_UpDown.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
			this.offset_UpDown.Name = "offset_UpDown";
			this.offset_UpDown.Size = new System.Drawing.Size(73, 22);
			this.offset_UpDown.TabIndex = 13;
			// 
			// offset_label
			// 
			this.offset_label.AutoSize = true;
			this.offset_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.offset_label.Location = new System.Drawing.Point(80, 53);
			this.offset_label.Name = "offset_label";
			this.offset_label.Size = new System.Drawing.Size(55, 20);
			this.offset_label.TabIndex = 14;
			this.offset_label.Text = "Offset";
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.offset_label);
			this.panel2.Controls.Add(this.offset_UpDown);
			this.panel2.Location = new System.Drawing.Point(891, 31);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(308, 118);
			this.panel2.TabIndex = 15;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.ClientSize = new System.Drawing.Size(1199, 647);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.ColorEditor);
			this.Controls.Add(this.Display);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
			this.ColorEditor.ResumeLayout(false);
			this.ColorEditor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Color_pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Blue_UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Green_UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Red_UpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BlueChannel_trackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GreenChannel_trackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RedChannel_trackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.offset_UpDown)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.PictureBox Display;
		private System.Windows.Forms.Panel ColorEditor;
		private System.Windows.Forms.TrackBar RedChannel_trackBar;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TrackBar BlueChannel_trackBar;
		private System.Windows.Forms.TrackBar GreenChannel_trackBar;
		private System.Windows.Forms.Label Blue_label;
		private System.Windows.Forms.Label Green_label;
		private System.Windows.Forms.Label Red_label;
		private System.Windows.Forms.PictureBox Color_pictureBox;
		private System.Windows.Forms.NumericUpDown Blue_UpDown;
		private System.Windows.Forms.NumericUpDown Green_UpDown;
		private System.Windows.Forms.NumericUpDown Red_UpDown;
		private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.Label offset_label;
		private System.Windows.Forms.NumericUpDown offset_UpDown;
		private System.Windows.Forms.Panel panel2;
	}
}

