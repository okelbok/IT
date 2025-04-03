namespace Lab2_IT
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
			System.Windows.Forms.TabControl MainTabControl;
			System.Windows.Forms.Panel TextPanel;
			System.Windows.Forms.Label ResultTextLabel;
			System.Windows.Forms.Label KeyLabel;
			System.Windows.Forms.Label InitialTextLabel;
			System.Windows.Forms.Panel RegisterPanel;
			System.Windows.Forms.Label InitialStateLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainTabPage = new System.Windows.Forms.TabPage();
			this.ResultTextBox = new System.Windows.Forms.TextBox();
			this.KeyTextBox = new System.Windows.Forms.TextBox();
			this.InitialTextBox = new System.Windows.Forms.TextBox();
			this.ClearFieldsButton = new System.Windows.Forms.Button();
			this.EncodeButton = new System.Windows.Forms.Button();
			this.OutputButton = new System.Windows.Forms.Button();
			this.InputButton = new System.Windows.Forms.Button();
			this.InitialStateTextBox = new System.Windows.Forms.TextBox();
			this.InputDialog = new System.Windows.Forms.OpenFileDialog();
			this.OutputDialog = new System.Windows.Forms.SaveFileDialog();
			MainTabControl = new System.Windows.Forms.TabControl();
			TextPanel = new System.Windows.Forms.Panel();
			ResultTextLabel = new System.Windows.Forms.Label();
			KeyLabel = new System.Windows.Forms.Label();
			InitialTextLabel = new System.Windows.Forms.Label();
			RegisterPanel = new System.Windows.Forms.Panel();
			InitialStateLabel = new System.Windows.Forms.Label();
			MainTabControl.SuspendLayout();
			this.MainTabPage.SuspendLayout();
			TextPanel.SuspendLayout();
			RegisterPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTabControl
			// 
			MainTabControl.Controls.Add(this.MainTabPage);
			MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			MainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			MainTabControl.Location = new System.Drawing.Point(0, 0);
			MainTabControl.Margin = new System.Windows.Forms.Padding(5);
			MainTabControl.Name = "MainTabControl";
			MainTabControl.SelectedIndex = 0;
			MainTabControl.Size = new System.Drawing.Size(982, 653);
			MainTabControl.TabIndex = 0;
			MainTabControl.TabStop = false;
			// 
			// MainTabPage
			// 
			this.MainTabPage.Controls.Add(TextPanel);
			this.MainTabPage.Controls.Add(RegisterPanel);
			this.MainTabPage.Location = new System.Drawing.Point(4, 38);
			this.MainTabPage.Margin = new System.Windows.Forms.Padding(5);
			this.MainTabPage.Name = "MainTabPage";
			this.MainTabPage.Padding = new System.Windows.Forms.Padding(5);
			this.MainTabPage.Size = new System.Drawing.Size(974, 611);
			this.MainTabPage.TabIndex = 0;
			this.MainTabPage.Text = "Потоковое шифрование и дешифрирование файлов";
			this.MainTabPage.UseVisualStyleBackColor = true;
			// 
			// TextPanel
			// 
			TextPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			TextPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			TextPanel.Controls.Add(this.ResultTextBox);
			TextPanel.Controls.Add(ResultTextLabel);
			TextPanel.Controls.Add(this.KeyTextBox);
			TextPanel.Controls.Add(KeyLabel);
			TextPanel.Controls.Add(this.InitialTextBox);
			TextPanel.Controls.Add(InitialTextLabel);
			TextPanel.Location = new System.Drawing.Point(371, 0);
			TextPanel.Name = "TextPanel";
			TextPanel.Size = new System.Drawing.Size(603, 615);
			TextPanel.TabIndex = 1;
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.Location = new System.Drawing.Point(16, 427);
			this.ResultTextBox.Multiline = true;
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ReadOnly = true;
			this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ResultTextBox.Size = new System.Drawing.Size(568, 161);
			this.ResultTextBox.TabIndex = 11;
			this.ResultTextBox.TabStop = false;
			// 
			// ResultTextLabel
			// 
			ResultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			ResultTextLabel.Location = new System.Drawing.Point(11, 383);
			ResultTextLabel.Name = "ResultTextLabel";
			ResultTextLabel.Size = new System.Drawing.Size(573, 41);
			ResultTextLabel.TabIndex = 10;
			ResultTextLabel.Text = "Полученный текст:";
			ResultTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KeyTextBox
			// 
			this.KeyTextBox.Location = new System.Drawing.Point(16, 237);
			this.KeyTextBox.Multiline = true;
			this.KeyTextBox.Name = "KeyTextBox";
			this.KeyTextBox.ReadOnly = true;
			this.KeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.KeyTextBox.Size = new System.Drawing.Size(568, 143);
			this.KeyTextBox.TabIndex = 9;
			this.KeyTextBox.TabStop = false;
			// 
			// KeyLabel
			// 
			KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			KeyLabel.Location = new System.Drawing.Point(11, 193);
			KeyLabel.Name = "KeyLabel";
			KeyLabel.Size = new System.Drawing.Size(573, 41);
			KeyLabel.TabIndex = 8;
			KeyLabel.Text = "Сгенерированный ключ:";
			KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InitialTextBox
			// 
			this.InitialTextBox.Location = new System.Drawing.Point(16, 47);
			this.InitialTextBox.Multiline = true;
			this.InitialTextBox.Name = "InitialTextBox";
			this.InitialTextBox.ReadOnly = true;
			this.InitialTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.InitialTextBox.Size = new System.Drawing.Size(568, 143);
			this.InitialTextBox.TabIndex = 7;
			this.InitialTextBox.TabStop = false;
			// 
			// InitialTextLabel
			// 
			InitialTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			InitialTextLabel.Location = new System.Drawing.Point(11, 3);
			InitialTextLabel.Name = "InitialTextLabel";
			InitialTextLabel.Size = new System.Drawing.Size(573, 41);
			InitialTextLabel.TabIndex = 7;
			InitialTextLabel.Text = "Исходный текст:";
			InitialTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RegisterPanel
			// 
			RegisterPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			RegisterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			RegisterPanel.Controls.Add(this.ClearFieldsButton);
			RegisterPanel.Controls.Add(this.EncodeButton);
			RegisterPanel.Controls.Add(this.OutputButton);
			RegisterPanel.Controls.Add(this.InputButton);
			RegisterPanel.Controls.Add(this.InitialStateTextBox);
			RegisterPanel.Controls.Add(InitialStateLabel);
			RegisterPanel.Location = new System.Drawing.Point(0, 0);
			RegisterPanel.Name = "RegisterPanel";
			RegisterPanel.Size = new System.Drawing.Size(368, 615);
			RegisterPanel.TabIndex = 0;
			// 
			// ClearFieldsButton
			// 
			this.ClearFieldsButton.Location = new System.Drawing.Point(11, 528);
			this.ClearFieldsButton.Name = "ClearFieldsButton";
			this.ClearFieldsButton.Size = new System.Drawing.Size(339, 60);
			this.ClearFieldsButton.TabIndex = 5;
			this.ClearFieldsButton.Text = "Очистить все поля";
			this.ClearFieldsButton.UseVisualStyleBackColor = true;
			this.ClearFieldsButton.Click += new System.EventHandler(this.ClearFieldsButton_Click);
			// 
			// EncodeButton
			// 
			this.EncodeButton.Location = new System.Drawing.Point(11, 374);
			this.EncodeButton.Name = "EncodeButton";
			this.EncodeButton.Size = new System.Drawing.Size(339, 122);
			this.EncodeButton.TabIndex = 3;
			this.EncodeButton.Text = "Зашифровать\r\n|\r\nДешифрировать";
			this.EncodeButton.UseVisualStyleBackColor = true;
			this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
			// 
			// OutputButton
			// 
			this.OutputButton.Location = new System.Drawing.Point(11, 283);
			this.OutputButton.Name = "OutputButton";
			this.OutputButton.Size = new System.Drawing.Size(339, 60);
			this.OutputButton.TabIndex = 2;
			this.OutputButton.Text = "Сохранить в файл";
			this.OutputButton.UseVisualStyleBackColor = true;
			this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
			// 
			// InputButton
			// 
			this.InputButton.Location = new System.Drawing.Point(11, 217);
			this.InputButton.Name = "InputButton";
			this.InputButton.Size = new System.Drawing.Size(339, 60);
			this.InputButton.TabIndex = 1;
			this.InputButton.Text = "Ввести из файла";
			this.InputButton.UseVisualStyleBackColor = true;
			this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
			// 
			// InitialStateTextBox
			// 
			this.InitialStateTextBox.Location = new System.Drawing.Point(11, 69);
			this.InitialStateTextBox.Multiline = true;
			this.InitialStateTextBox.Name = "InitialStateTextBox";
			this.InitialStateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.InitialStateTextBox.Size = new System.Drawing.Size(339, 121);
			this.InitialStateTextBox.TabIndex = 0;
			this.InitialStateTextBox.TextChanged += new System.EventHandler(this.InitialStateTextBox_TextChanged);
			// 
			// InitialStateLabel
			// 
			InitialStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			InitialStateLabel.Location = new System.Drawing.Point(6, 3);
			InitialStateLabel.Name = "InitialStateLabel";
			InitialStateLabel.Size = new System.Drawing.Size(344, 63);
			InitialStateLabel.TabIndex = 0;
			InitialStateLabel.Text = "Начальное состояние регистра (40 бит):";
			InitialStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OutputDialog
			// 
			this.OutputDialog.OverwritePrompt = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 653);
			this.Controls.Add(MainTabControl);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Теория информации, ЛР 2. Потоковое шифрование. Колбеко Влада, гр. 351003";
			MainTabControl.ResumeLayout(false);
			this.MainTabPage.ResumeLayout(false);
			TextPanel.ResumeLayout(false);
			TextPanel.PerformLayout();
			RegisterPanel.ResumeLayout(false);
			RegisterPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage MainTabPage;
		private System.Windows.Forms.TextBox InitialStateTextBox;
		private System.Windows.Forms.Button InputButton;
		private System.Windows.Forms.Button ClearFieldsButton;
		private System.Windows.Forms.Button EncodeButton;
		private System.Windows.Forms.Button OutputButton;
		private System.Windows.Forms.TextBox InitialTextBox;
		private System.Windows.Forms.TextBox ResultTextBox;
		private System.Windows.Forms.TextBox KeyTextBox;
		private System.Windows.Forms.OpenFileDialog InputDialog;
		private System.Windows.Forms.SaveFileDialog OutputDialog;
	}
}

