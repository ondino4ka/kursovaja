using UnityEngine;
using System.Collections;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class MainMenu : MonoBehaviour
{
    bool menu_music=true;
    public AudioSource button1;
    public AudioSource menu;
 //Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.
    void OnGUI() 
    {
//GUI.Box (Rect (A, B, C, D), "Текст");
//A - количество пикселей от левого края экрана к левому краю окна. 
//B - количество пикселей от верхнего края экрана к верхнему краю окна. 
//C - ширина окна. 
//D - высота окна. 
        //Button - это типичная интерактивная кнопка. Она сработает один раз при нажатии, независимо от того, как долго будет зажата. Срабатывание происходит в момент отпускания кнопки.
        if ((GUI.Button( new Rect (Screen.width - 75, Screen.height - 55, 75, 50), "Выкл муз") & menu_music))
        {
          menu.Pause();
          menu_music = false;
          button1.Play();
        }

        if ((GUI.Button(new Rect(Screen.width - 75, Screen.height - 105, 75, 50), "Вкл муз") & !menu_music))
           {
               menu.Play();
               menu_music = true;
               button1.Play();
           }       
        if (GUI.Button(new Rect(Screen.width - 80, Screen.height - 405, 80, 50), "Start"))
        {          
               Application.LoadLevel("games");
                button1.Play();
        }
        if (GUI.Button(new Rect(Screen.width - 80, Screen.height-255, 80, 50), "Exit"))
        { 
            //Данная функция вызывается при выходе из игры.
            Application.Quit();
            button1.Play();
        }
        if (GUI.Button(new Rect(Screen.width - 80, Screen.height - 355, 80, 50), "Score"))
        {          
            Application.LoadLevel("record");
            button1.Play();          
        }
        if (GUI.Button(new Rect(Screen.width - 80, Screen.height - 305, 80, 50), "Help"))
        {
            Application.LoadLevel("instruction");
            button1.Play();
        }
      
	}

}