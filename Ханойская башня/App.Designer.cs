namespace Ханойская_башня
{
	partial class App
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
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.ring0 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.column1 = new System.Windows.Forms.Button();
			this.column3 = new System.Windows.Forms.Button();
			this.up1 = new MaterialSkin.Controls.MaterialButton();
			this.down1 = new MaterialSkin.Controls.MaterialButton();
			this.up2 = new MaterialSkin.Controls.MaterialButton();
			this.up3 = new MaterialSkin.Controls.MaterialButton();
			this.down2 = new MaterialSkin.Controls.MaterialButton();
			this.down3 = new MaterialSkin.Controls.MaterialButton();
			this.ring1 = new System.Windows.Forms.Button();
			this.ring2 = new System.Windows.Forms.Button();
			this.ring3 = new System.Windows.Forms.Button();
			this.ring4 = new System.Windows.Forms.Button();
			this.ring5 = new System.Windows.Forms.Button();
			this.ring6 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timerLabel = new System.Windows.Forms.Label();
			this.stepsLabel = new System.Windows.Forms.Label();
			this.ring7 = new System.Windows.Forms.Button();
			this.column2 = new System.Windows.Forms.Button();
			this.danet = new MaterialSkin.Controls.MaterialButton();
			this.SuspendLayout();
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(178, 127);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(401, 72);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Управление: кнопками на форме";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ring0
			// 
			this.ring0.Location = new System.Drawing.Point(119, 345);
			this.ring0.Name = "ring0";
			this.ring0.Size = new System.Drawing.Size(30, 20);
			this.ring0.TabIndex = 2;
			this.ring0.Tag = "0";
			this.ring0.Text = "1";
			this.ring0.UseVisualStyleBackColor = true;
			// 
			// button25
			// 
			this.button25.Enabled = false;
			this.button25.Location = new System.Drawing.Point(24, 511);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(220, 10);
			this.button25.TabIndex = 25;
			this.button25.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Enabled = false;
			this.button9.Location = new System.Drawing.Point(280, 511);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(220, 10);
			this.button9.TabIndex = 26;
			this.button9.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Enabled = false;
			this.button10.Location = new System.Drawing.Point(536, 511);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(220, 10);
			this.button10.TabIndex = 27;
			this.button10.UseVisualStyleBackColor = true;
			// 
			// column1
			// 
			this.column1.Enabled = false;
			this.column1.Location = new System.Drawing.Point(128, 331);
			this.column1.Name = "column1";
			this.column1.Size = new System.Drawing.Size(10, 190);
			this.column1.TabIndex = 8;
			this.column1.Tag = "0";
			this.column1.UseVisualStyleBackColor = true;
			// 
			// column3
			// 
			this.column3.Enabled = false;
			this.column3.Location = new System.Drawing.Point(641, 331);
			this.column3.Name = "column3";
			this.column3.Size = new System.Drawing.Size(10, 190);
			this.column3.TabIndex = 0;
			this.column3.Tag = "8";
			this.column3.UseVisualStyleBackColor = true;
			// 
			// up1
			// 
			this.up1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.up1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.up1.Depth = 0;
			this.up1.HighEmphasis = true;
			this.up1.Icon = null;
			this.up1.Location = new System.Drawing.Point(88, 205);
			this.up1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.up1.MouseState = MaterialSkin.MouseState.HOVER;
			this.up1.Name = "up1";
			this.up1.NoAccentTextColor = System.Drawing.Color.Empty;
			this.up1.Size = new System.Drawing.Size(91, 36);
			this.up1.TabIndex = 34;
			this.up1.Text = "Поднять";
			this.up1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.up1.UseAccentColor = false;
			this.up1.UseVisualStyleBackColor = true;
			this.up1.Click += new System.EventHandler(this.up1_Click);
			// 
			// down1
			// 
			this.down1.AutoSize = false;
			this.down1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.down1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.down1.Depth = 0;
			this.down1.HighEmphasis = true;
			this.down1.Icon = null;
			this.down1.Location = new System.Drawing.Point(88, 253);
			this.down1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.down1.MouseState = MaterialSkin.MouseState.HOVER;
			this.down1.Name = "down1";
			this.down1.NoAccentTextColor = System.Drawing.Color.Empty;
			this.down1.Size = new System.Drawing.Size(91, 36);
			this.down1.TabIndex = 37;
			this.down1.Text = "Опустить";
			this.down1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.down1.UseAccentColor = false;
			this.down1.UseVisualStyleBackColor = true;
			this.down1.Click += new System.EventHandler(this.down1_Click);
			// 
			// up2
			// 
			this.up2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.up2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.up2.Depth = 0;
			this.up2.HighEmphasis = true;
			this.up2.Icon = null;
			this.up2.Location = new System.Drawing.Point(342, 205);
			this.up2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.up2.MouseState = MaterialSkin.MouseState.HOVER;
			this.up2.Name = "up2";
			this.up2.NoAccentTextColor = System.Drawing.Color.Empty;
			this.up2.Size = new System.Drawing.Size(91, 36);
			this.up2.TabIndex = 38;
			this.up2.Text = "Поднять";
			this.up2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.up2.UseAccentColor = false;
			this.up2.UseVisualStyleBackColor = true;
			this.up2.Click += new System.EventHandler(this.up2_Click);
			// 
			// up3
			// 
			this.up3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.up3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.up3.Depth = 0;
			this.up3.HighEmphasis = true;
			this.up3.Icon = null;
			this.up3.Location = new System.Drawing.Point(599, 205);
			this.up3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.up3.MouseState = MaterialSkin.MouseState.HOVER;
			this.up3.Name = "up3";
			this.up3.NoAccentTextColor = System.Drawing.Color.Empty;
			this.up3.Size = new System.Drawing.Size(91, 36);
			this.up3.TabIndex = 39;
			this.up3.Text = "Поднять";
			this.up3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.up3.UseAccentColor = false;
			this.up3.UseVisualStyleBackColor = true;
			this.up3.Click += new System.EventHandler(this.up3_Click);
			// 
			// down2
			// 
			this.down2.AutoSize = false;
			this.down2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.down2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.down2.Depth = 0;
			this.down2.HighEmphasis = true;
			this.down2.Icon = null;
			this.down2.Location = new System.Drawing.Point(342, 253);
			this.down2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.down2.MouseState = MaterialSkin.MouseState.HOVER;
			this.down2.Name = "down2";
			this.down2.NoAccentTextColor = System.Drawing.Color.Empty;
			this.down2.Size = new System.Drawing.Size(91, 36);
			this.down2.TabIndex = 40;
			this.down2.Text = "Опустить";
			this.down2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.down2.UseAccentColor = false;
			this.down2.UseVisualStyleBackColor = true;
			this.down2.Click += new System.EventHandler(this.down2_Click);
			// 
			// down3
			// 
			this.down3.AutoSize = false;
			this.down3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.down3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.down3.Depth = 0;
			this.down3.HighEmphasis = true;
			this.down3.Icon = null;
			this.down3.Location = new System.Drawing.Point(599, 253);
			this.down3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.down3.MouseState = MaterialSkin.MouseState.HOVER;
			this.down3.Name = "down3";
			this.down3.NoAccentTextColor = System.Drawing.Color.Empty;
			this.down3.Size = new System.Drawing.Size(91, 36);
			this.down3.TabIndex = 41;
			this.down3.Text = "Опустить";
			this.down3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.down3.UseAccentColor = false;
			this.down3.UseVisualStyleBackColor = true;
			this.down3.Click += new System.EventHandler(this.down3_Click);
			// 
			// ring1
			// 
			this.ring1.Location = new System.Drawing.Point(109, 365);
			this.ring1.Name = "ring1";
			this.ring1.Size = new System.Drawing.Size(50, 20);
			this.ring1.TabIndex = 1;
			this.ring1.Tag = "1";
			this.ring1.Text = "2";
			this.ring1.UseVisualStyleBackColor = true;
			// 
			// ring2
			// 
			this.ring2.Location = new System.Drawing.Point(99, 385);
			this.ring2.Name = "ring2";
			this.ring2.Size = new System.Drawing.Size(70, 20);
			this.ring2.TabIndex = 1;
			this.ring2.Tag = "2";
			this.ring2.Text = "3";
			this.ring2.UseVisualStyleBackColor = true;
			// 
			// ring3
			// 
			this.ring3.Location = new System.Drawing.Point(89, 405);
			this.ring3.Name = "ring3";
			this.ring3.Size = new System.Drawing.Size(90, 20);
			this.ring3.TabIndex = 1;
			this.ring3.Tag = "3";
			this.ring3.Text = "4";
			this.ring3.UseVisualStyleBackColor = true;
			// 
			// ring4
			// 
			this.ring4.Location = new System.Drawing.Point(79, 425);
			this.ring4.Name = "ring4";
			this.ring4.Size = new System.Drawing.Size(110, 20);
			this.ring4.TabIndex = 1;
			this.ring4.Tag = "4";
			this.ring4.Text = "5";
			this.ring4.UseVisualStyleBackColor = true;
			// 
			// ring5
			// 
			this.ring5.Location = new System.Drawing.Point(69, 445);
			this.ring5.Name = "ring5";
			this.ring5.Size = new System.Drawing.Size(130, 20);
			this.ring5.TabIndex = 1;
			this.ring5.Tag = "5";
			this.ring5.Text = "6";
			this.ring5.UseVisualStyleBackColor = true;
			// 
			// ring6
			// 
			this.ring6.Location = new System.Drawing.Point(59, 465);
			this.ring6.Name = "ring6";
			this.ring6.Size = new System.Drawing.Size(150, 20);
			this.ring6.TabIndex = 1;
			this.ring6.Tag = "6";
			this.ring6.Text = "7";
			this.ring6.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timerLabel
			// 
			this.timerLabel.AutoSize = true;
			this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
			this.timerLabel.Location = new System.Drawing.Point(622, 150);
			this.timerLabel.Name = "timerLabel";
			this.timerLabel.Size = new System.Drawing.Size(55, 22);
			this.timerLabel.TabIndex = 42;
			this.timerLabel.Text = "15:00";
			// 
			// stepsLabel
			// 
			this.stepsLabel.AutoSize = true;
			this.stepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.stepsLabel.Location = new System.Drawing.Point(33, 152);
			this.stepsLabel.Name = "stepsLabel";
			this.stepsLabel.Size = new System.Drawing.Size(75, 20);
			this.stepsLabel.TabIndex = 43;
			this.stepsLabel.Text = "Ходов: 0";
			// 
			// ring7
			// 
			this.ring7.Location = new System.Drawing.Point(49, 485);
			this.ring7.Name = "ring7";
			this.ring7.Size = new System.Drawing.Size(170, 20);
			this.ring7.TabIndex = 1;
			this.ring7.Tag = "7";
			this.ring7.Text = "8";
			this.ring7.UseVisualStyleBackColor = true;
			// 
			// column2
			// 
			this.column2.Enabled = false;
			this.column2.Location = new System.Drawing.Point(385, 331);
			this.column2.Name = "column2";
			this.column2.Size = new System.Drawing.Size(10, 190);
			this.column2.TabIndex = 0;
			this.column2.Tag = "8";
			this.column2.UseVisualStyleBackColor = true;
			// 
			// danet
			// 
			this.danet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.danet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.danet.Depth = 0;
			this.danet.HighEmphasis = true;
			this.danet.Icon = null;
			this.danet.Location = new System.Drawing.Point(158, 76);
			this.danet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.danet.MouseState = MaterialSkin.MouseState.HOVER;
			this.danet.Name = "danet";
			this.danet.NoAccentTextColor = System.Drawing.Color.Empty;
			this.danet.Size = new System.Drawing.Size(158, 36);
			this.danet.TabIndex = 50;
			this.danet.Text = "materialButton1";
			this.danet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.danet.UseAccentColor = false;
			this.danet.UseVisualStyleBackColor = true;
			this.danet.Visible = false;
			// 
			// App
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(780, 580);
			this.Controls.Add(this.danet);
			this.Controls.Add(this.column2);
			this.Controls.Add(this.stepsLabel);
			this.Controls.Add(this.timerLabel);
			this.Controls.Add(this.down3);
			this.Controls.Add(this.down2);
			this.Controls.Add(this.up3);
			this.Controls.Add(this.up2);
			this.Controls.Add(this.down1);
			this.Controls.Add(this.up1);
			this.Controls.Add(this.column3);
			this.Controls.Add(this.column1);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button25);
			this.Controls.Add(this.ring7);
			this.Controls.Add(this.ring6);
			this.Controls.Add(this.ring5);
			this.Controls.Add(this.ring4);
			this.Controls.Add(this.ring3);
			this.Controls.Add(this.ring2);
			this.Controls.Add(this.ring1);
			this.Controls.Add(this.ring0);
			this.Controls.Add(this.materialLabel1);
			this.MaximizeBox = false;
			this.Name = "App";
			this.Sizable = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ханойская башня";
			this.Load += new System.EventHandler(this.App_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private System.Windows.Forms.Button ring0;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button column1;
		private System.Windows.Forms.Button column3;
		private MaterialSkin.Controls.MaterialButton up1;
		private MaterialSkin.Controls.MaterialButton down1;
		private MaterialSkin.Controls.MaterialButton up2;
		private MaterialSkin.Controls.MaterialButton up3;
		private MaterialSkin.Controls.MaterialButton down2;
		private MaterialSkin.Controls.MaterialButton down3;
		private System.Windows.Forms.Button ring1;
		private System.Windows.Forms.Button ring2;
		private System.Windows.Forms.Button ring3;
		private System.Windows.Forms.Button ring4;
		private System.Windows.Forms.Button ring5;
		private System.Windows.Forms.Button ring6;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label timerLabel;
		private System.Windows.Forms.Label stepsLabel;
		private System.Windows.Forms.Button ring7;
		private System.Windows.Forms.Button column2;
		private MaterialSkin.Controls.MaterialButton danet;
	}
}