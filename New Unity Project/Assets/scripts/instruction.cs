using UnityEngine;
using System.Collections;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class instruction : MonoBehaviour {

    public AudioSource button1;
 //Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.
    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 105, 250, 25), "Инструкция:");

        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 80, 250, 20), "D - ПАУЗА");
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 60, 250, 20), "SHIFT - УСКОРЕНИЕ");
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 40, 250, 20), "A- ГЛАВНОЕ МЕНЮ");
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 20, 250, 20), "W- ↑ - ВЕРХ");
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 0, 250, 25), "S- ↓ - НИЗ");
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 25, 250, 25), "Собирайте звёздочки");
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 50 , 250, 25), "Не касайтесь снарядов");
        //Button - это типичная интерактивная кнопка. Она сработает один раз при нажатии, независимо от того, как долго будет зажата. Срабатывание происходит в момент отпускания кнопки.
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 + 75 , 250, 25), "main menu"))
        {

            Application.LoadLevel("menu");
            button1.Play();

        }
        if (GUI.Button(new Rect(Screen.width/2-100,Screen.height/2+ 100,250,25), "Authors"))
        {
            Application.LoadLevel("authors");
            button1.Play();
        }
    }
}
