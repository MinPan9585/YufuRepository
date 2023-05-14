using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sea : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -1);
    }


    void Update()
    {
        //rb.velocity = new Vector3(0, 0, -10);
        //Debug.Log(rb.velocity.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            SceneManager.LoadScene("BossScene0514");
        }
    }
}
