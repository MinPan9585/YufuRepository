using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public float downIntervalTime;
    public float upIntervalTime;
    float downTime;
    float upTime;
    public Animator spikeAnim;
    bool isUp = true;

    private void Start()
    {
        downTime = downIntervalTime;
        upTime = upIntervalTime;
    }

    void Update()
    {
        if (isUp)
        {
            downTime -= Time.deltaTime;
            if(downTime<= 0)
            {
                spikeAnim.SetTrigger("Down");
                downTime = downIntervalTime;
                isUp = false;
            }
        }
        else
        {
            upTime -= Time.deltaTime;
            if (upTime <= 0)
            {
                spikeAnim.SetTrigger("Up");
                upTime = upIntervalTime;
                isUp = true;
            }
        }

    }
}
