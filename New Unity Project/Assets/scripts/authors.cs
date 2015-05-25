using UnityEngine;
using System.Collections;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class authors : MonoBehaviour
{
    //Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.
     void OnGUI()
     {
      GUI.Box( new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 250, 30), "Пример простой игры на C#.");
      GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 70, 250, 30), "Автор:Сироткин Константин");
      if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 -40, 250, 25), "main menu"))
      {
          //Загрузка сцены
          Application.LoadLevel("menu");
          
      }
     }
}
