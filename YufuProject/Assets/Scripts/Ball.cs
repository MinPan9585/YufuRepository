using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    public float currentPower = 1f;
    private bool isOnGround = false;
    public float jumpForce;
    public GameManager gameManager;
    public GameObject coinParticle;

    public bool gameStarted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Battery"))
        {
            currentPower = 1f;
        }
        if(other.CompareTag("Spike") || other.CompareTag("Water"))
        {
            gameManager.EndGame();
        }
        if (other.CompareTag("Coin"))
        {
            gameManager.score++;
            Destroy(other.gameObject);
            Instantiate(coinParticle, other.gameObject.transform.position, Quaternion.identity);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        isOnGround = true;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Ground"))
    //    {
    //        isOnGround = false;
    //    }
    //}

    private void Update()
    {
        RaycastHit info;
        Physics.Raycast(transform.position, Vector3.down, out info, 0.26f);
        Debug.DrawRay(transform.position, Vector3.down * 0.26f, Color.white);
        if (Physics.Raycast(transform.position, Vector3.down, out info, 0.26f))
        {
            if (info.collider.CompareTag("Ground"))
            {
                isOnGround = true;
            }
        }
        else
        {
            isOnGround = false;
        }
        

        if (currentPower <= 0)
        {
            //game end
            gameManager.EndGame();
            return;
        }
        currentPower -= Time.deltaTime * 0.05f;
    }

    void FixedUpdate()
    {
        Debug.Log(rb.velocity);
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
            print("aaa");
            rb.AddForce(new Vector3(0, jumpForce, 0));
        }
    }
}
