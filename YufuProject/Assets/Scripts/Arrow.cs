using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Transform ballTrans;
    public Rigidbody ballRb;

    public float angle;
    //public Vector3 dir;

    void Update()
    {
        angle = - Mathf.Rad2Deg * Mathf.Atan2(ballRb.velocity.z, ballRb.velocity.x) + 90;
        //rotate y axis
        transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));



        //not working
        //dir = new Vector3(ballRb.velocity.x, 0, ballRb.velocity.z);
        //transform.rotation.SetLookRotation(dir, Vector3.up);


        // set the position same as ball position
        transform.position = ballTrans.position;
    }
}
