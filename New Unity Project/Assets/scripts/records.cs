using UnityEngine;
using System.Collections;
using System.IO;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class records: MonoBehaviour
{
    //Звук при нажатии на кнопку
    public AudioSource button2;
	// Update is called once per frame
	void Update ()
    {       
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Загрузка сцены
            Application.LoadLevel("menu");
        }
	
	}
 //Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.
     void OnGUI()
    {
         //Реализует System.IO.TextReader, который считываетсимволы из потока байтов в определённой последовательности
        using (StreamReader sr = new StreamReader(@"D:\test.txt"))
        {
            string line;
             while ((line = sr.ReadLine()) != null)
            {

                GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 80, 250, 25), "Предыдущий счёт:" + line); 
            }

   //Button - это типичная интерактивная кнопка. Она сработает один раз при нажатии, независимо от того, как долго будет зажата. Срабатывание происходит в момент отпускания кнопки.           
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 60, 250, 30), "Main menu"))
        {
            //Загрузка сцены
            Application.LoadLevel("menu");
            //Воспроизведение звука
            button2.Play();
           
        }        
     }
}
