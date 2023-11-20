namespace Ханойская_башня
{
	partial class Start
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
			this.SuspendLayout();
			// 
			// materialLabel1
			// 
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(57, 77);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(258, 85);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Работу выполнил студент МЦК-ЧЭМК группы Ип5-21 Антонов Александр";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// materialButton1
			// 
			this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
			this.materialButton1.Depth = 0;
			this.materialButton1.HighEmphasis = true;
			this.materialButton1.Icon = null;
			this.materialButton1.Location = new System.Drawing.Point(119, 184);
			this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
			this.materialButton1.Size = new System.Drawing.Size(124, 36);
			this.materialButton1.TabIndex = 1;
			this.materialButton1.Text = "Приложение";
			this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
			this.materialButton1.UseAccentColor = false;
			this.materialButton1.UseVisualStyleBackColor = true;
			this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
			// 
			// Start
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 229);
			this.Controls.Add(this.materialButton1);
			this.Controls.Add(this.materialLabel1);
			this.Name = "Start";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Приложение \"Ханойская башня\"";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialButton materialButton1;
	}
}

