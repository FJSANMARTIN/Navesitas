using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float health;
    public GameObject fx;
   
    public void Update()
    {
        if(health <= 0)
        {
             health = 0;
             GameObject explosion = Instantiate(fx, transform.position, Quaternion.identity);
             Destroy(gameObject);
        }
    }
   
}
