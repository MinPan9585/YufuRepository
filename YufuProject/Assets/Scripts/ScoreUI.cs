using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public GameManager gameManager;
    void Update()
    {
        this.GetComponent<Text>().text = "Score: " + gameManager.score.ToString();
    }
}
