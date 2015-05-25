using UnityEngine;
using System.Collections;
using System.IO;
using System;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class End : playerController
//Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.
{    void OnGUI()
    {
    //Button - это типичная интерактивная кнопка. Она сработает один раз при нажатии, независимо от того, как долго будет зажата. Срабатывание происходит в момент отпускания кнопки.
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 15, 250, 25), "Main menu"))
        {
            Application.LoadLevel("menu");
        }
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 85, 250, 25), "Количество времени в партии:" + Math.Round(Time1/60));
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 65, 250, 25), "Количество жизней:" + hp);
        GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 45, 250, 25), "Набранное количество очков:" + score);
       if (score < 5)
       {
           GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 105, 250, 25), "Вы проиграли, вы можете лучше!");
           
       }
       if (score > 5)
       {
           GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 105, 250, 25), "Вы проиграли, вы можете лучше");
       }
    }

}
