using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public void JumpToText2()
    {
        text1.SetActive(false);
        text2.SetActive(true);
    }
}
