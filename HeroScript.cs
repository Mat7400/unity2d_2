using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private int counter = 0;
    //Just overlapped a collider 2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger ENTER "+ counter);
        counter++;
    }

    //Overlapping a collider 2D
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Do something
        //Do something
        Debug.Log("trigger STAY " + counter);
        counter++;
    }

    //Just stop overlapping a collider 2D
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Do something
    }
    //Just hit another collider 2D
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Do something
        Debug.Log("collision ENTER " + counter);
        counter++;
    }

    //Hitting a collider 2D
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Do something
        //Do something
        Debug.Log("collision STAY " + counter);
        counter++;
    }

    //Just stop hitting a collider 2D
    private void OnCollisionExit2D(Collision2D collision)
    {
        //Do something
    }
}
