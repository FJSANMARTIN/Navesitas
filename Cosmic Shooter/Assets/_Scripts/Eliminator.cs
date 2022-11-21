using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eliminator : MonoBehaviour
{
 
// destruye el enemigo cuando colisiona con el eliminador en la parte inferior de la pantalla.
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Eliminator"))
        {
            Destroy(gameObject);
        }
    }
}
