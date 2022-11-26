using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    public ShooterEnemy papi;
    public bool right;

    public void Update()
    {
        papi.goRight = right;
    }
    void OnTriggerEnter2D(Collider2D other) //cambia la direccion en el script ShooterEnemy del GameObject padre, al colisionar con los bordes de la pantalla.
    {
           if(right == false)
           {
               right = true;
           }
           else if(right == true)
           {
               right = false;
           }
    }
}
