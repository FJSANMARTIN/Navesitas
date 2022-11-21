using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideMovement : MonoBehaviour
{
   
    public float speedY;
    public float speedX;
    public GameObject explosion;
    public float timer;
    float oscilateTime;
    bool goRight;

   void Update()
   {
      //Si oscilateTime es tres, restar hasta que llegue a cero.
      //Si oscilateTime es cero, sumar hasta que llegue a tres. 

      if(oscilateTime >= timer)
      {
          oscilateTime = timer;
          goRight = true;
      }
      if(oscilateTime <= 0)
      {
          oscilateTime = 0;
          goRight = false;
      }

      //sumar y restar dependiendo del estado de goRight
      if(goRight)
      {
          oscilateTime -= Time.deltaTime;
      }
      if(goRight == false)
      {
          oscilateTime += Time.deltaTime;
      }
   }

   void FixedUpdate() //es fixedupdate para que el suicida, al colisionar con cosas, no empiece a temblar.
   {
        transform.Translate(Vector2.up * speedY * Time.fixedDeltaTime); //el suicida baja infinitamente.

        if(goRight)
        {
            transform.Translate(Vector2.right * speedX * Time.fixedDeltaTime); 
        }
         if(goRight ==  false)
        {
            transform.Translate(Vector2.left * speedX * Time.fixedDeltaTime); 
        }
   }

   void OnTriggerEnter2D(Collider2D other)
   {
       if(other.CompareTag("Player"))
       {
           GameObject fx = Instantiate(explosion, transform.position, Quaternion.identity);
           Destroy(gameObject);
       }
   }
}
