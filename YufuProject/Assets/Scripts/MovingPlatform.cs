using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform cubeTrans;
    public Transform[] waypointsTrans;
    int index = 0;
    public float speed;

    void Update()
    {
        Vector3 movingDir = waypointsTrans[index].position - cubeTrans.position;
        cubeTrans.position += movingDir.normalized * speed * Time.deltaTime;

        if(Vector3.Distance(waypointsTrans[index].position, cubeTrans.position) <= 0.1f)
        {
            if (index < waypointsTrans.Length-1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            
        }
    }
}
