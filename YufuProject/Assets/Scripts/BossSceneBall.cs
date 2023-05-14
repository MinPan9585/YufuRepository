using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSceneBall : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    //public float currentPower = 1f;
    private bool isOnGround = true;
    public float jumpForce;

    private bool gameStarted = true;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Battery"))
    //    {
    //        currentPower = 1f;
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = false;
        }
    }

    private void Update()
    {
        //if (currentPower <= 0)
        //{
        //    //game end
        //    return;
        //}
        //currentPower -= Time.deltaTime * 0.05f;
    }

    void FixedUpdate()
    {
        if (!gameStarted)
            return;
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-force, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(force, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 0, force));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector3(0, 0, -force));
        }
        if(Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Keypad0) && isOnGround) 
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
        }
    }
}
