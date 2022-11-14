using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public float input;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>(); //detecta las físicas del objeto del jugador (su rigidbody)
    }

    void Update()
    {
        input = Input.GetAxisRaw("Horizontal"); //obtiene el Input de unity (detecta que el input horizontal es A/D o Dcha/Izda)
    }

    void FixedUpdate() //es fixedupdate para que las colisiones de la nave con las paredes no se vuelvan locas.
    {
        transform.Translate(Vector2.right * input * speed * Time.fixedDeltaTime); //mueve la nave cuando se presiona el input, en funcion de speed)
    }
}
