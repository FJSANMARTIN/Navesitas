    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject fx;
    public float dmg;
    bool canDmg = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy") && canDmg)
        {
            other.GetComponent<EnemyHealth>().health -= dmg;
            canDmg = false;
            GameObject explode = Instantiate(fx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        GameObject explosion = Instantiate(fx, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
