/*
 * Создано в SharpDevelop.
 * Пользователь: Дмитрий
 * Дата: 02.11.2018
 * Время: 9:08
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
namespace testXML
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBox_filePath;
		private System.Windows.Forms.Button button_fileOPen;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox_search;
		private System.Windows.Forms.Button button_search;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_count;
		private System.Windows.Forms.Button button_xmlCreate;
		private System.Windows.Forms.Button button_xmlOpen;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox_filePath = new System.Windows.Forms.TextBox();
			this.button_fileOPen = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox_search = new System.Windows.Forms.TextBox();
			this.button_search = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label_count = new System.Windows.Forms.Label();
			this.button_xmlCreate = new System.Windows.Forms.Button();
			this.button_xmlOpen = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox_filePath
			// 
			this.textBox_filePath.Location = new System.Drawing.Point(12, 12);
			this.textBox_filePath.Name = "textBox_filePath";
			this.textBox_filePath.Size = new System.Drawing.Size(519, 20);
			this.textBox_filePath.TabIndex = 0;
			// 
			// button_fileOPen
			// 
			this.button_fileOPen.Location = new System.Drawing.Point(537, 12);
			this.button_fileOPen.Name = "button_fileOPen";
			this.button_fileOPen.Size = new System.Drawing.Size(40, 23);
			this.button_fileOPen.TabIndex = 1;
			this.button_fileOPen.Text = "...";
			this.button_fileOPen.UseVisualStyleBackColor = true;
			this.button_fileOPen.Click += new System.EventHandler(this.Button_fileOPenClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 55);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(519, 410);
			this.dataGridView1.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(583, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox_search
			// 
			this.textBox_search.Location = new System.Drawing.Point(319, 481);
			this.textBox_search.Name = "textBox_search";
			this.textBox_search.Size = new System.Drawing.Size(212, 20);
			this.textBox_search.TabIndex = 3;
			// 
			// button_search
			// 
			this.button_search.Location = new System.Drawing.Point(537, 481);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(75, 23);
			this.button_search.TabIndex = 4;
			this.button_search.Text = "поиск";
			this.button_search.UseVisualStyleBackColor = true;
			this.button_search.Click += new System.EventHandler(this.Button_searchClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 481);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Всего:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label_count
			// 
			this.label_count.Location = new System.Drawing.Point(118, 481);
			this.label_count.Name = "label_count";
			this.label_count.Size = new System.Drawing.Size(100, 23);
			this.label_count.TabIndex = 5;
			this.label_count.Text = "0";
			// 
			// button_xmlCreate
			// 
			this.button_xmlCreate.Location = new System.Drawing.Point(548, 55);
			this.button_xmlCreate.Name = "button_xmlCreate";
			this.button_xmlCreate.Size = new System.Drawing.Size(118, 23);
			this.button_xmlCreate.TabIndex = 6;
			this.button_xmlCreate.Text = "создать XML";
			this.button_xmlCreate.UseVisualStyleBackColor = true;
			this.button_xmlCreate.Click += new System.EventHandler(this.Button_xmlCreateClick);
			// 
			// button_xmlOpen
			// 
			this.button_xmlOpen.Location = new System.Drawing.Point(548, 84);
			this.button_xmlOpen.Name = "button_xmlOpen";
			this.button_xmlOpen.Size = new System.Drawing.Size(118, 23);
			this.button_xmlOpen.TabIndex = 6;
			this.button_xmlOpen.Text = "открыть XML";
			this.button_xmlOpen.UseVisualStyleBackColor = true;
			this.button_xmlOpen.Click += new System.EventHandler(this.Button_xmlOpenClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 575);
			this.Controls.Add(this.button_xmlOpen);
			this.Controls.Add(this.button_xmlCreate);
			this.Controls.Add(this.label_count);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_search);
			this.Controls.Add(this.textBox_search);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_fileOPen);
			this.Controls.Add(this.textBox_filePath);
			this.Name = "MainForm";
			this.Text = "testXML";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
