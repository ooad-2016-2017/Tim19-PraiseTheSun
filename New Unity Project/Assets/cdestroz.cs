using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cdestroz : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {

        Destroy(gameObject);
        Debug.Log("fhg");
    }
}
