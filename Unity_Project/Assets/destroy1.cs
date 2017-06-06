using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class destroy1 : MonoBehaviour
{
    public Score_check Sc;

    void Update()
    {

        bool b = false;
        var a = GameObject.FindGameObjectWithTag("kvadrat1").transform.position;

        if (Input.GetKeyDown("left"))
        {
            Destroy(gameObject);
            b = true;
        }

        if (a.x > -5 && a.x < -4 && a.y < 0.5 && a.y > -0.5 && b)
        {
            Text_scoring.Sc.increase();

        }
        if (a.y <= -4.5)
        {
            Destroy(gameObject);
        }
    }
}