using UnityEngine;
using System.Collections;
//Основной родительский класс в Unity - MonoBehaviour
//Его название напрямую идёт от программной среды "Mono", на которой и работает программная часть движка Unity.
//Все скрипты, создаваемые в Unity3d, по умолчанию создаются как дочерние классы от родительского класса MonoBehaviour
public class moveBaground : MonoBehaviour {

    // Скорость объекта
    public Vector2 speed = new Vector2(5, 5);
    // Направление движения
    public Vector2 direction = new Vector2(-1, 0);
    private Vector2 movement;

    void Update()
    {
        // 2 - Перемещение
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }
    // Данная функция вызывается каждый раз при расчете физических показателей. Все расчеты физики следует проводить именно в ней.
    void FixedUpdate()
    {
        //За функцией Rigidbody скрывается Абсолютно Твердое Тело (АТТ).
        //Rigidbody используется для различных объектов, с которыми мы можем взаимодействовать, толкая, пиная и т.п.
        // Применить движение к Rigidbody
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
