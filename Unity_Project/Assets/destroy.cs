using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    //public GameObject me;

    public Score_check Sc;

    void Update()
    {
        bool b = false;
        var a = GameObject.FindGameObjectWithTag("Xander").transform.position;

        if (Input.GetKeyDown("down"))
        {
            Destroy(gameObject);
            b = true;
        }

        if (a.x > -0.5 && a.x < 0.5 && a.y < 0.5 && a.y > -0.5 && b)
        {
            Text_scoring.Sc.increase();

        }
        if (a.y <= -4.5)
        {
            Destroy(gameObject);
        }
    }
}
