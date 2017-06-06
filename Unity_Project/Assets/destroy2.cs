using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy2 : MonoBehaviour {


    void Update()
    {
        bool b=false;
        var a = GameObject.FindGameObjectWithTag("kvadra2").transform.position;

        if (Input.GetKeyDown("right"))
        {
            Destroy(gameObject);
            b = true;
        }

        if (a.x > 4.6 && a.x < 5.6 && a.y < 0.5 && a.y > -0.5 && b)
        {        
            Text_scoring.Sc.increase();

        }

        if (a.y <= -4.5)
        {
            Destroy(gameObject);
        }
    }
}
