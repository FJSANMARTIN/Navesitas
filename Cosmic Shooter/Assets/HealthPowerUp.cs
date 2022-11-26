using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
   public float healthAmount;
   
   void OnTriggerEnter2D(Collider2D other)
   {
	   if(other.CompareTag("Player"))
	   {
		   other.GetComponent<PlayerMovement>().health += healthAmount;
		   Destroy(gameObject);
	   }

	   if(other.CompareTag("Eliminator"))
	   {
		   Destroy(gameObject);
	   }
   }

}
