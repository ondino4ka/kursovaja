using UnityEngine;
using System.Threading;
using System;
using System.Diagnostics;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
//update каждый кадр обрабатывает
//start только во врем старта программы
public class playerController : MonoBehaviour {
    //Игровое время
  static internal float Time1;
    //Количество очков
    static internal float score;
    //Начальное количество очков
    internal int spawnScore=0;
    //Скорость игрока
    public float playerSpeed;
    //Началаьная скорость игрока
    private float spawnSpeed = 5.0f;
    //Количество защиты
    internal int armor;
    //Начальное количество защиты
    internal int spawnArmor=0;
    //Количество жизней
    public  int hp;
    //Начальное количество защиты
    internal int spawnHP = 1;
  //Audio Source (источник звука) воспроизводит Audio Clip в сцене.
    //Звук при соприкосновении с очками
    public AudioSource scoreSound;
    //Звук при соприкосновении с жизнями
    public AudioSource hpSound;
    //Звук при соприкосновении с защитой
    public AudioSource armorSound;
    //Звук при соприкосновении с выстрелом
    public AudioSource shootSound;
    //Звук при разрушении корабля
    public AudioSource destructionSound;
    //Звук при соприкосновении с врагом
    public AudioSource enemySound;
   
	// Use this for initialization
	void Start () 
    {
        playerSpeed = spawnSpeed;
        hp = spawnHP;
        armor = spawnArmor;
        score = spawnScore  ;
    }
   
    // Update is called once per frame Обновление вызывается один раз за кадр
	void Update () 
    {
        //Игровое время.Обновление каждый кадр
        Time1 += 1;     
        //Движение по оси "Vertical"   
        float transV = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime; 
        //Time.deltaTime это время которое потребовалось для прохождения последнего кадра. Его стоит использовать только для определения величины в одном кадре которую нужно изменять, чтобы например плавно переместить объект.
       // transform: translate перемещает элемент на указанное количество px при положительных значениях.
        transform.Translate(new Vector2(0, transV));
        //Ускорение 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpeed = 10.0f;   
        }
        else
        {
            playerSpeed = spawnSpeed;
        }                              
	}
    // Данная функция вызывается всякий раз при входе физического тела в зону триггера.
    //Зоной триггера является объект, для которого установлено свойство isTrigger в значении true.
    //При указании данного свойства объект игнорируется физическим движком и используется лишь в качестве инициализации событий.
    // Все функции, связанные с соприкосновением объектов, или пересечении объектом зоны триггера принимают в качестве параметра объект класса Collider
    //содержащий информацию об объекте, с которым произошло взаимодействие.
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.name == "score")
        {            
            score++;       
            //Уничтожение этого объекта
            Destroy(other.gameObject);
            //Воиспроизведение музыки
            scoreSound.Play();          
        }
       
        if (other.gameObject.name == "armor")
        {            
            armor=armor+2;
            //Уничтожение этого объекта
            Destroy(other.gameObject);
            //Воиспроизведение музыки
            armorSound.Play();
        }
        if (other.gameObject.name == "life")
        {           
            hp++;
            //Уничтожение этого объекта
            Destroy(other.gameObject);
            //Воиспроизведение музыки
            hpSound.Play();           
        }
        if (other.gameObject.name == "shooot")
        {
            if (armor >= 1)
            {
                armor=armor-2;
                //Уничтожение этого объекта
                Destroy(other.gameObject);                              
            }
            else
            {
                hp--;
                //Уничтожение этого объекта
                Destroy(other.gameObject);
            }

            if (hp < 1)
            {
                //Уничтожение игрового объекта
                Destroy(gameObject);
                destructionSound.Play();
                //Загрузка сцены
                Application.LoadLevel("loss");            
            }
            //Воиспроизведение музыки
            shootSound.Play();
         
        }
        if (other.gameObject.name == "finish_level")
        {
            //Загрузка уровня
            Application.LoadLevel("finish");         
        }
      
        if (other.gameObject.name == "enemy")
        {
            hp=hp-2;
            //Уничтожение этого объекта
            Destroy(other.gameObject);
            //Воиспроизведение музыки
            enemySound.Play();
            if (hp < 1)
            {
                //Уничтожение игрового объекта
                Destroy(gameObject);
                //Загрузка уровня
                Application.LoadLevel("loss");
            }
        }       
    }  
   //Класс GUI является интерфейсом для настройки графического интерфейса Unity с ручным позиционированием.
  //Данная функция используется для отрисовки элементов игрового интерфейса и вызова событий, связанных с ним.   
 void OnGUI()
    {
        GUI.Box(new Rect(Screen.width - 95, 0, 100, 30), "Timer:" + Math.Round(Time1/60));
        GUI.Box(new Rect(Screen.width - 95, 17, 100, 30), "playerSpeed" + playerSpeed);
        GUI.Box(new Rect(0, 0, 100, 20), "life" + hp);
        GUI.Box(new Rect(0, 40, 100, 20), "score:" + score);
        GUI.Box(new Rect(0, 20, 100, 20), "armor:" + armor);
    } 
}
