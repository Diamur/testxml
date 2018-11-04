/*
 * Создано в SharpDevelop.
 * Пользователь: Дмитрий
 * Дата: 04.11.2018
 * Время: 10:51
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace testXML
{
	/// <summary>
	/// Description of Word.
	/// </summary>
	[Serializable]
	public class Word
	{
	public int Id { get; set; }	
	public string WordEn { get; set; }
	public string WordTr { get; set; }
	public string WordRu { get; set; }
	}
}
