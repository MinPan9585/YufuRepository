using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    public GameObject text2;
    public GameObject text3;

    public void JumpToText2()
    {
        text2.SetActive(false);
        text3.SetActive(true);
    }
}
