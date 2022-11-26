using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float health;
    public GameObject fx;
    public GameObject[] powerup;
   
    public void Update()
    {
        if(health <= 0)
        {
             GameObject hp = Instantiate(powerup[Random.Range(0, powerup.Length)], transform.position, Quaternion.identity);
             health = 0;
             GameObject explosion = Instantiate(fx, transform.position, Quaternion.identity);
             Destroy(gameObject);
        }
    }
   
}
