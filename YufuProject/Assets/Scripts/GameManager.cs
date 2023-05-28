using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public int score = 0;

    private void Start()
    {
        ball = GameObject.Find("Ball");
    }

    public void EndGame()
    {
        ball.GetComponent<Rigidbody>().position = new Vector3(12, 4, -13);
        ball.GetComponent<Ball>().currentPower = 1f;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        //Debug.Log(ball.GetComponent<Rigidbody>().velocity);
    }
}
