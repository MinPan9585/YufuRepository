using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject explosionFX;

    private void Start()
    {
        explosionFX = Resources.Load<GameObject>("Prefab/ExplosionFX");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //kill player
            Destroy(this.gameObject);
            //play sfx and vfx
            Instantiate(explosionFX, transform.position, Quaternion.identity);
        }
        else
        {
            Destroy(this.gameObject);
            Instantiate(explosionFX, transform.position, Quaternion.identity);
        }
    }
}
