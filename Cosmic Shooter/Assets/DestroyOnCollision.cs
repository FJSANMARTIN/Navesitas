using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    
    public GameObject fx;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            GameObject explosion = Instantiate(fx, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
