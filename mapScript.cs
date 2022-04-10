using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("map script Start");
        //возможно тут надо программно активировать коллайдеры
        //и прописать что они отслеживают два спрайта с домом и с героем
    }
    public static string HeroName = "SpriteHero";
    // Update is called once per frame
    void Update()
    {
        var gobject = GameObject.Find(HeroName);
        var transf = gobject.GetComponent<Transform>();
        int speed = 10;
        Debug.Log("HERO x,y="+gobject.transform.position.x+" "+ gobject.transform.position.y);
        //
        if (Input.GetKeyDown(KeyCode.W))
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
