using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
   public GameObject bulletPrefab;
   public Transform firePoint;
   public Transform rotationObject;
    

   public float bulletForce = 20f;
   public float cooldownTime = 0.5f;
   float nextFireTime = 0;



   private void Update()
   {
        if (Input.GetKey(KeyCode.Space) && Time.time > nextFireTime) // Si el jugador presiona espacio y el cooldown ha acabado
        {
            Shoot();
        }
   }

   void Shoot()
   {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, rotationObject.rotation); //spawnear la bala
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); //obtener fisicas de la bala
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse); // añadir fuerza superior a la bala
        nextFireTime = Time.time + cooldownTime; // añadir cooldown
   }
}
