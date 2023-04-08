using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    private Image powerImage;
    private Ball ball;
    
    void Start()
    {
        powerImage = GetComponent<Image>();
        ball = GameObject.Find("Ball").GetComponent<Ball>();
    }

    void Update()
    {
        powerImage.fillAmount = ball.currentPower;
    }
}
