using UnityEngine;
using System.Collections;
using System.IO;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class finish : playerController {

	void Start () 
    {
        //Реализует System.IO.TextWriter для записи симоволов в поток определённой последовательности
        StreamWriter file = new StreamWriter(@"D:\test.txt"); // Создаем поток сохранения 
        file.Write(score);      
        file.Close(); // Закрыть поток после записи
	}	

  //Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.
      void OnGUI()
    { //Button - это типичная интерактивная кнопка. Она сработает один раз при нажатии, независимо от того, как долго будет зажата. Срабатывание происходит в момент отпускания кнопки.
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 35, 250, 25), "main menu"))
        {
      Application.LoadLevel("menu");
        }    
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 60, 250, 25), "Количество очков за уровень:" + score);
        GUI.Box( new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 250, 90), "Победа!!!"); 
    }

}

