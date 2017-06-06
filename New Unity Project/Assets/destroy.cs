using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    //public GameObject me;

    void OnTriggerEnter(Collider collider)
    {
        
            Destroy(gameObject);
        
    }
}
