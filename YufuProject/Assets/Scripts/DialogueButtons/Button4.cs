using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button4 : MonoBehaviour
{
    public GameObject text4;
    public GameObject text5;

    public void JumpToText2()
    {
        text4.SetActive(false);
        text5.SetActive(true);
    }
}
