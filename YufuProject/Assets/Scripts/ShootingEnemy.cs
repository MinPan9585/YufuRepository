using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public float fireCooldown;
    float timer;
    public GameObject bulletPrefab;
    public float force;

    private void Start()
    {
        timer = fireCooldown;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            //shoot
            GameObject bullet1 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            GameObject bullet2 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            GameObject bullet3 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            GameObject bullet4 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            GameObject bullet5 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            GameObject bullet6 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            GameObject bullet7 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            GameObject bullet8 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet1.GetComponent<Rigidbody>().AddForce(new Vector3(1,0,0)*force);
            bullet2.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 0) * force);
            bullet3.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1) * force);
            bullet4.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -1) * force);
            bullet5.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 1).normalized * force);
            bullet6.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, 1).normalized * force);
            bullet7.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, -1).normalized * force);
            bullet8.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, -1).normalized * force);

            timer = fireCooldown;
        }
    }
}
