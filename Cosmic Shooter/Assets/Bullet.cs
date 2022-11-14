using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject fx;
  

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject explosion = Instantiate(fx, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
