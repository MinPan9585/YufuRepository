using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button3 : MonoBehaviour
{
    public GameObject text3;
    public GameObject text4;

    public void JumpToText2()
    {
        text3.SetActive(false);
        text4.SetActive(true);
    }
}
