using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button5 : MonoBehaviour
{
    public GameObject canvas;
    public Ball ball;

    public void JumpToText2()
    {
        canvas.SetActive(false);
        ball.gameStarted = true;
    }
}
