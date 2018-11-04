/*
 * Создано в SharpDevelop.
 * Пользователь: Дмитрий
 * Дата: 04.11.2018
 * Время: 14:35
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System;
//using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace testXML
{
	/// <summary>
	/// Description of ListWord.
	/// </summary>
	public class ListWord
	{
		string _filePathWord;
		List<Word> listW = new List<Word>();
		
		
		public ListWord(string filePathWord)
		{
			_filePathWord = filePathWord;
		}
		
		
		public List<Word> GetListWord()
		{
			
						
			string[] str =  File.ReadAllLines(_filePathWord);
			var readWord = new string[4]; 			
		
			for (int i = 0; i < str.Length  ; i++) {
				readWord = str[i].Split('\t');				
			listW.Add(new Word(){Id=i, WordEn=readWord[0], WordTr=readWord[1], WordRu=readWord[2]});
			}
				
			return  listW;	
			
		}
	}
}
