using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    public float speed;
    public GameObject explosion;
  

    // Update is called once per frame
   void FixedUpdate() //es fixedupdate para que el asteroide, al colisionar con cosas, no empiece a temblar.
   {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime); //el asteroide baja infinitamente.
   }

   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.CompareTag("Player") || other.CompareTag("Eliminator"))
       {
           GameObject fx = Instantiate(explosion, transform.position, Quaternion.identity);
           Destroy(gameObject);
       }
   }
}
