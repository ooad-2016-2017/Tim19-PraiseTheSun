using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    //public GameObject me;

    void Update()
    {
        /*if (Input.GetKeyDown("space"))
        {
            Destroy(gameObject);
        }*/
        var a=GameObject.FindGameObjectWithTag("Xander").transform.position;
        Vector3 b= new Vector3(0, 0, 0);
        if (a.x>-0.5 && a.x<0.5 && a.y<0.5 && a.y > -0.5 && Input.GetKey("space"))
        {
            /*if (Input.GetKey("space"))
            {*/

                Destroy(gameObject);
            //}
            
        }
    }
}
