using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    private Vector3 startPosition;
    public float moveSpeed = 1f;
    public float moveDistance = 4f;
    public GameObject randomGO;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("enter"))
        {

            startPosition = transform.position;
            GameObject myObj = Instantiate(randomGO) as GameObject;
            myObj.transform.position = transform.position;
        }
    }
}
