using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float speed;
    Rigidbody2D rb;
    float input;

    [Header("Health and Life")]
    public float health;
    public GameObject explosion;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //detecta las físicas del objeto del jugador (su rigidbody)
    }

    void Update()
    {
        input = Input.GetAxisRaw("Horizontal"); //obtiene el Input de unity (detecta que el input horizontal es A/D o Dcha/Izda)
        if(health <= 0) // cuando la vida llega a cero, muere y suelta una explosion
        {
            health = 0;
            GameObject fx = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if(health > 10) //hace que no se pueda tener mas vida que la permitida.
        {
            health = 10;
        }
    }

    void FixedUpdate() //es fixedupdate para que la nave, al colisionar con las paredes, no empiece a temblar.
    {
        transform.Translate(Vector2.right * input * speed * Time.fixedDeltaTime); //mueve la nave cuando se presiona el input, en funcion de speed)
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy") || other.CompareTag("Bullet")) // se le quita la vida cuando entra en contacto con una bala o con un enemigo.
        {
            health -= other.GetComponent<EnemyDamage>().damage;
        }
    }
}
