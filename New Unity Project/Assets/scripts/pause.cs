using UnityEngine;
using System.Collections;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class pause : MonoBehaviour
{
    public AudioSource pauseSound;
    bool paused = false;
    //в  Update проверим, нажата ли клавиша. Если клавиша нажата и переменная paused равна false, то меняем значение переменной на true и останавливаем игровое время. 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Загрузка уровня
            Application.LoadLevel("menu");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (!paused)
            {
                //Time Scale Скорость течения времени.  
                //При значении 1 время течёт нормально. При значении 0.5 время замедлятся на половину; при значении 2 время ускоряется в 2 раза.
                Time.timeScale = 0;
                paused = true;
                pauseSound.Play();
            }
            // Если переменная равна true и нажата кнопка - меняем ее значение на false и запускаем игровое время. 
            else
            {
                Time.timeScale = 1;
                paused = false;
                pauseSound.Play();
            }
        }
    }
   //Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.
    void OnGUI()
    {
        if (paused)
        {

            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 250, 80), "PAUSE");
        }
    }
}
        
    

