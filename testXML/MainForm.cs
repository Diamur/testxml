/*
 * Создано в SharpDevelop.
 * Пользователь: Дмитрий
 * Дата: 02.11.2018
 * Время: 9:08
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;



namespace testXML
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ListWord lw;
		XmlSerializer serial;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		 //Взять строки из файла
        public string[] GetFileReadAllLines(string defoultPath){
        	return File.ReadAllLines(defoultPath);        	
        }
		
		
		void Button_fileOPenClick(object sender, EventArgs e)
		{		
			OpenFileDialog dlg = new OpenFileDialog(); 
			if(dlg.ShowDialog() == DialogResult.OK) 
			textBox_filePath.Text = dlg.FileName;			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			lw = new ListWord(textBox_filePath.Text);			
			dataGridView1.DataSource= lw.GetListWord();
			label_count.Text= dataGridView1.RowCount.ToString();
		}		
			
		
		//создание хмл
		void Button_xmlCreateClick(object sender, EventArgs e)
		{
			lw = new ListWord(textBox_filePath.Text);
			serial = new XmlSerializer(typeof(List<Word>));
			using(FileStream fs = new FileStream(Environment.CurrentDirectory+@"\word.xml",FileMode.Create,FileAccess.Write))
			{
				serial.Serialize(fs,lw.GetListWord());
				MessageBox.Show("Создан XML");
			
			}
	
		}
		
		//Чтение
		void Button_xmlOpenClick(object sender, EventArgs e)
		{
			
			List<Word> word = new List<Word>();
			serial = new XmlSerializer(typeof(List<Word>));
			using(FileStream fs = new FileStream(Environment.CurrentDirectory+@"\word.xml",FileMode.Open,FileAccess.Read))
			{
				word = serial.Deserialize(fs) as List<Word>;				
			}
			dataGridView1.DataSource= word;
	
		}
		
		
		//Поиск
		void Button_searchClick(object sender, EventArgs e)
		{
	
		}
		
		
		//Редактирование
		
	
	}
}