using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    private Vector3 offset;
    public GameObject ball;

    void Start()
    {
        //ball = GameObject.Find("Ball");
        offset = ball.transform.position - transform.position;
    }

    void Update()
    {
        transform.position = ball.transform.position - offset;
    }
}
