using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baca3 : MonoBehaviour {

    private Vector3 startPosition;
    public float moveSpeed = 1f;
    public float moveDistance = 4f;
    public GameObject randomGO;

    private double accumulator = 0.0;
    private double waitTime = 1.5;

    // Update is called once per frame
    void Update()
    {
        System.Random random = new System.Random();
        int br = random.Next(100);
        accumulator += Time.deltaTime;
        if (accumulator >= waitTime)
        {
            if (br % 3 + 1 == 3)
            {
                startPosition = transform.position;
                GameObject myObj = Instantiate(randomGO) as GameObject;
                myObj.transform.position = transform.position;
            }
            accumulator -= waitTime;
        }
    }
}
