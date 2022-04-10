using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    public static string HeroName = "image 3";//"HeroOnMap";
    public static string typeLevel = "";
    // Start is called before the first frame update
    void Start()
    {
        // допустим хотим двигать объект "image 3" по нажатию клавиш WASD
        // по нажатию кнопки прилетает оповещение что кнопка нажата в Винду (ОС)
        // у кнопки есть код допустим что клавиша А это код 044
        // приложениям надо отслеживать эти оповещения и понимать какая клавиша нажата
        // 
        // На сенсорном экране телефона есть координаты и есть координаты нажатия на экран
        // можно например сделать область управления (круг) и если координаты нажатия
        // попали в сектор круга "влево" то и объект едет влево
        // или сделать 4 кнопки по нажатию на которых отслеживать управление
        //
        // можно сприпт управления потом прикрутить к нашей старой игре

        //для теста - пропишем в коде. этот параметр надо задавать с карты
        //в зависимости от того дома, куда герой приходит
        typeLevel = "seno";


        if (typeLevel == "seno")
        {
            //Debug.Log("try CHANGE");
            // загружаем в монетку "image 3" другое изображение
            // "image3_seno"
            var gameObject = GameObject.Find("image 3");
            loadSprite("image 3_seno", gameObject);
        }
    }
    public void loadSprite(string name, GameObject playerObj)
    {
        //06.03 ошибка загрузки спрайтов в этой строке
        //нужно создать папку Resources
        //не помогло
        //09.03 помогло вот что находим ВСЕ ресурсы с именем
        //и в цикле проверяем получилось преобразование в спрайт или нет
        //
        var resall = Resources.LoadAll(name);
        //Debug.Log("found =" + resall.Length);
        //Assets / BayatGames / Free Platform Game Assets / Coin Animation / png / 2x / image 3_seno.png

        string ress = "";
        foreach (var obj in resall)
        {
            //ress = ress +" _ "+ obj.name;
            var sp = obj as Sprite;
            if (sp != null)
            {
                var render = playerObj.GetComponent<SpriteRenderer>();
                render.sprite = sp;

            }
            else
            {
                //Debug.Log("NO SPRITE " + name);
            }
        }
        //Debug.Log("SPRITE TEST " + ress);
        //var spp = Resources.Load(name);

    }
    public void upClick()
    {
        var gobject = GameObject.Find(HeroName);
        var transf = gobject.GetComponent<Transform>();
        int speed = 1;
        transf.Translate(0, speed, 0);
    }
    public void downClick()
    {
        var gobject = GameObject.Find(HeroName);
        var transf = gobject.GetComponent<Transform>();
        int speed = 1;
        transf.Translate(0, -speed, 0);
    }
    public void leftClick()
    {
        var gobject = GameObject.Find(HeroName);
        var transf = gobject.GetComponent<Transform>();
        int speed = 1;
        transf.Translate(-0.5f, 0, 0);
        //todo сделать во вторник 05.04
    }
    public void rightClick()
    {
        var gobject = GameObject.Find(HeroName);
        var transf = gobject.GetComponent<Transform>();
        int speed = 1;
        transf.Translate(0.5f, 0, 0);
        //todo сделать во вторник 05.04
    }
    public void HouseClick_01()
    {
        //допустим герой подошел к первому дому и нажал
        //загружаем сцену уровня с изменением ассетов монеток и травы
        //для этого нам в сцену уровня передать параметр - какие из ассетов мы используем
        //
        //надо отслежить пересечение "границ" спрайта героя и домика
        //есть границы героя и домика, углы (ЛВ, ПВ, ЛН, ПН) и надо поискать как отследить
        //
        //в скрипте сцены должен быть параметр который мы в функции Старт обработаем
        // if (typeLevel="seno") ...load Assets ("seno")
        //
        //battlePlayer.playerName = menuTextScript.playerName;
        SceneManager.LoadScene("Demo");
    }

    // Update is called once per frame
    void Update()
    {
        var gobject = GameObject.Find(HeroName);
        var transf = gobject.GetComponent<Transform>();
        int speed = 1;
        //
        if (Input.GetKeyDown( KeyCode.W ) )
        {
            //w up
            transf.Translate(0, speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //s down
            transf.Translate(0, -speed, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //A left
            transf.Translate(-speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //D right
            transf.Translate(speed, 0, 0);
        }
    }

}
