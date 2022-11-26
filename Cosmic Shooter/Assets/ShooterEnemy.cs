using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : MonoBehaviour
{
    [Header("Logic")]
    public float downTime;
    public bool goRight;
    public float cooldownTime;
    public GameObject projectile;
    public float bulletForce;
    public Transform spawn1;
    public Transform spawn2;
    float cooldown;

    [Header("Movement")]
    public float speedY;
    public float speedX;
    bool canMoveY = true;
    bool canMoveX = false;
  
    void Update() //maneja logica
    {
         downTime -= Time.deltaTime;
         if(downTime <= 0)
         {
             downTime = 0;
             canMoveX = true;
             canMoveY = false;

             if(Time.time > cooldown)
             {
                 Shoot();
             }
         }
    }

    void FixedUpdate() // maneja movimiento.
    {
        if(canMoveY == true && canMoveX == false)
        {
            transform.Translate(Vector2.down * speedY * Time.fixedDeltaTime);  
        }

        if(canMoveX == true && canMoveY == false)
        {
            if(goRight)
            {
                transform.Translate(Vector2.right * speedX * Time.fixedDeltaTime); 
            }
            if(goRight ==  false)
            {
                transform.Translate(Vector2.left * speedX * Time.fixedDeltaTime); 
            }     
        }
    }

    void Shoot() // maneja el doble disparo
   {
        GameObject bullet1 = Instantiate(projectile, spawn1.position, spawn1.rotation); //spawnear la bala
        GameObject bullet2 = Instantiate(projectile, spawn2.position, spawn2.rotation); //spawnear la bala
        Rigidbody2D rb1 = bullet1.GetComponent<Rigidbody2D>(); //obtener fisicas de la bala
        Rigidbody2D rb2 = bullet2.GetComponent<Rigidbody2D>(); //obtener fisicas de la bala
        rb1.AddForce(spawn1.up * bulletForce, ForceMode2D.Impulse); // añadir fuerza superior a la bala
        rb2.AddForce(spawn2.up * bulletForce, ForceMode2D.Impulse); // añadir fuerza superior a la bala
        cooldown = Time.time + cooldownTime; // añadir cooldown
   }
}
