using UnityEngine;
using System.Collections;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class games : MonoBehaviour 
{

    public AudioSource button1;
    public AudioSource menu;
    private bool menu_music = true;
  //Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.
    void OnGUI()
    {
        //Button - это типичная интерактивная кнопка. Она сработает один раз при нажатии, независимо от того, как долго будет зажата. Срабатывание происходит в момент отпускания кнопки.
        if (GUI.Button(new Rect(0, 20, 100, 20), "lvl1"))
        {

            Application.LoadLevel("lvl1");
            button1.Play();

        }
        if (GUI.Button(new Rect(0, 40, 100, 20), "lvl2"))
        {

            Application.LoadLevel("lvl2");
            button1.Play();


        }
        if (GUI.Button(new Rect(0, 60, 100, 20), "lvl3"))
        {

            Application.LoadLevel("lvl3");
            button1.Play();


        }
        GUI.Label(new Rect(0, 0, 1000, 100), "Выберите уровень:");
        if (GUI.Button(new Rect(0, 80, 100, 20), "main menu"))
        {

            Application.LoadLevel("menu");
            button1.Play();

        }
        if ((GUI.Button(new Rect(Screen.width - 75, Screen.height - 55, 75, 50), "Выкл муз") & menu_music))
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
   }
}
